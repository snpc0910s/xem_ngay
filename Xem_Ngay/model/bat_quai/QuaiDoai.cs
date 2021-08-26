using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.bat_quai
{
    class QuaiDoai: BatQuai
    {

        public QuaiDoai() {
            this.ten = "Đoài";
            this.tenGhep = "Trạch";
            this.nhiPhan = new bool[] { false, true, true };
        }

        public override NguHanh nguHanh()
        {
            return NguHanhInstance.KIM;
        }

        public override string pathImage()
        {
            return BatQuai.PATH_IMG_ROOT + "doai.PNG";
        }
    }
}
