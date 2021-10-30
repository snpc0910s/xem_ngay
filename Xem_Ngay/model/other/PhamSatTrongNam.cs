using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.luc_thap_hoa_giap;
using Xem_Ngay.model.son_huong;

namespace Xem_Ngay.model.other
{
    public class PhamSatTrongNam
    {
        // kiểm tra toạ nhà xem có bị phạm tuế phá không ? true là phạm thái tuế, tuế phá, false là không phạm
        public static bool kiemTraPhamThaiTueVaTuePha(int nam, double toaDo)
        {
            HoaGiap hoaGiap = LucThapHoaGiap.timHoaGiapTheoNam(nam);
            if (hoaGiap == null) return true;  // mặc định là phạm nếu lỗi
            String tenHoaGiap = hoaGiap.ten;
            String tenDiaChi = tenHoaGiap.Split(' ')[1]; // VD: Tân Sửu -> Sửu
            // tìm vị trí của thái tuế trong list 24 sơn hướng // đi theo song sơn
            int viTriThaiTue1 = -1;
            int viTriThaiTue2 = -1;
            int viTriTuePha1 = -1;
            int viTriTuePha2 = -1;
            for (int i = 0; i < 24; i++)
            {
                String son = DoHinh24SonHuong.LIST_24_SON_HUONG[i];
                if (son.ToUpper().Equals(tenDiaChi.ToUpper()))
                {
                    viTriThaiTue1 = i;
                    break;
                }
            }
            if (viTriThaiTue1 % 2 == 1) viTriThaiTue2 = viTriThaiTue1 - 1; // viTriThaiTue1 = 3 (Sửu) -> viTriThaiTue2 = Quý
            else viTriThaiTue2 = viTriThaiTue1 + 1;
            // tìm tuế phá
            viTriTuePha1 = viTriThaiTue1 + 12;
            if (viTriTuePha1 > 23) viTriTuePha1 = viTriTuePha1 % 24;
            if (viTriTuePha1 % 2 == 1) viTriTuePha2 = viTriTuePha1 - 1; // viTriTuePha1 = 3 (Sửu) -> viTriTuePha2 = Quý
            else viTriTuePha2 = viTriTuePha1 + 1;

            if (viTriThaiTue1 == -1 || viTriThaiTue2 == -1 || viTriTuePha1 == -1 || viTriTuePha2 == -1) return false;
            // tìm sơn theo toạ
            String toa = DoHinh24SonHuong.timTen24SonBangToaDo(toaDo);
            if (toa == null) return true;  // mặc định là phạm nếu lỗi
            // tìm vị trí toạ 
            int viTriToaTrong24Son = -1;
            for (int i = 0; i < 24; i++)
            {
                String son = DoHinh24SonHuong.LIST_24_SON_HUONG[i];
                if (son.ToUpper().Equals(toa.ToUpper()))
                {
                    viTriToaTrong24Son = i;
                    break;
                }
            }
            if (viTriToaTrong24Son == -1) return true; // mặc định là phạm nếu lỗi
            if (viTriToaTrong24Son == viTriThaiTue1 || viTriToaTrong24Son == viTriThaiTue2
                    || viTriToaTrong24Son == viTriTuePha1 || viTriToaTrong24Son == viTriTuePha2) return true;
            return false;
        }
    }
}
