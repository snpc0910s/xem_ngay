using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xem_Ngay.model.ngu_hanh
{
    class UnknownNguHanh : NguHanh
    {
        public UnknownNguHanh()
        {
            this.ten = "Unknown";
        }

        public override NguHanh biKhacBoi()
        {
            throw new NotImplementedException();
        }

        public override NguHanh duocSinhBoi()
        {
            throw new NotImplementedException();
        }

        public override NguHanh khac()
        {
            throw new NotImplementedException();
        }

        public override NguHanh sinh()
        {
            throw new NotImplementedException();
        }
    }
}
