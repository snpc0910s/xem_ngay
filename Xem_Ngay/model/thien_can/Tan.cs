using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.thien_can
{
    class Tan : ThienCan
    {
        public Tan()
        {
            this.sothutu = 8;
            this.ten = "Tân";
        }
        public override NguHanh nguHanh()
        {
            return NguHanhInstance.KIM;
        }

        public override ThienCan thienCanHopHoa()
        {
            return ThienCanInstance.BINH;
        }
    }
}
