using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.common;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.dia_chi
{
    public class Suu : DiaChi
    {
        public Suu()
        {
            this.ten = "Sửu";
        }
        public override DiaChi lucHai()
        {
            return DiaChiInstance.NGO;
        }

        public override NguHanh nguHanh()
        {
            return NguHanhInstance.THO;
        }

        public override DiaChi nhiHop()
        {
            return DiaChiInstance.TY;
        }

        public override DiaChi nhiXung()
        {
            return DiaChiInstance.MUI;
        }

        public override List<DiaChi> tamHoiVoi()
        {
            return new List<DiaChi>() { DiaChiInstance.HOI, DiaChiInstance.TY };
        }

        public override List<DiaChi> tamHopVoi()
        {
            return new List<DiaChi>() { DiaChiInstance.DAU, DiaChiInstance.TI };
        }

        public override DiaChi trangSinh()
        {
            return DiaChiInstance.THAN;
        }
    }
}
