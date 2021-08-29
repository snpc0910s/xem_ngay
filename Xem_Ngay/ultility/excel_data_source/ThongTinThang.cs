using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xem_Ngay.ultility.excel_data_source
{
    public class ThongTinThang
    {
        public string nam;
        public string namChu;
        public string thang;
        public string ngayBatDau;
        public string ngayKetThuc;

        public ThongTinThang(String nam, String namChu, String thang, String ngayBatDau, String ngayKetThuc)
        {
            this.nam = nam;
            this.namChu = namChu;
            this.thang = thang;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
        }

    }
}
