using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.ultility;

namespace Xem_Ngay.model.son_huong
{
    public class All24SonHuong
    {
        public static readonly List<String> LIST_24_SON_HUONG = new List<String> { "Nhâm","Tý","Quý", "Sửu", "Cấn", "Dần","Giáp","Mão","ẤT"
                                                                                ,"Thìn","Tốn","Tị", "Bính", "Ngọ", "Đinh","Mùi","Khôn","Thân"
                                                                                ,"Canh","Dậu","Tân", "Tuất", "Càn", "Hợi"};
        public static readonly MapRangeCircle<String> ALL_24_SON_HUONG = new MapRangeCircle<string>().withListKeyRemoveEpsilon(LIST_24_SON_HUONG, 337.5, 1.5);

    }
}
