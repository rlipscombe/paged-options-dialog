using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PagedOptionsDialog
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var dlg = new OptionsDialog();
            dlg.Pages.Add(new GeneralOptionsPage());
            dlg.Pages.Add(new EmailOptionsPage());
            dlg.Pages.Add(new AdvancedOptionsPage());
            dlg.ShowDialog();
        }
    }
}
