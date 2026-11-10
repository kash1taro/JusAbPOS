using System;
using System.Windows.Forms;
using JusAbPOS.Domain;

namespace JusAbPOS.WinForms
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Tutorial section 19: log the exception, show a safe message, never reveal SQL / connection details.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += (s, e) => ReportUnhandled(e.Exception);
            AppDomain.CurrentDomain.UnhandledException += (s, e) => ReportUnhandled(e.ExceptionObject as Exception);

            // Login -> Dashboard -> (Logout) -> Login ...
            while (true)
            {
                User user;
                using (var login = new LoginForm())
                {
                    if (login.ShowDialog() != DialogResult.OK) return;
                    user = login.AuthenticatedUser;
                }

                bool signedOut;
                using (var main = new MainForm(user))
                {
                    Application.Run(main);
                    signedOut = main.LoggedOut;
                }
                if (!signedOut) return;
            }
        }

        private static void ReportUnhandled(Exception ex)
        {
            if (ex != null) AppLog.Write(ex);
            MessageBox.Show("Something went wrong. The problem was recorded - please contact the administrator.",
                "JusAbPOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
