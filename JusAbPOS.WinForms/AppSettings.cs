using System.Configuration;
using System.Globalization;
using JusAbPOS.Domain;

namespace JusAbPOS.WinForms
{
    /// <summary>Reads optional business settings from App.config (&lt;appSettings&gt;); safe defaults if a key is missing.</summary>
    internal static class AppSettings
    {
        public static decimal TaxRatePercent
        {
            get
            {
                decimal v;
                var raw = ConfigurationManager.AppSettings["TaxRatePercent"];
                return decimal.TryParse(raw, NumberStyles.Number, CultureInfo.InvariantCulture, out v) && v >= 0 && v <= 100 ? v : 12m;
            }
        }

        private static string Get(string key, string fallback)
        {
            var v = ConfigurationManager.AppSettings[key];
            return string.IsNullOrWhiteSpace(v) ? fallback : v.Trim();
        }

        public static void ApplyBusinessInfo(ReceiptData receipt)
        {
            receipt.BusinessName = Get("BusinessName", "JusAbPOS");
            receipt.BusinessAddress = Get("BusinessAddress", "123 Main Street, City");
            receipt.BusinessPhone = Get("BusinessPhone", "+1 555 0100");
        }
    }
}
