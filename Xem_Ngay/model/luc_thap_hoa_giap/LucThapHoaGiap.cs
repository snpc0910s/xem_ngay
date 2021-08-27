using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.thien_can;
using Xem_Ngay.model.dia_chi;
using Xem_Ngay.model._64que;

namespace Xem_Ngay.model.luc_thap_hoa_giap
{
    public class LucThapHoaGiap
    {
        // TỊ
        public static readonly HoaGiap QUY_TI = new HoaGiap(ThienCanInstance.QUY, DiaChiInstance.TI).themQue(AllQueDich.TRACH_THIEN_QUAI);
        public static readonly HoaGiap TAN_TI = new HoaGiap(ThienCanInstance.TAN, DiaChiInstance.TI).themQue(AllQueDich.HOA_THIEN_DAI_HUU);
        public static readonly HoaGiap KY_TI = new HoaGiap(ThienCanInstance.KY, DiaChiInstance.TI).themQue(AllQueDich.LOI_THIEN_DAI_TRANG);
        public static readonly HoaGiap DINH_TI = new HoaGiap(ThienCanInstance.DINH, DiaChiInstance.TI).themQue(AllQueDich.PHONG_THIEN_TIEU_SUC);
        public static readonly HoaGiap AT_TI = new HoaGiap(ThienCanInstance.AT, DiaChiInstance.TI).themQue(AllQueDich.THUY_THIEN_NHU);
        // THÌN
        public static readonly HoaGiap NHAM_THIN = new HoaGiap(ThienCanInstance.NHAM, DiaChiInstance.THIN).themQue(AllQueDich.SON_THIEN_DAI_SUC);
        public static readonly HoaGiap CANH_THIN = new HoaGiap(ThienCanInstance.CANH, DiaChiInstance.THIN).themQue(AllQueDich.DIA_THIEN_THAI);
        public static readonly HoaGiap MAU_THIN = new HoaGiap(ThienCanInstance.MAU, DiaChiInstance.THIN).themQue(AllQueDich.THIEN_TRACH_LY);
        public static readonly HoaGiap BINH_THIN = new HoaGiap(ThienCanInstance.BINH, DiaChiInstance.THIN).themQue(AllQueDich.THUAN_DOAI);
        public static readonly HoaGiap GIAP_THIN = new HoaGiap(ThienCanInstance.GIAP, DiaChiInstance.THIN).themQue(AllQueDich.HOA_TRACH_KHUE);
        // MÃO
        public static readonly HoaGiap QUY_MAO = new HoaGiap(ThienCanInstance.QUY, DiaChiInstance.MAO).themQue(AllQueDich.LOI_TRACH_QUY_MUOI);
        public static readonly HoaGiap TAN_MAO = new HoaGiap(ThienCanInstance.TAN, DiaChiInstance.MAO).themQue(AllQueDich.PHONG_TRACH_TRUNG_PHU);
        public static readonly HoaGiap KY_MAO = new HoaGiap(ThienCanInstance.KY, DiaChiInstance.MAO).themQue(AllQueDich.THUY_TRACH_TIET);
        public static readonly HoaGiap DINH_MAO = new HoaGiap(ThienCanInstance.DINH, DiaChiInstance.MAO).themQue(AllQueDich.SON_TRACH_TON);
        public static readonly HoaGiap AT_MAO = new HoaGiap(ThienCanInstance.AT, DiaChiInstance.MAO).themQue(AllQueDich.DIA_TRACH_LAM);
        // DẦN
        public static readonly HoaGiap NHAM_DAN = new HoaGiap(ThienCanInstance.NHAM, DiaChiInstance.DAN).themQue(AllQueDich.THIEN_HOA_DONG_NHAN);
        public static readonly HoaGiap CANH_DAN = new HoaGiap(ThienCanInstance.CANH, DiaChiInstance.DAN).themQue(AllQueDich.TRACH_HOA_CACH).themQue(AllQueDich.THUAN_LY);
        public static readonly HoaGiap MAU_DAN = new HoaGiap(ThienCanInstance.MAU, DiaChiInstance.DAN).themQue(AllQueDich.LOI_HOA_PHONG);
        public static readonly HoaGiap BINH_DAN = new HoaGiap(ThienCanInstance.BINH, DiaChiInstance.DAN).themQue(AllQueDich.PHONG_HOA_GIA_NHAN);
        public static readonly HoaGiap GIAP_DAN = new HoaGiap(ThienCanInstance.GIAP, DiaChiInstance.DAN).themQue(AllQueDich.THUY_HOA_KY_TE);
        // SỬU
        public static readonly HoaGiap QUY_SUU = new HoaGiap(ThienCanInstance.QUY, DiaChiInstance.SUU).themQue(AllQueDich.SON_HOA_BI);
        public static readonly HoaGiap TAN_SUU = new HoaGiap(ThienCanInstance.TAN, DiaChiInstance.SUU).themQue(AllQueDich.DIA_HOA_MINH_DI);
        public static readonly HoaGiap KY_SUU = new HoaGiap(ThienCanInstance.KY, DiaChiInstance.SUU).themQue(AllQueDich.THIEN_LOI_VO_VONG);
        public static readonly HoaGiap DINH_SUU = new HoaGiap(ThienCanInstance.DINH, DiaChiInstance.SUU).themQue(AllQueDich.TRACH_LOI_TUY);
        public static readonly HoaGiap AT_SUU = new HoaGiap(ThienCanInstance.AT, DiaChiInstance.SUU).themQue(AllQueDich.HOA_lOI_PHE_HAP);
        // TÝ
        public static readonly HoaGiap NHAM_TY = new HoaGiap(ThienCanInstance.NHAM, DiaChiInstance.TY).themQue(AllQueDich.THUAN_CHAN);
        public static readonly HoaGiap CANH_TY = new HoaGiap(ThienCanInstance.CANH, DiaChiInstance.TY).themQue(AllQueDich.PHONG_LOI_ICH);
        public static readonly HoaGiap MAU_TY = new HoaGiap(ThienCanInstance.MAU, DiaChiInstance.TY).themQue(AllQueDich.THUY_LOI_TRUAN);
        public static readonly HoaGiap BINH_TY = new HoaGiap(ThienCanInstance.BINH, DiaChiInstance.TY).themQue(AllQueDich.SON_LOI_DI);
        public static readonly HoaGiap GIAP_TY = new HoaGiap(ThienCanInstance.GIAP, DiaChiInstance.TY).themQue(AllQueDich.DIA_LOI_PHUC).themQue(AllQueDich.THUAN_KHON);
        //NGỌ
        public static readonly HoaGiap GIAP_NGO = new HoaGiap(ThienCanInstance.GIAP, DiaChiInstance.NGO).themQue(AllQueDich.THIEN_PHONG_CAU).themQue(AllQueDich.THUAN_CAN);
        public static readonly HoaGiap BINH_NGO = new HoaGiap(ThienCanInstance.BINH, DiaChiInstance.NGO).themQue(AllQueDich.TRACH_PHONG_DAI_QUA);
        public static readonly HoaGiap MAU_NGO = new HoaGiap(ThienCanInstance.MAU, DiaChiInstance.NGO).themQue(AllQueDich.HOA_PHONG_DINH);
        public static readonly HoaGiap CANH_NGO = new HoaGiap(ThienCanInstance.CANH, DiaChiInstance.NGO).themQue(AllQueDich.LOI_PHONG_HANG);
        public static readonly HoaGiap NHAM_NGO = new HoaGiap(ThienCanInstance.NHAM, DiaChiInstance.NGO).themQue(AllQueDich.THUAN_TON);
        // MÙI
        public static readonly HoaGiap AT_MUI = new HoaGiap(ThienCanInstance.AT, DiaChiInstance.MUI).themQue(AllQueDich.THUY_PHONG_TINH);
        public static readonly HoaGiap DINH_MUI = new HoaGiap(ThienCanInstance.DINH, DiaChiInstance.MUI).themQue(AllQueDich.SON_PHONG_CO);
        public static readonly HoaGiap KY_MUI = new HoaGiap(ThienCanInstance.KY, DiaChiInstance.MUI).themQue(AllQueDich.DIA_PHONG_THANG);
        public static readonly HoaGiap TAN_MUI = new HoaGiap(ThienCanInstance.TAN, DiaChiInstance.MUI).themQue(AllQueDich.THIEN_THUY_TUNG);
        public static readonly HoaGiap QUY_MUI = new HoaGiap(ThienCanInstance.QUY, DiaChiInstance.MUI).themQue(AllQueDich.TRACH_THUY_KHON);
        // THÂN
        public static readonly HoaGiap GIAP_THAN = new HoaGiap(ThienCanInstance.GIAP, DiaChiInstance.THAN).themQue(AllQueDich.HOA_THUY_VI_TE);
        public static readonly HoaGiap BINH_THAN = new HoaGiap(ThienCanInstance.BINH, DiaChiInstance.THAN).themQue(AllQueDich.LOI_THUY_GIAI);
        public static readonly HoaGiap MAU_THAN = new HoaGiap(ThienCanInstance.MAU, DiaChiInstance.THAN).themQue(AllQueDich.PHONG_THUY_HOAN);
        public static readonly HoaGiap CANH_THAN = new HoaGiap(ThienCanInstance.CANH, DiaChiInstance.THAN).themQue(AllQueDich.SON_THUY_MONG).themQue(AllQueDich.THUAN_KHAM);
        public static readonly HoaGiap NHAM_THAN = new HoaGiap(ThienCanInstance.NHAM, DiaChiInstance.THAN).themQue(AllQueDich.DIA_THUY_SU);
        // DẬU
        public static readonly HoaGiap AT_DAU = new HoaGiap(ThienCanInstance.AT, DiaChiInstance.DAU).themQue(AllQueDich.THIEN_SON_DON);
        public static readonly HoaGiap DINH_DAU = new HoaGiap(ThienCanInstance.DINH, DiaChiInstance.DAU).themQue(AllQueDich.TRACH_SON_HAM);
        public static readonly HoaGiap KY_DAU = new HoaGiap(ThienCanInstance.KY, DiaChiInstance.DAU).themQue(AllQueDich.HOA_SON_LU);
        public static readonly HoaGiap TAN_DAU = new HoaGiap(ThienCanInstance.TAN, DiaChiInstance.DAU).themQue(AllQueDich.LOI_SON_TIEU_QUA);
        public static readonly HoaGiap QUY_DAU = new HoaGiap(ThienCanInstance.QUY, DiaChiInstance.DAU).themQue(AllQueDich.PHONG_SON_TIEM);
        // TUẤT
        public static readonly HoaGiap GIAP_TUAT = new HoaGiap(ThienCanInstance.GIAP, DiaChiInstance.TUAT).themQue(AllQueDich.THUY_SON_KIEN);
        public static readonly HoaGiap BINH_TUAT = new HoaGiap(ThienCanInstance.BINH, DiaChiInstance.TUAT).themQue(AllQueDich.THUAN_CANAS);
        public static readonly HoaGiap MAU_TUAT = new HoaGiap(ThienCanInstance.MAU, DiaChiInstance.TUAT).themQue(AllQueDich.DIA_SON_KHIEM);
        public static readonly HoaGiap CANH_TUAT = new HoaGiap(ThienCanInstance.CANH, DiaChiInstance.TUAT).themQue(AllQueDich.THIEN_DIA_BI);
        public static readonly HoaGiap NHAM_TUAT = new HoaGiap(ThienCanInstance.NHAM, DiaChiInstance.TUAT).themQue(AllQueDich.TRACH_DIA_TUY);
        // HỢI
        public static readonly HoaGiap AT_HOI = new HoaGiap(ThienCanInstance.AT, DiaChiInstance.HOI).themQue(AllQueDich.HOA_DIA_TAN);
        public static readonly HoaGiap DINH_HOI = new HoaGiap(ThienCanInstance.DINH, DiaChiInstance.HOI).themQue(AllQueDich.LOI_DIA_DU);
        public static readonly HoaGiap KY_HOI = new HoaGiap(ThienCanInstance.KY, DiaChiInstance.HOI).themQue(AllQueDich.PHONG_DIA_QUAN);
        public static readonly HoaGiap TAN_HOI = new HoaGiap(ThienCanInstance.TAN, DiaChiInstance.HOI).themQue(AllQueDich.THUY_DIA_TY);
        public static readonly HoaGiap QUY_HOI = new HoaGiap(ThienCanInstance.QUY, DiaChiInstance.HOI).themQue(AllQueDich.SON_DIA_BAC);

        public static readonly List<HoaGiap> ALL60HOAGIAP = new List<HoaGiap>() { QUY_TI, TAN_TI, KY_TI, DINH_TI, AT_TI, NHAM_THIN, CANH_THIN, MAU_THIN, BINH_THIN, GIAP_THIN, QUY_MAO, TAN_MAO, KY_MAO, DINH_MAO, AT_MAO, NHAM_DAN, CANH_DAN, MAU_DAN, BINH_DAN, GIAP_DAN, QUY_SUU, TAN_SUU, KY_SUU, DINH_SUU, AT_SUU, NHAM_TY, CANH_TY, MAU_TY, BINH_TY, GIAP_TY, GIAP_NGO, BINH_NGO, MAU_NGO, CANH_NGO, NHAM_NGO, AT_MUI, DINH_MUI, KY_MUI, TAN_MUI, QUY_MUI, GIAP_THAN, BINH_THAN, MAU_THAN, CANH_THAN, NHAM_THAN, AT_DAU, DINH_DAU, KY_DAU, TAN_DAU, QUY_DAU, GIAP_TUAT, BINH_TUAT, MAU_TUAT, CANH_TUAT, NHAM_TUAT, AT_HOI, DINH_HOI, KY_HOI, TAN_HOI, QUY_HOI };

        public static List<HoaGiap> timHoaGiapByTen(String ten)
        {
            ten = ten.ToLower();
            List<HoaGiap> result = new List<HoaGiap>();
            foreach(HoaGiap hoaGiap in ALL60HOAGIAP)
            {
                if (hoaGiap.ten.ToLower().IndexOf(ten) > -1) result.Add(hoaGiap);
            }
            return result;
        }
    }
}
