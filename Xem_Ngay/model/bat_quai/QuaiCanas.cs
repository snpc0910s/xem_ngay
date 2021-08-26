using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.bat_quai
{
    class QuaiCanas : BatQuai
    {
        public QuaiCanas()
        {
            this.ten = "Cấn";
            this.tenGhep = "Sơn";
            this.nhiPhan = new bool[] { true, false, false };
        }
        public override NguHanh nguHanh()
        {
            return NguHanhInstance.THO;
        }

        public override string pathImage()
        {
            return BatQuai.PATH_IMG_ROOT + "cana.PNG";
        }
    }
}
