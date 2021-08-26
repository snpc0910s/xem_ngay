using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.bat_quai
{
    class QuaiKhon : BatQuai
    {

        public QuaiKhon()
        {
            this.ten = "Khôn";
            this.tenGhep = "Địa";
            this.nhiPhan = new bool[] { false, false, false };
        }

        public override NguHanh nguHanh()
        {
            return NguHanhInstance.THO;
        }

        public override string pathImage()
        {
            return BatQuai.PATH_IMG_ROOT + "khon.PNG";
        }
    }
}
