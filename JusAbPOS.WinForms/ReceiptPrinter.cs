using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using JusAbPOS.Domain;
using JusAbPOS.Services;

namespace JusAbPOS.WinForms
{
    /// <summary>80 mm thermal-style receipt (tutorial B.4). Works with any Windows printer or "Microsoft Print to PDF".</summary>
    public sealed class ReceiptPrinter : IReceiptPrinter
    {
        private const int PaperWidth = 315;      // hundredths of an inch (about 80 mm)
        private ReceiptData current;

        public void Preview(ReceiptData receipt)
        {
            current = receipt;
            using (var doc = BuildDocument())
            using (var dialog = new PrintPreviewDialog { Document = doc, Width = 520, Height = 760 })
                dialog.ShowDialog();
        }

        public void Print(ReceiptData receipt)
        {
            current = receipt;
            using (var doc = BuildDocument()) doc.Print();
        }

        private PrintDocument BuildDocument()
        {
            var doc = new PrintDocument { DocumentName = "Receipt " + current.OrderNumber };
            doc.DefaultPageSettings.PaperSize = new PaperSize("Receipt80mm", PaperWidth, 900);
            doc.DefaultPageSettings.Margins = new Margins(8, 8, 8, 8);
            doc.PrintPage += DrawPage;
            return doc;
        }

        private void DrawPage(object sender, PrintPageEventArgs e)
        {
            var r = current;
            var g = e.Graphics;
            using (var body = new Font("Consolas", 8.5f))
            using (var bold = new Font("Consolas", 8.5f, FontStyle.Bold))
            using (var title = new Font("Consolas", 12f, FontStyle.Bold))
            {
                float x = e.MarginBounds.Left, y = e.MarginBounds.Top, w = e.MarginBounds.Width;
                var center = new StringFormat { Alignment = StringAlignment.Center };

                Action<string, Font, bool> line = (text, font, centered) =>
                {
                    if (centered) g.DrawString(text, font, Brushes.Black, new RectangleF(x, y, w, font.GetHeight(g) + 2), center);
                    else g.DrawString(text, font, Brushes.Black, x, y);
                    y += font.GetHeight(g) + 2;
                };
                Action rule = () => line(new string('-', 38), body, false);

                line(r.BusinessName, title, true);
                line(r.BusinessAddress, body, true);
                line(r.BusinessPhone, body, true);
                rule();
                line("Order : " + r.OrderNumber, body, false);
                line("Date  : " + r.Date.ToString("yyyy-MM-dd HH:mm"), body, false);
                line("Cashier: " + r.CashierName, body, false);
                rule();

                foreach (var item in r.Lines)
                {
                    var name = item.ProductName.Length > 38 ? item.ProductName.Substring(0, 38) : item.ProductName;
                    line(name, body, false);
                    line(string.Format("  {0} x {1:N2}", item.Quantity, item.UnitPrice).PadRight(24) + item.Amount.ToString("N2").PadLeft(14), body, false);
                }

                rule();
                line(Money("Subtotal", r.Subtotal), body, false);
                if (r.Discount > 0) line(Money("Discount", -r.Discount), body, false);
                line(Money("Tax", r.Tax), body, false);
                line(Money("TOTAL", r.Total), bold, false);
                rule();
                line(Money("Paid (" + r.PaymentMethod + ")", r.AmountTendered), body, false);
                line(Money("Change", r.Change), body, false);
                rule();
                line("Thank you for your purchase!", body, true);
            }
            e.HasMorePages = false;
        }

        private static string Money(string label, decimal value)
        {
            return label.PadRight(22) + value.ToString("N2").PadLeft(16);
        }
    }
}
