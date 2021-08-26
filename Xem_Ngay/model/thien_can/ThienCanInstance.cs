using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xem_Ngay.model.thien_can
{
    public class ThienCanInstance
    {
        public static readonly ThienCan GIAP = new Giap();
        public static readonly ThienCan AT = new At();
        public static readonly ThienCan BINH = new Binh();
        public static readonly ThienCan DINH = new Dinh();
        public static readonly ThienCan MAU = new Mau();
        public static readonly ThienCan KY = new Ky();
        public static readonly ThienCan CANH = new Canh();
        public static readonly ThienCan TAN = new Tan();
        public static readonly ThienCan NHAM = new Nham();
        public static readonly ThienCan QUY = new Quy();
    }
}
