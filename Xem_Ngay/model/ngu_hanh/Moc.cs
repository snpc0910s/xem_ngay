using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model
{
    class Moc : NguHanh
    {
        
        public Moc()
        {
            this.ten = "Mộc";
        }

        // --------------- Ngũ hành sinh khắc ----------------------------
        public override NguHanh biKhacBoi()
        {
            return NguHanhInstance.KIM;
        }

        public override NguHanh duocSinhBoi()
        {
            return NguHanhInstance.THUY;
        }

        public override NguHanh khac()
        {
            return NguHanhInstance.THO;
        }

        public override NguHanh sinh()
        {
            return NguHanhInstance.HOA;
        }
    }
}
