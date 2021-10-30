using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.thien_can;
using Xem_Ngay.model.dia_chi;
using Xem_Ngay.model._64que;
using Xem_Ngay.ultility;
using Xem_Ngay.ultility.excel_data_source;

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

        // các vòng phải theo thứ tự để duyệt không được đảo trật tự DUYỆT TỪ GIAP TY -> GIAP TUAT ->  GIAP THAN -> GIAP NGO -> GIAP THIN -> GIAP DAN

        public static readonly List<HoaGiap> VONG_GIAP_TY = new List<HoaGiap>() { GIAP_TY, AT_SUU, BINH_DAN, DINH_MAO, MAU_THIN, KY_TI, CANH_NGO, TAN_MUI, NHAM_THAN, QUY_DAU };

        public static readonly List<HoaGiap> VONG_GIAP_TUAT = new List<HoaGiap>() { GIAP_TUAT, AT_HOI, BINH_TY, DINH_SUU, MAU_DAN, KY_MAO, CANH_THIN, TAN_TI, NHAM_NGO, QUY_MUI };

        public static readonly List<HoaGiap> VONG_GIAP_THAN = new List<HoaGiap>() { GIAP_THAN, AT_DAU, BINH_TUAT, DINH_HOI, MAU_TY, KY_SUU, CANH_DAN, TAN_MAO, NHAM_THIN, QUY_TI };

        public static readonly List<HoaGiap> VONG_GIAP_NGO = new List<HoaGiap>() { GIAP_NGO, AT_MUI, BINH_THAN, DINH_DAU, MAU_TUAT, KY_HOI, CANH_TY, TAN_SUU, NHAM_DAN, QUY_MAO };

        public static readonly List<HoaGiap> VONG_GIAP_THIN = new List<HoaGiap>() { GIAP_THIN, AT_TI, BINH_NGO, DINH_MUI, MAU_THAN, KY_DAU, CANH_TUAT, TAN_HOI, NHAM_TY, QUY_SUU };

        public static readonly List<HoaGiap> VONG_GIAP_DAN = new List<HoaGiap>() { GIAP_DAN, AT_MAO, BINH_THIN, DINH_TI, MAU_NGO, KY_MUI, CANH_THAN, TAN_DAU, NHAM_TUAT, QUY_HOI };
        
        // mapping số thứ tự với thiên can dùng để tính toán từ ngày -> 12 giờ tương ứng, từ năm -> 12 tháng tương ứng
        public static readonly Map<int, String> MAP_STT_STRING_THIEN_CAN = new Map<int, String>()
                                                                        .withValue(1, "Giáp").withValue(2, "Ất")
                                                                        .withValue(3, "Bính").withValue(4, "Đinh")
                                                                        .withValue(5, "Mậu").withValue(6, "Kỷ")
                                                                        .withValue(7, "Canh").withValue(8, "Tân")
                                                                        .withValue(9, "Nhâm").withValue(10, "Quý");
        // mapping số thứ tự với địa chi dùng để tính toán từ ngày -> 12 giờ tương ứng, từ năm -> 12 tháng tương ứng
        public static readonly Map<int, String> MAP_STT_STRING_DIACHI = new Map<int, String>()
                                                                                .withValue(1, "Tý").withValue(2, "Sửu")
                                                                                .withValue(3, "Dần").withValue(4, "Mão")
                                                                                .withValue(5, "Thìn").withValue(6, "Tị")
                                                                                .withValue(7, "Ngọ").withValue(8, "Mùi")
                                                                                .withValue(9, "Thân").withValue(10, "Dậu")
                                                                                .withValue(11, "Tuất").withValue(12, "Hợi");

        // mapping tháng dạng số sang tháng dạng địa chi VD: tháng 1 -> Tháng Dần
        public static readonly BiMap1Type<String> BIMAP_THANG_DIA_CHI = new BiMap1Type<string>()
                                                                            .with("1","Dần").with("2", "Mão")
                                                                            .with("3", "Thìn").with("4", "Tị")
                                                                            .with("5", "Ngọ").with("6", "Mùi")
                                                                            .with("7", "Thân").with("8", "Dậu")
                                                                            .with("9", "Tuất").with("10", "Hợi")
                                                                            .with("11", "Tý").with("12","Sửu");

        // tất cả các hoa giáp
        public static readonly List<HoaGiap> ALL60HOAGIAP = new List<HoaGiap>() { GIAP_TY, AT_SUU, BINH_DAN, DINH_MAO, MAU_THIN, KY_TI, CANH_NGO, TAN_MUI, NHAM_THAN, QUY_DAU, GIAP_TUAT, AT_HOI, BINH_TY, DINH_SUU, MAU_DAN, KY_MAO, CANH_THIN, TAN_TI, NHAM_NGO, QUY_MUI, GIAP_THAN, AT_DAU, BINH_TUAT, DINH_HOI, MAU_TY, KY_SUU, CANH_DAN, TAN_MAO, NHAM_THIN, QUY_TI, GIAP_NGO, AT_MUI, BINH_THAN, DINH_DAU, MAU_TUAT, KY_HOI, CANH_TY, TAN_SUU, NHAM_DAN, QUY_MAO, GIAP_THIN, AT_TI, BINH_NGO, DINH_MUI, MAU_THAN, KY_DAU, CANH_TUAT, TAN_HOI, NHAM_TY, QUY_SUU, GIAP_DAN, AT_MAO, BINH_THIN, DINH_TI, MAU_NGO, KY_MUI, CANH_THAN, TAN_DAU, NHAM_TUAT, QUY_HOI };

        // mapping tên hoa giáp với vị trí của nó trong ALL60HOAGIAP VD:  <"Giáp Tý",0>
        public static Map<string, int> MAP_HOA_GIAP_VI_TRI = new Map<string, int>();

        // lưu trữ thông tin của những ngày trong 1 tháng của 1 năm được đọc từ file excel và sẽ load từ từ tránh load 1 lúc
        public static Map<string, List<ThongTinThang>> CACHE_THONG_TIN_THANG_NAM = new Map<string, List<ThongTinThang>>(); 
        
        // load data when init value
        static LucThapHoaGiap()
        {
            for (int i = 0 ; i < 60; i++)
            {
                MAP_HOA_GIAP_VI_TRI.add(ALL60HOAGIAP[i].ten, i);
            }
            Console.WriteLine("");
        }

        // lấy ngày từ tháng dọc từ excel data -> 1 năm nhập 1 lần
        public static List<HoaGiap> layNgayTrongThangTrongNam(String tenNam, String tenThang)
        {
            List<HoaGiap> result = new List<HoaGiap>();
            String tenNamTemp = tenNam.Trim().ToUpper();
            String tenThangTemp = tenThang.Trim().ToUpper();
            List<ThongTinThang> thongtinThangTrongNam;
            // lazy loading .....
            if (CACHE_THONG_TIN_THANG_NAM.ContainsKey(tenNamTemp) == false)
            {
                // không tồn tại trong dữ liệu
                thongtinThangTrongNam = DocGioiHanThangTrongNamExcel.layThongTinThangTuResourceBangTenNam(tenNamTemp);
                // save to cache =))
                CACHE_THONG_TIN_THANG_NAM.add(tenNamTemp, thongtinThangTrongNam);
            }
            else
            {
                // tồn tại trong resource
                thongtinThangTrongNam = CACHE_THONG_TIN_THANG_NAM.get(tenNamTemp);
            }
            // lấy tát cả các ngày hoa giáp thoả mãn
            foreach (ThongTinThang info in thongtinThangTrongNam)
            {
                // info.thang.Trim() thang la so vd 1: 
                String thangCanTim = BIMAP_THANG_DIA_CHI.get(info.thang).Trim().ToUpper(); // DẦN
                if (tenThangTemp.ToUpper().IndexOf(thangCanTim) > -1)
                {
                    // find and push to list hoa giap
                    result = layCacHoaGiapTheo1Khoang(info.ngayBatDau, info.ngayKetThuc);
                    break;
                }
            }
            return result;
        }
        // Tìm những tháng thoả mãn ngày và năm KIỂM TRA NGƯỢC. Tức từ tên ngày -> tháng tương ứng nhưng năm phải tồn tại trong trong excel
        public static List<String> timNhungThangThoaMan1HoaGiap(String tenNgay, String tenNam)
        {
            List<String> result = new List<String>();
            tenNam = StringUtil.replaceMoreSpaceAndTrim(tenNam);
            tenNgay = StringUtil.replaceMoreSpaceAndTrim(tenNgay);
            // load cache 
            List<ThongTinThang> thongtinThangTrongNam;
            if (CACHE_THONG_TIN_THANG_NAM.ContainsKey(tenNam) == false)
            {
                // không tồn tại trong dữ liệu
                thongtinThangTrongNam = DocGioiHanThangTrongNamExcel.layThongTinThangTuResourceBangTenNam(tenNam);
                // save to cache =))
                CACHE_THONG_TIN_THANG_NAM.add(tenNam, thongtinThangTrongNam);
            }
            else
            {
                // tồn tại trong resource
                thongtinThangTrongNam = CACHE_THONG_TIN_THANG_NAM.get(tenNam);
            }
            foreach (ThongTinThang info in thongtinThangTrongNam)
            {
                if (checkViTriHoaGiapThoaMan1Khoang(tenNgay, info.ngayBatDau, info.ngayKetThuc) == true)
                {
                    // thêm vào kết quả
                    String thangSo = info.thang;
                    String thangChu = BIMAP_THANG_DIA_CHI.get(thangSo);
                    if (thangChu == null || thangChu.Equals("")) continue; // data excel bị lỗi Vd: làm gì có tháng 13
                    result.Add(thangChu);
                }
            }

            return result; // [Sửu, Dần, Thân,....]
        }

        // kiểm tra hoa giáp nằm trong 1 khoảng nào đó không vd: kiểm tra hoa giáp Quý tị có nằm trong khoảng từ Giáp Tý-Canh Thân không ?
        public static bool checkViTriHoaGiapThoaMan1Khoang(String hoaGiap, String hoaGiapBatDau, String HoaGiapKetThuc)
        {
            int iHoa = MAP_HOA_GIAP_VI_TRI.get(hoaGiap);
            int iHoaB = MAP_HOA_GIAP_VI_TRI.get(hoaGiapBatDau);
            int iHoaK = MAP_HOA_GIAP_VI_TRI.get(HoaGiapKetThuc);
            if (iHoa == -1 || iHoaB == -1 || iHoaK == -1) return false;
            if(iHoaB <= iHoaK)
            {
                if (iHoaB <= iHoa && iHoa <= iHoaK) return true;
            }else
            {
                if (iHoaB <= iHoa && iHoa < 60) return true;
                if (0 <= iHoa && iHoa < iHoaK) return true;
            }

            return false;
        }
        // tìm HoaGiap them Năm VD: 2021: Tân Sửu
        public static HoaGiap timHoaGiapTheoNam(int nam)
        {
            int viTriNam2000CanhThin = timViTriHoaGiapBangTen("Canh Thìn");
            int khoangCach = nam - 2000;
            int viCanTim = -1;
            if (khoangCach == 0 || khoangCach % 60 == 0) return timHoaGiapTuViTri(viTriNam2000CanhThin);
            if(khoangCach > 0)
            {
                viCanTim = (viTriNam2000CanhThin + khoangCach) % 60;
            }
            else
            {
                //  nho hon nam 2000 // that ra eo ranh lam viec nay
                khoangCach = khoangCach + 60;
                viCanTim = (viTriNam2000CanhThin + khoangCach) % 60;
            }

            return timHoaGiapTuViTri(viCanTim);
        }
        // tìm hoa giáp từ vị trí của nó trong 60 hoa giáp: VD 0 -> Giáp Tý
        public static HoaGiap timHoaGiapTuViTri(int position)
        {
            if (position < 0 || position > 59) return null;
            return ALL60HOAGIAP[position];
        }
        // tìm vị trí hoa giáp từ vị trí của nó trong 60 hoa giáp
        public static int timViTriHoaGiapBangTen(String ten)
        {
            if (MAP_HOA_GIAP_VI_TRI.ContainsKey(ten)) return MAP_HOA_GIAP_VI_TRI.get(ten);
            return -1; // neu khong tim thay ten tuong ung
        }

        // tìm tất cả hoa giáp có tên chứa input
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
        // tìm hoa giáp bằng tên quẻ
        public static HoaGiap timHoaGiapBangTenQue(String tenque)
        {
            tenque = tenque.ToUpper();
            foreach (HoaGiap hoaGiap in ALL60HOAGIAP)
            {
                if(hoaGiap.ques.Count  == 1)
                {
                    if (hoaGiap.ques[0].ten.ToUpper().IndexOf(tenque) > -1) return hoaGiap;
                }else
                {
                    if (hoaGiap.ques[0].ten.ToUpper().IndexOf(tenque) > -1) return hoaGiap;
                    if (hoaGiap.ques[1].ten.ToUpper().IndexOf(tenque) > -1) return hoaGiap;
                }
                
            }
            return null;
        }
        // tìm tất cả các hoa giáp thoả mãn thuộc 1 dãy tên input
        public static List<HoaGiap> timHoaGiapThuoc1ListTen(List<String> listTen)
        {
            List<HoaGiap> result = new List<HoaGiap>();
            foreach (HoaGiap hoaGiap in ALL60HOAGIAP)
            {
                String tenHoaGiapTemp = hoaGiap.ten.ToUpper();
                foreach(String tc in listTen)
                {
                    if (tenHoaGiapTemp.IndexOf(tc.Trim().ToUpper()) > -1) {
                        result.Add(hoaGiap);
                        break;
                    };
                }
               
            }
            return result;
        }
        // tìm hoa giáp có tên chính xác VD: Nhâm Dần, Bính Tuất,...
        public static HoaGiap timChinhXacDauTien(String ten)
        {
            ten = ten.ToLower();
            foreach (HoaGiap hoaGiap in ALL60HOAGIAP)
            {
                if (hoaGiap.ten.ToLower().IndexOf(ten) > -1) return hoaGiap;
            }
            return null;
        }
        // Chuyển các Hoa Giáp thành Hoa Giáp đơn giản hơn để hiển thị
        public static List<HoaGiapDonGian> listHoaGiapToHoaGiapDonGian(List<HoaGiap> lstHoaGiap)
        {
            List<HoaGiapDonGian> result = new List<HoaGiapDonGian>();
            foreach (HoaGiap hoaGiap in lstHoaGiap)
            {
                List<HoaGiapDonGian> lstSimple = hoaGiap.toHoaGiapDonGian();
                foreach (HoaGiapDonGian dongian in lstSimple) {
                    result.Add(dongian);
                }
            }
            return result;
        }
        
        // Tương tự như trên nhưng là chuyển đổi về thành các array value
        public static List<String[]> listHoaGiapToRowTable(List<HoaGiap> lstHoaGiap)
        {
            List<String[]> result = new List<String[]>();
            foreach (HoaGiap hoaGiap in lstHoaGiap)
            {
                List<HoaGiapDonGian> lstSimple = hoaGiap.toHoaGiapDonGian();
                foreach (HoaGiapDonGian dongian in lstSimple)
                {
                    result.Add(dongian.toRowDataTable());
                }
            }
            return result;
        }
        // TOP 1 tinh nang: lọc list hoa giáp bằng logic ***************
        public static List<HoaGiap> locListHoaGiapByLogic(List<HoaGiap> lstHoaGiap, String slogic)
        {
            Map<String, List<String>> logic = HoaGiap.chuyenStringToMapLogic(slogic);
            List<HoaGiap> result = new List<HoaGiap>();
            foreach(HoaGiap hoaGiap in lstHoaGiap)
            {
                if (hoaGiap.thoaManDieuKien(logic) == true) result.Add(hoaGiap);
            }
            return result;
        }
        public static List<HoaGiap> locListHoaGiapByMapLogic(List<HoaGiap> lstHoaGiap, Map<String, List<String>> logic)
        {
            List<HoaGiap> result = new List<HoaGiap>();
            foreach (HoaGiap hoaGiap in lstHoaGiap)
            {
                if (hoaGiap.thoaManDieuKien(logic) == true) result.Add(hoaGiap);
            }
            return result;
        }

        // lấy lần lượt các hoa giáp theo 1 khoảng để xác định ngày bắt đầu 1 tháng cho đến ngày kết thúc của tháng
        // VD từ Mậu Thân đến Quý Sửu: MAU_THAN,KY_DAU,CANH_TUAT,TAN_HOI,NHAM_TY,QUY_SUU
        public static List<HoaGiap> layCacHoaGiapTheo1Khoang(String hoaGiapBatDau , String hoaGiapKetThuc)
        {
            hoaGiapBatDau = hoaGiapBatDau.ToUpper().Trim();
            hoaGiapKetThuc = hoaGiapKetThuc.ToUpper().Trim();

            List<HoaGiap> result = new List<HoaGiap>();

            int pointStart = -1;
            int pointEnd = -1;
            for (int i = 0; i < 60; i++)
            {
                String tenHoaGiap = ALL60HOAGIAP[i].ten.ToUpper();
                if (tenHoaGiap.Equals(hoaGiapBatDau)) pointStart = i;
                if (tenHoaGiap.Equals(hoaGiapKetThuc)) pointEnd = i;
            }
            if (pointStart == -1 || pointEnd == -1) return result; // không tìm thấy 1 trong 2 hoa giáp
            if(pointEnd < pointStart)
            {
                for (int i = pointStart; i < 60; i++)
                {
                    result.Add(ALL60HOAGIAP[i]);
                }
                for (int i = 0; i <= pointEnd; i++)
                {
                    result.Add(ALL60HOAGIAP[i]);
                }
            }
            else
            {
                for(int i = pointStart; i <= pointEnd; i++)
                {
                    result.Add(ALL60HOAGIAP[i]);
                }
            }

            return result;
        }
    }
}
