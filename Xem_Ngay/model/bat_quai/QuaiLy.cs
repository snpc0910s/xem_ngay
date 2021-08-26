using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.bat_quai
{
    class QuaiLy : BatQuai
    {

        public QuaiLy(){
            this.ten = "Ly";
            this.tenGhep = "Hoả";
            this.nhiPhan = new bool[] { true, false, true };
        }
        public override NguHanh nguHanh()
        {
            return NguHanhInstance.HOA;
        }

        public override string pathImage()
        {
            return BatQuai.PATH_IMG_ROOT +  "ly.PNG";
        }
    }
}
