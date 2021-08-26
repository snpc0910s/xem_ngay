using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.thien_can
{
    class Binh : ThienCan
    {
        public readonly String ten = "Bính";
        public override NguHanh nguHanh()
        {
            return NguHanhInstance.HOA;
        }

        public override ThienCan thienCanHopHoa()
        {
            return ThienCanInstance.TAN;
        }
    }
}
