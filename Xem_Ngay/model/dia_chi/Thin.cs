using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.common;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.dia_chi
{
    class Thin : DiaChi
    {
        public String ten = "Thìn";
        public override DiaChi lucHai()
        {
            return DiaChiInstance.MAO;
        }
        public override NguHanh nguHanh()
        {
            return NguHanhInstance.THO;
        }

        public override DiaChi nhiHop()
        {
            return DiaChiInstance.DAU;
        }

        public override DiaChi nhiXung()
        {
            return DiaChiInstance.TUAT;
        }

        public override List<DiaChi> tamHoiVoi()
        {
            return new List<DiaChi>() { DiaChiInstance.DAN, DiaChiInstance.MAO };
        }

        public override List<DiaChi> tamHopVoi()
        {
            return new List<DiaChi>() { DiaChiInstance.THAN, DiaChiInstance.TY };
        }

        public override DiaChi trangSinh()
        {
            return DiaChiInstance.THAN;
        }
    }
}
