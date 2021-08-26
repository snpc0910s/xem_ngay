using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;

namespace Xem_Ngay.model.bat_quai
{
    public abstract class BatQuai
    {
        public String ten;
        public String tenGhep;
        public bool[] nhiPhan ;
        public static readonly String PATH_IMG_ROOT = "resource/img/bat_quai/";
        public abstract NguHanh nguHanh();
        public abstract String pathImage();
    }
}
