using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.common;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.dia_chi
{
    class Than : DiaChi
    {
        public Than()
        {
            this.ten = "Thân";
        }
        public override DiaChi lucHai()
        {
            return DiaChiInstance.HOI;
        }

        public override NguHanh nguHanh()
        {
            return NguHanhInstance.KIM;
        }

        public override DiaChi nhiHop()
        {
            return DiaChiInstance.TI;
        }

        public override DiaChi nhiXung()
        {
            return DiaChiInstance.DAN;
        }

        public override List<DiaChi> tamHoiVoi()
        {
            return new List<DiaChi>() { DiaChiInstance.DAU, DiaChiInstance.TUAT };
        }

        public override List<DiaChi> tamHopVoi()
        {
            return new List<DiaChi>() { DiaChiInstance.TY, DiaChiInstance.THIN };
        }

        public override DiaChi trangSinh()
        {
            return DiaChiInstance.TI;
        }
    }
}
