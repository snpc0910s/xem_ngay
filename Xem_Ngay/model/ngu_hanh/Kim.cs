using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model
{
    class Kim : NguHanh
    {
        public String ten = "Kim";

        // --------------- Ngũ hành sinh khắc ----------------------------
        public NguHanh biKhacBoi()
        {
            return NguHanhInstance.HOA;
        }

        public NguHanh duocSinhBoi()
        {
            return NguHanhInstance.THO;
        }

        public NguHanh khac()
        {
            return NguHanhInstance.MOC;
        }

        public NguHanh sinh()
        {
            return NguHanhInstance.THUY;
        }
    }
}
