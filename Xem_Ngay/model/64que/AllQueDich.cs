using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.bat_quai;
using Xem_Ngay.ultility;

namespace Xem_Ngay.model._64que
{
    public class AllQueDich
    {
        // noi quai CÀN
        public static readonly Que THUAN_CAN = new Que("Càn vi Thiên", BatQuaiInstance.CAN, BatQuaiInstance.CAN).setQuaiVan(1).setPhuMau(true,true);
        public static readonly Que TRACH_THIEN_QUAI = new Que("Trạch Thiên Quải", BatQuaiInstance.DOAI, BatQuaiInstance.CAN).setQuaiVan(6);
        public static readonly Que HOA_THIEN_DAI_HUU = new Que("Hoả Thiên Đại Hữu", BatQuaiInstance.LY, BatQuaiInstance.CAN).setQuaiVan(7);
        public static readonly Que LOI_THIEN_DAI_TRANG = new Que("Lôi Thiên Đại Tráng", BatQuaiInstance.CHAN, BatQuaiInstance.CAN).setQuaiVan(2);
        public static readonly Que PHONG_THIEN_TIEU_SUC = new Que("Phong Thiên Tiểu Súc", BatQuaiInstance.TON, BatQuaiInstance.CAN).setQuaiVan(8);
        public static readonly Que THUY_THIEN_NHU = new Que("Thuỷ Thiên Nhu", BatQuaiInstance.KHAM, BatQuaiInstance.CAN).setQuaiVan(3);
        public static readonly Que SON_THIEN_DAI_SUC = new Que("Sơn Thiên Đại Súc", BatQuaiInstance.CANAS, BatQuaiInstance.CAN).setQuaiVan(4);
        public static readonly Que DIA_THIEN_THAI = new Que("Địa Thiên Thái", BatQuaiInstance.KHON, BatQuaiInstance.CAN).setQuaiVan(9).setPhuMau(true, false);

        // noi quai ĐOÀI
        public static readonly Que THIEN_TRACH_LY = new Que("Thiên Trạch Lý", BatQuaiInstance.CAN, BatQuaiInstance.DOAI).setQuaiVan(6);
        public static readonly Que THUAN_DOAI = new Que("Đoài vi Trạch", BatQuaiInstance.DOAI, BatQuaiInstance.DOAI).setQuaiVan(1).setPhuMau(true, false);
        public static readonly Que HOA_TRACH_KHUE = new Que("Hoả Trạch Khuê", BatQuaiInstance.LY, BatQuaiInstance.DOAI).setQuaiVan(2);
        public static readonly Que LOI_TRACH_QUY_MUOI = new Que("Lôi Trạch Quy Muội", BatQuaiInstance.CHAN, BatQuaiInstance.DOAI).setQuaiVan(7);
        public static readonly Que PHONG_TRACH_TRUNG_PHU = new Que("Phong Trạch Trung Phu", BatQuaiInstance.TON, BatQuaiInstance.DOAI).setQuaiVan(3);
        public static readonly Que THUY_TRACH_TIET = new Que("Thuỷ Trạch Tiết", BatQuaiInstance.KHAM, BatQuaiInstance.DOAI).setQuaiVan(8);
        public static readonly Que SON_TRACH_TON = new Que("Sơn Trạch Tổn", BatQuaiInstance.CANAS, BatQuaiInstance.DOAI).setQuaiVan(9).setPhuMau(true, true);
        public static readonly Que DIA_TRACH_LAM = new Que("Địa Trạch Lâm", BatQuaiInstance.KHON, BatQuaiInstance.DOAI).setQuaiVan(4);

        // noi quai LY
        public static readonly Que THIEN_HOA_DONG_NHAN = new Que("Thiên Hoả Đồng Nhân", BatQuaiInstance.CAN, BatQuaiInstance.LY).setQuaiVan(7);
        public static readonly Que TRACH_HOA_CACH = new Que("Trạch Hoả Cách", BatQuaiInstance.DOAI, BatQuaiInstance.LY).setQuaiVan(2);
        public static readonly Que THUAN_LY = new Que("Ly vi Hoả", BatQuaiInstance.LY, BatQuaiInstance.LY).setQuaiVan(1).setPhuMau(true, false);
        public static readonly Que LOI_HOA_PHONG = new Que("Lôi Hoả Phong", BatQuaiInstance.CHAN, BatQuaiInstance.LY).setQuaiVan(6);
        public static readonly Que PHONG_HOA_GIA_NHAN = new Que("Phong Hoả Giai Nhân", BatQuaiInstance.TON, BatQuaiInstance.LY).setQuaiVan(4);
        public static readonly Que THUY_HOA_KY_TE = new Que("Thuỷ Hoả Ký Tế", BatQuaiInstance.KHAM, BatQuaiInstance.LY).setQuaiVan(9).setPhuMau(true, true);
        public static readonly Que SON_HOA_BI = new Que("Sơn Hoả Bí", BatQuaiInstance.CANAS, BatQuaiInstance.LY).setQuaiVan(8);
        public static readonly Que DIA_HOA_MINH_DI = new Que("Địa Hoả Minh Di", BatQuaiInstance.KHON, BatQuaiInstance.LY).setQuaiVan(3);

        // noi quai CHẤN
        public static readonly Que THIEN_LOI_VO_VONG = new Que("Thiên Lôi Vô Vọng", BatQuaiInstance.CAN, BatQuaiInstance.CHAN).setQuaiVan(2);
        public static readonly Que TRACH_LOI_TUY = new Que("Trạch Lôi Tuỳ", BatQuaiInstance.DOAI, BatQuaiInstance.CHAN).setQuaiVan(7);
        public static readonly Que HOA_lOI_PHE_HAP = new Que("Hoả Lôi Phệ Hạp", BatQuaiInstance.LY, BatQuaiInstance.CHAN).setQuaiVan(6);
        public static readonly Que THUAN_CHAN = new Que("Chấn vi Lôi", BatQuaiInstance.CHAN, BatQuaiInstance.CHAN).setQuaiVan(1).setPhuMau(true, true);
        public static readonly Que PHONG_LOI_ICH = new Que("Phong Lôi Ích", BatQuaiInstance.TON, BatQuaiInstance.CHAN).setQuaiVan(9).setPhuMau(true, false);
        public static readonly Que THUY_LOI_TRUAN = new Que("Thuỷ Lôi Truân", BatQuaiInstance.KHAM, BatQuaiInstance.CHAN).setQuaiVan(4);
        public static readonly Que SON_LOI_DI = new Que("Sơn Lôi Di", BatQuaiInstance.CANAS, BatQuaiInstance.CHAN).setQuaiVan(3);
        public static readonly Que DIA_LOI_PHUC = new Que("Địa Lôi Phục", BatQuaiInstance.KHON, BatQuaiInstance.CHAN).setQuaiVan(8);

        // noi quai TỐN
        public static readonly Que THIEN_PHONG_CAU = new Que("Thiên Phong Cấu", BatQuaiInstance.CAN, BatQuaiInstance.TON).setQuaiVan(8);
        public static readonly Que TRACH_PHONG_DAI_QUA = new Que("Trạch Phong Đại Quá", BatQuaiInstance.DOAI, BatQuaiInstance.TON).setQuaiVan(3);
        public static readonly Que HOA_PHONG_DINH = new Que("Hoả Phong Đỉnh", BatQuaiInstance.LY, BatQuaiInstance.TON).setQuaiVan(4);
        public static readonly Que LOI_PHONG_HANG = new Que("Lôi Phong Hằng", BatQuaiInstance.CHAN, BatQuaiInstance.TON).setQuaiVan(9).setPhuMau(true, true);
        public static readonly Que THUAN_TON = new Que("Tốn vi Phong", BatQuaiInstance.TON, BatQuaiInstance.TON).setQuaiVan(1).setPhuMau(true, false);
        public static readonly Que THUY_PHONG_TINH = new Que("Thuỷ Phong Tỉnh", BatQuaiInstance.KHAM, BatQuaiInstance.TON).setQuaiVan(6);
        public static readonly Que SON_PHONG_CO = new Que("Sơn Phong Cổ", BatQuaiInstance.CANAS, BatQuaiInstance.TON).setQuaiVan(7);
        public static readonly Que DIA_PHONG_THANG = new Que("Địa Phong Thăng", BatQuaiInstance.KHON, BatQuaiInstance.TON).setQuaiVan(2);

        // noi quai KHẢM
        public static readonly Que THIEN_THUY_TUNG = new Que("Thiên Thuỷ Tụng", BatQuaiInstance.CAN, BatQuaiInstance.KHAM).setQuaiVan(3);
        public static readonly Que TRACH_THUY_KHON = new Que("Trạch Thuỷ Khốn", BatQuaiInstance.DOAI, BatQuaiInstance.KHAM).setQuaiVan(8);
        public static readonly Que HOA_THUY_VI_TE = new Que("Hoả Thuỷ Vị Tế", BatQuaiInstance.LY, BatQuaiInstance.KHAM).setQuaiVan(9).setPhuMau(true, false);
        public static readonly Que LOI_THUY_GIAI = new Que("Lôi Thuỷ Giải", BatQuaiInstance.CHAN, BatQuaiInstance.KHAM).setQuaiVan(4);
        public static readonly Que PHONG_THUY_HOAN = new Que("Phong Thuỷ Hoán", BatQuaiInstance.TON, BatQuaiInstance.KHAM).setQuaiVan(6);
        public static readonly Que THUAN_KHAM = new Que("Khảm vi Thuỷ", BatQuaiInstance.KHAM, BatQuaiInstance.KHAM).setQuaiVan(1).setPhuMau(true, true);
        public static readonly Que SON_THUY_MONG = new Que("Sơn Thuỷ Mông", BatQuaiInstance.CANAS, BatQuaiInstance.KHAM).setQuaiVan(2);
        public static readonly Que DIA_THUY_SU = new Que("Địa Thuỷ Sư", BatQuaiInstance.KHON, BatQuaiInstance.KHAM).setQuaiVan(7);

        // noi quai CẤN
        public static readonly Que THIEN_SON_DON = new Que("Thiên Sơn Độn", BatQuaiInstance.CAN, BatQuaiInstance.CANAS).setQuaiVan(4);
        public static readonly Que TRACH_SON_HAM = new Que("Trạch Sơn Hàm", BatQuaiInstance.DOAI, BatQuaiInstance.CANAS).setQuaiVan(9).setPhuMau(true, false);
        public static readonly Que HOA_SON_LU = new Que("Hoả Sơn Lữ", BatQuaiInstance.LY, BatQuaiInstance.CANAS).setQuaiVan(8);
        public static readonly Que LOI_SON_TIEU_QUA = new Que("Lôi Sơn Tiểu quá", BatQuaiInstance.CHAN, BatQuaiInstance.CANAS).setQuaiVan(3);
        public static readonly Que PHONG_SON_TIEM = new Que("Phong Sơn Tiệm", BatQuaiInstance.TON, BatQuaiInstance.CANAS).setQuaiVan(7);
        public static readonly Que THUY_SON_KIEN = new Que("Thuỷ Sơn Kiển", BatQuaiInstance.KHAM, BatQuaiInstance.CANAS).setQuaiVan(2);
        public static readonly Que THUAN_CANAS = new Que("Cấn vi Sơn", BatQuaiInstance.CANAS, BatQuaiInstance.CANAS).setQuaiVan(1).setPhuMau(true, true);
        public static readonly Que DIA_SON_KHIEM = new Que("Địa Sơn Khiêm", BatQuaiInstance.KHON, BatQuaiInstance.CANAS).setQuaiVan(6);

        // noi quai KHÔN
        public static readonly Que THIEN_DIA_BI = new Que("Thiên Địa Bĩ", BatQuaiInstance.CAN, BatQuaiInstance.KHON).setQuaiVan(9).setPhuMau(true, true);
        public static readonly Que TRACH_DIA_TUY = new Que("Trạch Địa Tuỵ", BatQuaiInstance.DOAI, BatQuaiInstance.KHON).setQuaiVan(4);
        public static readonly Que HOA_DIA_TAN = new Que("Hoả Địa Tấn", BatQuaiInstance.LY, BatQuaiInstance.KHON).setQuaiVan(3);
        public static readonly Que LOI_DIA_DU = new Que("Lôi Địa Dự", BatQuaiInstance.CHAN, BatQuaiInstance.KHON).setQuaiVan(8);
        public static readonly Que PHONG_DIA_QUAN = new Que("Phong Địa Quán", BatQuaiInstance.TON, BatQuaiInstance.KHON).setQuaiVan(2);
        public static readonly Que THUY_DIA_TY = new Que("Thuỷ Địa Tỷ", BatQuaiInstance.KHAM, BatQuaiInstance.KHON).setQuaiVan(7);
        public static readonly Que SON_DIA_BAC = new Que("Sơn Địa Bác", BatQuaiInstance.CANAS, BatQuaiInstance.KHON).setQuaiVan(6);
        public static readonly Que THUAN_KHON = new Que("Khôn vi Địa", BatQuaiInstance.KHON, BatQuaiInstance.KHON).setQuaiVan(1).setPhuMau(true, false);

        public static readonly List<Que> ALL_64QUE = new List<Que>() { THUAN_CAN, TRACH_THIEN_QUAI, HOA_THIEN_DAI_HUU, LOI_THIEN_DAI_TRANG, PHONG_THIEN_TIEU_SUC, THUY_THIEN_NHU, SON_THIEN_DAI_SUC, DIA_THIEN_THAI, THIEN_TRACH_LY, THUAN_DOAI, HOA_TRACH_KHUE, LOI_TRACH_QUY_MUOI, PHONG_TRACH_TRUNG_PHU, THUY_TRACH_TIET, SON_TRACH_TON, DIA_TRACH_LAM, THIEN_HOA_DONG_NHAN, TRACH_HOA_CACH, THUAN_LY, LOI_HOA_PHONG, PHONG_HOA_GIA_NHAN, THUY_HOA_KY_TE, SON_HOA_BI, DIA_HOA_MINH_DI, THIEN_LOI_VO_VONG, TRACH_LOI_TUY, HOA_lOI_PHE_HAP, THUAN_CHAN, PHONG_LOI_ICH, THUY_LOI_TRUAN, SON_LOI_DI, DIA_LOI_PHUC, THIEN_PHONG_CAU, TRACH_PHONG_DAI_QUA, HOA_PHONG_DINH, LOI_PHONG_HANG, THUAN_TON, THUY_PHONG_TINH, SON_PHONG_CO, DIA_PHONG_THANG, THIEN_THUY_TUNG, TRACH_THUY_KHON, HOA_THUY_VI_TE, LOI_THUY_GIAI, PHONG_THUY_HOAN, THUAN_KHAM, SON_THUY_MONG, DIA_THUY_SU, THIEN_SON_DON, TRACH_SON_HAM, HOA_SON_LU, LOI_SON_TIEU_QUA, PHONG_SON_TIEM, THUY_SON_KIEN, THUAN_CANAS, DIA_SON_KHIEM, THIEN_DIA_BI, TRACH_DIA_TUY, HOA_DIA_TAN, LOI_DIA_DU, PHONG_DIA_QUAN, THUY_DIA_TY, SON_DIA_BAC, THUAN_KHON };

        public static Map<String, Que> MAPPING_TEN_QUE_VS_QUE = new Map<string, Que>();

        static AllQueDich()
        {
            // load mapping
            foreach(Que que in ALL_64QUE)
            {
                MAPPING_TEN_QUE_VS_QUE.add(que.ten, que);
            }
        }

        public static List<Que> timQueBangTen(String ten) {
            List<Que> lstResult = new List<Que>();
            ten = ten.ToLower();
            for (int i = 0; i < 64; i++) {
                String tenQue = ALL_64QUE[i].ten.ToLower();
                if (tenQue.IndexOf(ten) > -1) {
                    lstResult.Add(ALL_64QUE[i]);
                }
            }
            return lstResult;
        }
    }
}
