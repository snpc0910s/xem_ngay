using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model
{
    class Hoa : NguHanh
    {
        public Hoa()
        {
            this.ten = "Hoả";
        }
    
        // --------------- Ngũ hành sinh khắc ----------------------------
        public override NguHanh biKhacBoi()
        {
            return NguHanhInstance.THUY;
        }

        public override NguHanh duocSinhBoi()
        {
            return NguHanhInstance.MOC;
        }

        public override NguHanh khac()
        {
            return NguHanhInstance.KIM;
        }

        public override NguHanh sinh()
        {
            return NguHanhInstance.THO;
        }
    }
}
