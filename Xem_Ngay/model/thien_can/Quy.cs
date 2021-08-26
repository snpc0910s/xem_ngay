using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.thien_can
{
    class Quy : ThienCan
    {
        public Quy()
        {
            this.sothutu = 10;
            this.ten = "Quý";
        }
        public override NguHanh nguHanh()
        {
            return NguHanhInstance.THUY;
        }

        public override ThienCan thienCanHopHoa()
        {
            return ThienCanInstance.MAU;
        }
    }
}
