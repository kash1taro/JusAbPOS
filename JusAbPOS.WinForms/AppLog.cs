using System;
using System.IO;

namespace JusAbPOS.WinForms
{
    /// <summary>Writes full exception details to %LocalAppData%\JusAbPOS\logs so users only ever see a safe message.</summary>
    internal static class AppLog
    {
        public static void Write(Exception ex)
        {
            try
            {
                var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "JusAbPOS", "logs");
                Directory.CreateDirectory(dir);
                File.AppendAllText(Path.Combine(dir, "error.log"),
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "  " + ex + Environment.NewLine + Environment.NewLine);
            }
            catch { /* logging must never crash the app */ }
        }
    }
}
