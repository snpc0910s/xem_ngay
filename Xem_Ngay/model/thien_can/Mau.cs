using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.thien_can
{
    class Mau : ThienCan
    {
        public readonly String ten = "Mậu";
        public override NguHanh nguHanh()
        {
            return NguHanhInstance.THO;
        }

        public override ThienCan thienCanHopHoa()
        {
            return ThienCanInstance.QUY;
        }
    }
}
