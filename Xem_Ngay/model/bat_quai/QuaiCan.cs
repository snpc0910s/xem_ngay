using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.bat_quai
{
    class QuaiCan : BatQuai
    {
        
        public QuaiCan() {
            this.ten = "Càn";
            this.tenGhep = "Thiên";
            this.nhiPhan =  new bool[]{ true, true, true };
        }

        public override NguHanh nguHanh()
        {
            return NguHanhInstance.KIM;
        }

        public override string pathImage()
        {
            return BatQuai.PATH_IMG_ROOT + "can.PNG";
        }
    }
}
