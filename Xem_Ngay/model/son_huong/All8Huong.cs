using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.ultility;

namespace Xem_Ngay.model.son_huong
{
    public class All8Huong
    {
        public static readonly List<String> LIST_TEN_8_HUONG = new List<String> { "Bắc","Đông Bắc", "Đông","Đông Nam", "Nam","Tây Nam","Tây","Tây Bắc" };
        public static readonly MapRangeCircle<String> ALL_8_CUNG = new MapRangeCircle<string>().withListKey(LIST_TEN_8_HUONG, 337.5);


    }
}
