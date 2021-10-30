using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Xem_Ngay.ui_layout.dialog
{
    public partial class DialogInfo : Form
    {
        public DialogInfo(String message)
        {
            InitializeComponent();
            this.lbMessage.Text = message;
        }

        private void dialogInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
