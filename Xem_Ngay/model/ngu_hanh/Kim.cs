using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model
{
    class Kim : NguHanh
    {
        public Kim()
        {
            this.ten = "Kim";
        }

        // --------------- Ngũ hành sinh khắc ----------------------------
        public override NguHanh biKhacBoi()
        {
            return NguHanhInstance.HOA;
        }

        public override NguHanh duocSinhBoi()
        {
            return NguHanhInstance.THO;
        }

        public override NguHanh khac()
        {
            return NguHanhInstance.MOC;
        }

        public override NguHanh sinh()
        {
            return NguHanhInstance.THUY;
        }
    }
}
