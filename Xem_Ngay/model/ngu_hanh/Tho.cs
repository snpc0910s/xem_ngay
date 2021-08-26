using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model
{
    class Tho : NguHanh
    {
        public Tho()
        {
            this.ten = "Thổ";
        }
        
        // --------------- Ngũ hành sinh khắc ----------------------------
        public override NguHanh biKhacBoi()
        {
            return NguHanhInstance.MOC;
        }

        public override NguHanh duocSinhBoi()
        {
            return NguHanhInstance.HOA;
        }

        public override NguHanh khac()
        {
            return NguHanhInstance.THUY;
        }

        public override NguHanh sinh()
        {
            return NguHanhInstance.KIM;
        }
    }
}
