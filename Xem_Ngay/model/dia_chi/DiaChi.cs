using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;
using Xem_Ngay.common;

namespace Xem_Ngay.model
{
    public abstract class DiaChi
    {
        public String ten;
        
        public abstract NguHanh nguHanh();

        public abstract DiaChi nhiHop();

        public abstract DiaChi nhiXung();

        public abstract DiaChi lucHai();

        public abstract DiaChi trangSinh();

        public abstract List<DiaChi> tamHopVoi();

        public abstract List<DiaChi> tamHoiVoi();

    }
}
