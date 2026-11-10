using System;
using System.Globalization;
using System.Windows.Forms;

namespace JusAbPOS.WinForms
{
    /// <summary>Screens that can reload their data (F5 in the main window).</summary>
    internal interface IRefreshable
    {
        void RefreshData();
    }

    /// <summary>Message boxes used by every screen: friendly text for expected problems, a safe generic text (plus a log entry) for the rest.</summary>
    internal static class UiHelper
    {
        /// <summary>
        /// The number currently TYPED in a NumericUpDown. NumericUpDown.Value only changes after the box loses focus or
        /// Enter is pressed, so live previews (change due, totals) must read the text instead.
        /// </summary>
        public static decimal LiveValue(NumericUpDown box)
        {
            decimal typed;
            if (decimal.TryParse(box.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out typed))
                return Math.Max(box.Minimum, Math.Min(box.Maximum, typed));
            return box.Value;
        }

        public static void Warn(string text, string caption)
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool Confirm(string text, string caption)
        {
            return MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public static void ShowError(Exception ex, string caption)
        {
            if (ex is ArgumentException || ex is InvalidOperationException || ex is UnauthorizedAccessException)
                Warn(ex.Message, caption);
            else
            {
                AppLog.Write(ex);
                MessageBox.Show("The operation failed. Check the database connection or contact the administrator.",
                    caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
