using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.bat_quai
{
    class QuaiKham : BatQuai
    {
        public QuaiKham()
        {
            this.ten = "Khảm";
            this.tenGhep = "Thuỷ";
            this.nhiPhan = new bool[] { false, true, false };
        }
        public override NguHanh nguHanh()
        {
            return NguHanhInstance.THUY;
        }

        public override string pathImage()
        {
            return BatQuai.PATH_IMG_ROOT + "kham.PNG";
        }
    }
}
