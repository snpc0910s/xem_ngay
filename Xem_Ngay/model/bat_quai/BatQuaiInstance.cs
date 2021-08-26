using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xem_Ngay.model.bat_quai
{
    public class BatQuaiInstance
    {
        public static BatQuai CAN = new QuaiCan();
        public static BatQuai DOAI = new QuaiDoai();
        public static BatQuai LY = new QuaiLy();
        public static BatQuai CHAN = new QuaiChan();
        public static BatQuai TON = new QuaiTon();
        public static BatQuai KHAM = new QuaiKham();
        public static BatQuai CANAS = new QuaiCanas();
        public static BatQuai KHON = new QuaiKhon();
    }
}
