using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xem_Ngay.model.dia_chi
{
    class All12DiaChi
    {

        public static readonly String GIAP = "Giáp";
        public static readonly String AT = "Ất";
        public static readonly String BINH = "Bính";
        public static readonly String DINH = "Đinh";
        public static readonly String MAU = "Mậu";
        public static readonly String KY = "Kỷ";
        public static readonly String CANH = "Canh";
        public static readonly String TAN = "Tân";
        public static readonly String NHAM = "Nhâm";
        public static readonly String QUY = "Quý";

        public static readonly List<DiaChi> allDiaChi = new List<DiaChi>() { DiaChiInstance.TY, DiaChiInstance.SUU, DiaChiInstance.DAN, DiaChiInstance.MAO, DiaChiInstance.THIN, DiaChiInstance.TI, DiaChiInstance.NGO, DiaChiInstance.MUI, DiaChiInstance.THAN, DiaChiInstance.DAU, DiaChiInstance.TUAT, DiaChiInstance.HOI };
        

    }
}
