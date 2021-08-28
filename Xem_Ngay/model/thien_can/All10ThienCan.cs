using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.am_duong;


namespace Xem_Ngay.model.thien_can
{
    class All10ThienCan
    {
        public static readonly List<ThienCan> ALL_THIEN_CAN = new List<ThienCan>() { ThienCanInstance.GIAP, ThienCanInstance.AT, ThienCanInstance.BINH, ThienCanInstance.DINH, ThienCanInstance.MAU, ThienCanInstance.KY, ThienCanInstance.CANH, ThienCanInstance.TAN, ThienCanInstance.NHAM, ThienCanInstance.QUY };

        public static readonly List<String> LST_TEN_THIEN_CAN_AM = new List<String> { "Ất","Đinh","Kỷ","Tân","Quý"};
        public static readonly List<String> LST_TEN_THIEN_CAN_DUONG = new List<String> { "Giáp","Bính","Mậu","Canh","Nhâm"};



        public static String layAmDuongThienCan(ThienCan thienCan)
        {
            String ten = thienCan.ten;
            if (LST_TEN_THIEN_CAN_DUONG.Contains(ten)) return AmDuong.DUONG;
            return AmDuong.AM;
        }
        public static ThienCan thienCanGioTyBatDau1NgayMoi(ThienCan thienCanNgay)
        {
            int tinh = (thienCanNgay.sothutu * 2 - 1) % 10;
            foreach (ThienCan tc in ALL_THIEN_CAN)
            {
                if (tc.sothutu == tinh) return tc;
            }
            return null;
        }
        public static ThienCan thienCanThangDanBatDauNamMoi(ThienCan thienCanNam)
        {
            int tinh = (thienCanNam.sothutu * 2 + 1) % 10;
            foreach (ThienCan tc in ALL_THIEN_CAN)
            {
                if (tc.sothutu == tinh) return tc;
            }
            return null;
        }

    }
}
