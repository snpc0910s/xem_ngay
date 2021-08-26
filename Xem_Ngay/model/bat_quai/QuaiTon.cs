using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.bat_quai
{
    class QuaiTon : BatQuai
    {
        public QuaiTon()
        {
            this.ten = "Tốn";
            this.tenGhep = "Phong";
            this.nhiPhan = new bool[] { true, true, false };
        }
        public override NguHanh nguHanh()
        {
            return NguHanhInstance.MOC;
        }

        public override string pathImage()
        {
            return BatQuai.PATH_IMG_ROOT + "ton.PNG";
        }
    }
}
