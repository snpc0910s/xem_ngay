using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.ultility;
using Xem_Ngay.model.luc_thap_hoa_giap;
namespace Xem_Ngay.model.son_huong
{
    public class DoHinh64Que
    {
        // biểu diễn lần lượt từ góc 0 dộ
        private static readonly List<String> LIST_TEN_64_QUE = new List<String>() { "Địa Lôi Phục", "Sơn Lôi Di", "Thuỷ Lôi Truân", "Phong Lôi Ích", "Chấn vi Lôi", "Hoả Lôi Phệ Hạp", "Trạch Lôi Tuỳ", "Thiên Lôi Vô Vọng", "Địa Hoả Minh Di", "Sơn Hoả Bí", "Thuỷ Hoả Ký Tế", "Phong Hoả Giai Nhân", "Lôi Hoả Phong", "Ly vi Hoả", "Trạch Hoả Cách", "Thiên Hoả Đồng Nhân", "Địa Trạch Lâm", "Sơn Trạch Tổn", "Thuỷ Trạch Tiết", "Phong Trạch Trung Phu", "Lôi Trạch Quy Muội", "Hoả Trạch Khuê", "Đoài vi Trạch", "Thiên Trạch Lý", "Địa Thiên Thái", "Sơn Thiên Đại Súc", "Thuỷ Thiên Nhu", "Phong Thiên Tiểu Súc", "Lôi Thiên Đại Tráng", "Hoả Thiên Đại Hữu", "Trạch Thiên Quải", "Càn vi Thiên", "Thiên Phong Cấu", "Trạch Phong Đại Quá", "Hoả Phong Đỉnh", "Lôi Phong Hằng", "Tốn vi Phong", "Thuỷ Phong Tỉnh", "Sơn Phong Cổ", "Địa Phong Thăng", "Thiên Thuỷ Tụng", "Trạch Thuỷ Khốn", "Hoả Thuỷ Vị Tế", "Lôi Thuỷ Giải", "Phong Thuỷ Hoán", "Khảm vi Thuỷ", "Sơn Thuỷ Mông", "Địa Thuỷ Sư", "Thiên Sơn Độn", "Trạch Sơn Hàm", "Hoả Sơn Lữ", "Lôi Sơn Tiểu quá", "Phong Sơn Tiệm", "Thuỷ Sơn Kiển", "Cấn vi Sơn", "Địa Sơn Khiêm", "Thiên Địa Bĩ", "Trạch Địa Tuỵ", "Hoả Địa Tấn", "Lôi Địa Dự", "Phong Địa Quán", "Thuỷ Địa Tỷ", "Sơn Địa Bác", "Khôn vi Địa" };
        public static readonly MapRangeCircle<String> DH_64_QUE = new MapRangeCircle<string>().withListKey(LIST_TEN_64_QUE, 0);

        public static String timTenQueBangToaDo(double toaDo)
        {
            String tenQue = DH_64_QUE.getSingleValueByPosition(toaDo);
            return tenQue;
        }

    }
}
