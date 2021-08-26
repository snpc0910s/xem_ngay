using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.common;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.dia_chi
{
    class Dan : DiaChi
    {
        public String ten = "Dần";
        public override DiaChi lucHai()
        {
            return DiaChiInstance.TY;
        }

        public override NguHanh nguHanh()
        {
            return NguHanhInstance.MOC;
        }

        public override DiaChi nhiHop()
        {
            return DiaChiInstance.HOI;
        }

        public override DiaChi nhiXung()
        {
            return DiaChiInstance.THAN;
        }

        public override List<DiaChi> tamHoiVoi()
        {
            return new List<DiaChi>() { DiaChiInstance.MAO, DiaChiInstance.THIN };
        }

        public override List<DiaChi> tamHopVoi()
        {
            return new List<DiaChi>() { DiaChiInstance.NGO, DiaChiInstance.TUAT };
        }

        public override DiaChi trangSinh()
        {
            return DiaChiInstance.HOI;
        }
    }
}
