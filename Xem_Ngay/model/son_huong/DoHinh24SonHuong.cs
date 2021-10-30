using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.ultility;
using Xem_Ngay.model.luc_thap_hoa_giap;
namespace Xem_Ngay.model.son_huong
{
    class DoHinh24SonHuong
    {
        // không được thay đổi thứ tự 24 sơn
        public static readonly List<String> LIST_24_SON_HUONG = new List<String> { "Nhâm","Tý","Quý", "Sửu", "Cấn", "Dần","Giáp","Mão","ẤT"
                                                                                ,"Thìn","Tốn","Tị", "Bính", "Ngọ", "Đinh","Mùi","Khôn","Thân"
                                                                                ,"Canh","Dậu","Tân", "Tuất", "Càn", "Hợi"};
        public static readonly MapRangeCircle<String> DH_24_SON_HUONG = new MapRangeCircle<string>().withListKeyRemoveEpsilon(LIST_24_SON_HUONG, 337.5, 1.5);

        public static String timTen24SonBangToaDo(double toaDo)
        {
            String son1 = DH_24_SON_HUONG.getSingleValueByPosition(toaDo); 
            //String son2 = DH_24_SON_HUONG.getSingleValueByPosition(toaDo+ 0.1); // vì getSingleValueByPosition sẽ lấy thằng đầu tiên thoả mãn nếu không có Epsilon
            //if (son1.Equals(son2)) return son1;
            return son1 ; // không vong, = null nếu lâm không vong
        }
        
    }
}
