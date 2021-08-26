using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model
{
    class Hoa : NguHanh
    {
        public String ten = "Hoả";
    
        // --------------- Ngũ hành sinh khắc ----------------------------
        public NguHanh biKhacBoi()
        {
            return NguHanhInstance.THUY;
        }

        public NguHanh duocSinhBoi()
        {
            return NguHanhInstance.MOC;
        }

        public NguHanh khac()
        {
            return NguHanhInstance.KIM;
        }

        public NguHanh sinh()
        {
            return NguHanhInstance.THO;
        }
    }
}
