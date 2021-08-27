using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.bat_quai;

namespace Xem_Ngay.model._64que
{
    public class Que
    {
        public String ten;
        public BatQuai ngoaiQuai;
        public BatQuai noiQuai;
        public int quaiKhi; // HKDQ : ngu hanh quai khi 
        public int quaiVan; // HKDQ

        public Que() : base()
        {

        }
        public Que(String ten, BatQuai ngoaiQuai, BatQuai noiQuai)
        {
            this.ten = ten;
            this.ngoaiQuai = ngoaiQuai;
            this.noiQuai = noiQuai;
            // auto quai khi va quai van
            this.quaiKhi = LogicHelper.tinhQuaiKhiHKDQ(ngoaiQuai);
            //this.quaiVan = LogicHelper.tinhQuaiVanHKDQ(ngoaiQuai, noiQuai);
        }
        public Que setQuaiVan(int quaiVan)
        {
            this.quaiVan = quaiVan;
            return this;
        }

        public String toLog()
        {
            return this.quaiKhi + " " + this.ten + " " + quaiVan;
        }
    }
}
