using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.common;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.dia_chi
{
    class Mui : DiaChi
    {
        public String ten = "Mùi";
        public override DiaChi lucHai()
        {
            return DiaChiInstance.TY;
        }

        public override NguHanh nguHanh()
        {
            return NguHanhInstance.THO;
        }

        public override DiaChi nhiHop()
        {
            return DiaChiInstance.NGO;
        }

        public override DiaChi nhiXung()
        {
            return DiaChiInstance.SUU;
        }

        public override List<DiaChi> tamHoiVoi()
        {
            return new List<DiaChi>() { DiaChiInstance.TI, DiaChiInstance.NGO };
        }

        public override List<DiaChi> tamHopVoi()
        {
            return new List<DiaChi>() { DiaChiInstance.HOI, DiaChiInstance.MAO };
        }

        public override DiaChi trangSinh()
        {
            return DiaChiInstance.THAN;
        }
    }
}
