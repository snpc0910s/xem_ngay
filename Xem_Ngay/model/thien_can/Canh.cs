using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.thien_can
{
    class Canh : ThienCan
    {
        public Canh()
        {
            this.sothutu = 7;
            this.ten = "Canh";
        }
        public override NguHanh nguHanh()
        {
            return NguHanhInstance.KIM;
        }

        public override ThienCan thienCanHopHoa()
        {
            return ThienCanInstance.AT;
        }
    }
}
