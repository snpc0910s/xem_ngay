using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.ultility;
namespace Xem_Ngay.model.dia_chi
{
    class All12DiaChi
    {

        public static readonly List<DiaChi> allDiaChi = new List<DiaChi>() { DiaChiInstance.TY, DiaChiInstance.SUU, DiaChiInstance.DAN, DiaChiInstance.MAO, DiaChiInstance.THIN, DiaChiInstance.TI, DiaChiInstance.NGO, DiaChiInstance.MUI, DiaChiInstance.THAN, DiaChiInstance.DAU, DiaChiInstance.TUAT, DiaChiInstance.HOI };

        public static readonly List<String> TAM_HOP_THUY = new List<String> { "Thân", "Tý", "Thìn" };
        public static readonly List<String> TAM_HOP_HOA = new List<String> { "Dần", "Ngọ", "Tuất" };
        public static readonly List<String> TAM_HOP_MOC = new List<String> { "Hợi", "Mão", "Mùi" };
        public static readonly List<String> TAM_HOP_KIM = new List<String> { "Tị", "Dậu", "Sửu" };

        public static readonly Map<string, List<String>> MAP_TAM_HOP = new Map<string, List<string>>()
                                                        .withValue("Thuỷ", TAM_HOP_THUY)
                                                        .withValue("Hoả", TAM_HOP_HOA)
                                                        .withValue("Kim", TAM_HOP_KIM)
                                                        .withValue("Mộc", TAM_HOP_MOC);
    }
}
