using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model
{
    class Thuy : NguHanh
    {
        public String ten = "Thuỷ";

        // --------------- Ngũ hành sinh khắc ----------------------------
        public NguHanh biKhacBoi()
        {
            return NguHanhInstance.THO;
        }

        public NguHanh duocSinhBoi()
        {
            return NguHanhInstance.KIM;
        }

        public NguHanh khac()
        {
            return NguHanhInstance.HOA;
        }

        public NguHanh sinh()
        {
            return NguHanhInstance.MOC;
        }
    }
}
