using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xem_Ngay.model.ngu_hanh
{
    class NguHanhInstance
    {
        public static readonly NguHanh HOA = new Hoa();
        public static readonly NguHanh KIM = new Kim();
        public static readonly NguHanh THO = new Tho();
        public static readonly NguHanh MOC = new Moc();
        public static readonly NguHanh THUY = new Thuy();
    }
}
