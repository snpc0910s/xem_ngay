using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.thien_can
{
    class Nham : ThienCan
    {
        public readonly String ten = "Nhâm";
        public override NguHanh nguHanh()
        {
            return NguHanhInstance.THUY;
        }

        public override ThienCan thienCanHopHoa()
        {
            return ThienCanInstance.DINH;
        }
    }
}
