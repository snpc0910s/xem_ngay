using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.common;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.dia_chi
{
    public class Ty : DiaChi
    {
        public Ty()
        {
            this.ten = "Tý";
        }

        public override DiaChi lucHai()
        {
            return DiaChiInstance.MUI;
        }

        public override NguHanh nguHanh()
        {
            return NguHanhInstance.THUY;
        }

        public override DiaChi nhiHop()
        {
            return DiaChiInstance.SUU;
        }

        public override DiaChi nhiXung()
        {
            return DiaChiInstance.NGO;
        }

        public override List<DiaChi> tamHoiVoi()
        {
            return new List<DiaChi>() { DiaChiInstance.HOI, DiaChiInstance.SUU };
        }

        public override List<DiaChi> tamHopVoi()
        {
            return new List<DiaChi>() { DiaChiInstance.THAN, DiaChiInstance.THIN };
        }

        public override DiaChi trangSinh()
        {
            return DiaChiInstance.THAN;
        }
    }
}
