using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.thien_can
{
    public class At : ThienCan
    {
        public readonly String ten = "Ất";
        public override NguHanh nguHanh()
        {
            return NguHanhInstance.MOC;
        }

        public override ThienCan thienCanHopHoa()
        {
            return ThienCanInstance.CANH;
        }
    }
}
