using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.ultility;
namespace Xem_Ngay.model.son_huong
{
    public class DoHinh4Phuong
    {
        private static readonly List<String> LIST_TEN_4_PHUONG = new List<String> { "Bắc", "Đông", "Nam", "Tây" };
        public static readonly MapRangeCircle<String> DH_4_PHUONG = new MapRangeCircle<string>().withListKey(LIST_TEN_4_PHUONG, 315);

    }
}
