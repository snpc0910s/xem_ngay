using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model
{
    class Tho : NguHanh
    {
        public String ten = "Thổ";
        
        // --------------- Ngũ hành sinh khắc ----------------------------
        public NguHanh biKhacBoi()
        {
            return NguHanhInstance.MOC;
        }

        public NguHanh duocSinhBoi()
        {
            return NguHanhInstance.HOA;
        }

        public NguHanh khac()
        {
            return NguHanhInstance.THUY;
        }

        public NguHanh sinh()
        {
            return NguHanhInstance.KIM;
        }
    }
}
