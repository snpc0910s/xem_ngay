using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model
{
    class Thuy : NguHanh
    {
        
        public Thuy()
        {
            this.ten = "Thuỷ";
        }

        // --------------- Ngũ hành sinh khắc ----------------------------
        public override NguHanh biKhacBoi()
        {
            return NguHanhInstance.THO;
        }

        public override NguHanh duocSinhBoi()
        {
            return NguHanhInstance.KIM;
        }

        public override NguHanh khac()
        {
            return NguHanhInstance.HOA;
        }

        public override NguHanh sinh()
        {
            return NguHanhInstance.MOC;
        }
    }
}
