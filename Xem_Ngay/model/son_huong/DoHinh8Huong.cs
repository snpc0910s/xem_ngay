using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.ultility;

namespace Xem_Ngay.model.son_huong
{
    public class DoHinh8Huong
    {
        private static readonly List<String> LIST_TEN_8_HUONG = new List<String> { "Bắc", "Đông Bắc", "Đông", "Đông Nam", "Nam", "Tây Nam", "Tây", "Tây Bắc" };
        public static readonly MapRangeCircle<String> DH_8_HUONG = new MapRangeCircle<string>().withListKey(LIST_TEN_8_HUONG, 337.5);

        public static String timHuongQuaToaDo(double toaDo)
        {
            return DH_8_HUONG.getSingleValueByPosition(toaDo);
        }
    }
}
