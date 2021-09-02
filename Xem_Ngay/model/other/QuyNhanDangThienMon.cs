using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.ultility;
using Xem_Ngay.model.thien_can;

namespace Xem_Ngay.model.other
{
    public class QuyNhanDangThienMon
    {
        public static readonly string VU_THUY = "Vũ Thuỷ";
        public static readonly string KINH_CHAP = "Kinh Chập";
        public static readonly string XUAN_PHAN = "Xuân Phân";
        public static readonly string THANH_MINH = "Thanh Minh";
        public static readonly string COC_VU = "Cốc Vũ";
        public static readonly string LAP_HA = "Lập Hạ";
        public static readonly string TIEU_MAN = "Tiểu Mãn";
        public static readonly string MANG_CHUNG = "Mang Chủng";
        public static readonly string HA_CHI = "Hạ Chí";
        public static readonly string TIEU_THU = "Tiểu Thử";
        public static readonly string DAI_THU = "Đại Thử";
        public static readonly string LAP_THU = "Lập Thu";
        public static readonly string XU_THU = "Xử Thử";
        public static readonly string BACH_LO = "Bạch Lộ";
        public static readonly string THU_PHAN = "Thu Phân";
        public static readonly string HAN_LO = "Hàn Lộ";
        public static readonly string SUONG_GIANG = "Sương Giáng";
        public static readonly string LAP_DONG = "Lập Đông";
        public static readonly string TIEU_TUYET = "Tiểu Tuyết";
        public static readonly string DAI_TUYET = "Đại Tuyết";
        public static readonly string DONG_CHI = "Đông Chí";
        public static readonly string TIEU_HAN = "Tiểu Hàn";
        public static readonly string DAI_HAN = "Đại Hàn";
        public static readonly string LAP_XUAN = "Lập Xuân";


        private static List<string> ALL_TEN_TIET_KHI = new List<string>() { VU_THUY, KINH_CHAP, XUAN_PHAN, THANH_MINH, COC_VU, LAP_HA, TIEU_MAN, MANG_CHUNG, HA_CHI, TIEU_THU, DAI_THU, LAP_THU, XU_THU, BACH_LO, THU_PHAN, HAN_LO, SUONG_GIANG, LAP_DONG, TIEU_TUYET, DAI_TUYET, DONG_CHI, TIEU_HAN, DAI_HAN, LAP_XUAN };

        private static readonly TableFixed<string, string, string> TABLE_QUY_NHAN
                            = new TableFixed<string, string, string>(ALL_TEN_TIET_KHI, All10ThienCan.ALL_TEN_THIEN_CAN);
                               
    }
}
