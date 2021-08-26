using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.bat_quai
{
    class QuaiChan : BatQuai
    {

        public QuaiChan()
        {
            this.ten = "Chấn";
            this.tenGhep = "Lôi";
            this.nhiPhan = new bool[] { false, false, true };
        }
        public override NguHanh nguHanh()
        {
            return NguHanhInstance.MOC;
        }

        public override string pathImage()
        {
            return BatQuai.PATH_IMG_ROOT + "chan.PNG";
        }
    }
}
