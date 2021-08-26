using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.common;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.dia_chi
{
    class Ngo : DiaChi
    {
        
        public Ngo()
        {
            this.ten = "Ngọ";
        }
        public override DiaChi lucHai()
        {
            return DiaChiInstance.SUU;
        }

        public override NguHanh nguHanh()
        {
            return NguHanhInstance.HOA;
        }

        public override DiaChi nhiHop()
        {
            return DiaChiInstance.MUI;
        }

        public override DiaChi nhiXung()
        {
            return DiaChiInstance.TY;
        }

        public override List<DiaChi> tamHoiVoi()
        {
            return new List<DiaChi>() { DiaChiInstance.TI, DiaChiInstance.MUI };
        }

        public override List<DiaChi> tamHopVoi()
        {
            return new List<DiaChi>() { DiaChiInstance.DAN, DiaChiInstance.TUAT };
        }

        public override DiaChi trangSinh()
        {
            return DiaChiInstance.DAN;
        }
    }
}
