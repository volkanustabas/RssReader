using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RssReader
{
    public partial class FrmSingle : UserControl
    {
        public FrmSingle()
        {
            InitializeComponent();
        }

        private void lbl_url_Click(object sender, EventArgs e)
        {
            Process.Start(lbl_url.Text);
        }
    }
}