using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseControl.Views.UserControls
{
    public partial class Quickstart : DevExpress.XtraEditors.XtraUserControl
    {
        public Quickstart()
        {
            InitializeComponent();
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/MatthewKing/DeviceId",
                UseShellExecute = true
            });
        }
    }
}
