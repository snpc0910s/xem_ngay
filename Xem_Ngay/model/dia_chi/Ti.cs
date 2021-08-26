using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.common;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.dia_chi
{
    class Ti : DiaChi
    {
        public String ten = "Tị";
        public override DiaChi lucHai()
        {
            return DiaChiInstance.DAN;
        }
        public override NguHanh nguHanh()
        {
            return NguHanhInstance.HOA;
        }

        public override DiaChi nhiHop()
        {
            return DiaChiInstance.THAN;
        }

        public override DiaChi nhiXung()
        {
            return DiaChiInstance.HOI;
        }

        public override List<DiaChi> tamHoiVoi()
        {
            return new List<DiaChi>() { DiaChiInstance.NGO, DiaChiInstance.MUI };
        }

        public override List<DiaChi> tamHopVoi()
        {
            return new List<DiaChi>() { DiaChiInstance.DAU, DiaChiInstance.SUU };
        }

        public override DiaChi trangSinh()
        {
            return DiaChiInstance.DAN;
        }
    }
}
