using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.common;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.dia_chi
{
    class Mao : DiaChi
    {
        public String ten = "Mão";
        public override DiaChi lucHai()
        {
            return DiaChiInstance.THIN;
        }

        public override NguHanh nguHanh()
        {
            return NguHanhInstance.MOC;
        }

        public override DiaChi nhiHop()
        {
            return DiaChiInstance.TUAT;
        }

        public override DiaChi nhiXung()
        {
            return DiaChiInstance.DAU;
        }

        public override List<DiaChi> tamHoiVoi()
        {
            return new List<DiaChi>() { DiaChiInstance.DAN, DiaChiInstance.THIN };
        }

        public override List<DiaChi> tamHopVoi()
        {
            return new List<DiaChi>() { DiaChiInstance.HOI, DiaChiInstance.MUI };
        }

        public override DiaChi trangSinh()
        {
            return DiaChiInstance.HOI;
        }
    }
}
