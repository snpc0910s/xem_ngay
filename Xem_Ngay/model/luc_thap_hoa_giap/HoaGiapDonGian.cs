using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.luc_thap_hoa_giap;

namespace Xem_Ngay.model.luc_thap_hoa_giap
{
    public class HoaGiapDonGian
    {
        public String tenHoaGiap;
        public int quaiKhi;
        public String tenQue;
        public int quaiVan;

        public HoaGiapDonGian(String tenHoaGiap, int quaiKhi, String tenQue, int quaiVan)
        {
            this.tenHoaGiap = tenHoaGiap;
            this.quaiKhi = quaiKhi;
            this.tenQue = tenQue;
            this.quaiVan = quaiVan;
        }
        public String[] toRowDataTable()
        {
            return new String[] {this.quaiKhi+"" , this.tenQue , this.quaiVan+ "" , this.tenHoaGiap };
        }
    }
}
