using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Xem_Ngay.model._64que;

namespace Xem_Ngay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // test
            //Console.WriteLine("======================================");
            //Que que1 = AllQueDich.THIEN_DIA_BI;
            //Console.WriteLine("DA:  9 9  Quái Khí: " + que1.quaiKhi + "  " + que1.quaiVan);
            //Que que2 = AllQueDich.THUAN_KHON;
            //Console.WriteLine("DA:  1 1  Quái Khí: " + que2.quaiKhi + "  " + que2.quaiVan);
            //Que que3 = AllQueDich.PHONG_THIEN_TIEU_SUC;
            //Console.WriteLine("DA:  2 8  Quái Khí: " + que3.quaiKhi + "  " + que3.quaiVan);
            //Que que4 = AllQueDich.SON_PHONG_CO;
            //Console.WriteLine("DA:  6 7  Quái Khí: " + que4.quaiKhi + "  " + que4.quaiVan);
            //Console.WriteLine("======================================");
        }

        private void btnTimQue_Click(object sender, EventArgs e)
        {
            String input = this.txtTimQue.Text.Trim();
            if (input.Equals("")) {
                return;
            }
            this.logTextBox.Text = "";
            List<Que> lstQue = AllQueDich.timQueBangTen(input);
            if (lstQue.Count == 0) {
                this.logTextBox.Text = "Qủe không tồn tại";
            } else
            {
                this.logTextBox.AppendText("Total: " + lstQue.Count);
                this.logTextBox.AppendText(Environment.NewLine);
                foreach (Que que in lstQue)
                {
                    String out1Que = "Tên: " + que.ten + "  Quái Khí: " + que.quaiKhi + "  Quái Vận: " + que.quaiVan;
                    this.logTextBox.AppendText(out1Que);
                    this.logTextBox.AppendText(Environment.NewLine);
                }
            }
            
        }
    }
}
