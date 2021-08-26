using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xem_Ngay.model.ngu_hanh
{
    public abstract class NguHanh
    {
        public string ten;

        public abstract NguHanh sinh();
        public abstract NguHanh khac();

        public abstract NguHanh biKhacBoi();
         
        public abstract NguHanh duocSinhBoi();

    }
}
