using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.common;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.dia_chi
{
    class Hoi : DiaChi
    {
        public Hoi()
        {
            this.ten = "Hợi";
        }
        public override DiaChi lucHai()
        {
            return DiaChiInstance.THAN;
        }
        public override NguHanh nguHanh()
        {
            return NguHanhInstance.THUY;
        }

        public override DiaChi nhiHop()
        {
            return DiaChiInstance.DAN;
        }

        public override DiaChi nhiXung()
        {
            return DiaChiInstance.TI;
        }

        public override List<DiaChi> tamHoiVoi()
        {
            return new List<DiaChi>() { DiaChiInstance.TY, DiaChiInstance.SUU };
        }

        public override List<DiaChi> tamHopVoi()
        {
            return new List<DiaChi>() { DiaChiInstance.MAO, DiaChiInstance.MUI };
        }

        public override DiaChi trangSinh()
        {
            return DiaChiInstance.THAN;
        }
    }
}
