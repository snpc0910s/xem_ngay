using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.thien_can
{
    public class Ky : ThienCan
    {
        public Ky()
        {
            this.sothutu = 6;
            this.ten = "Kỷ";
        }
        public override NguHanh nguHanh()
        {
            return NguHanhInstance.THO;
        }

        public override ThienCan thienCanHopHoa()
        {
            return ThienCanInstance.GIAP;
        }
    }
}
