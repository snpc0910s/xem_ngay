using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model
{
    class Moc : NguHanh
    {
        public String ten = "Mộc";

        // --------------- Ngũ hành sinh khắc ----------------------------
        public NguHanh biKhacBoi()
        {
            return NguHanhInstance.KIM;
        }

        public NguHanh duocSinhBoi()
        {
            return NguHanhInstance.THUY;
        }

        public NguHanh khac()
        {
            return NguHanhInstance.THO;
        }

        public NguHanh sinh()
        {
            return NguHanhInstance.HOA;
        }
    }
}
