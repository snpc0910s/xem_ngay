using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.common;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.dia_chi
{
    class Tuat : DiaChi
    {

        public String ten = "Tuất";
        public override DiaChi lucHai()
        {
            return DiaChiInstance.DAU;
        }

        public override NguHanh nguHanh()
        {
            return NguHanhInstance.THO;
        }

        public override DiaChi nhiHop()
        {
            return DiaChiInstance.MAO;
        }

        public override DiaChi nhiXung()
        {
            return DiaChiInstance.THIN;
        }

        public override List<DiaChi> tamHoiVoi()
        {
            return new List<DiaChi>() { DiaChiInstance.THAN, DiaChiInstance.DAU };
        }

        public override List<DiaChi> tamHopVoi()
        {
            return new List<DiaChi>() { DiaChiInstance.DAN, DiaChiInstance.NGO };
        }

        public override DiaChi trangSinh()
        {
            return DiaChiInstance.THAN;
        }
    }
}
