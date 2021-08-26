using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.common;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.dia_chi
{
    class Dau : DiaChi
    {
        public String ten = "Dậu";

        public override DiaChi lucHai()
        {
            return DiaChiInstance.TUAT;
        }


        public override NguHanh nguHanh()
        {
            return NguHanhInstance.KIM;
        }

        public override DiaChi nhiHop()
        {
            return DiaChiInstance.THIN;
        }

        public override DiaChi nhiXung()
        {
            return DiaChiInstance.MAO;
        }

        public override List<DiaChi> tamHoiVoi()
        {
            return new List<DiaChi>() { DiaChiInstance.THAN, DiaChiInstance.TUAT };
        }

        public override List<DiaChi> tamHopVoi()
        {
            return new List<DiaChi>() { DiaChiInstance.SUU, DiaChiInstance.TI };
        }

        public override DiaChi trangSinh()
        {
            return DiaChiInstance.TI;
        }
    }
}
