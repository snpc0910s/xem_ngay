using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.thien_can
{
    class Dinh : ThienCan
    {
        public Dinh()
        {
            this.sothutu = 4;
            this.ten = "Dinh";
        }
        public override NguHanh nguHanh()
        {
            return NguHanhInstance.HOA;
        }

        public override ThienCan thienCanHopHoa()
        {
            return ThienCanInstance.NHAM;
        }
    }
}
