using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;
namespace Xem_Ngay.model
{
   public abstract class ThienCan
    {
        protected String ten;

        public abstract NguHanh nguHanh();

        public abstract ThienCan thienCanHopHoa();
    }
}
