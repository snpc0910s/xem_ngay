using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.ultility;
namespace Xem_Ngay.model.hado_lacthu
{
    public class LacThu
    {
        private static int[,] LAC_THU_SO = {
               {4,9,2 },
               {3,5,7 },
               {8,1,6 }
        };
        public static readonly String NHAT_BACH = "Nhất Bạch";
        public static readonly String NHI_HAC = "Nhị Hắc";
        public static readonly String TAM_BICH = "Tam Bích";
        public static readonly String TU_LUC = "Tứ Lục";
        public static readonly String NGU_HOANG = "Ngũ Hoàng";
        public static readonly String LUC_BACH = "Lục Bạch";
        public static readonly String THAT_XICH = "Thất Xích";
        public static readonly String BAT_BACH = "Bát Bạch";
        public static readonly String CUU_TU = "Cửu Tử";

        public static readonly String TRUNG_CUNG = "Trung Cung";
        public static readonly String DONG = "Đông";
        public static readonly String TAY = "Tây";
        public static readonly String NAM = "Nam";
        public static readonly String BAC = "Bắc";
        public static readonly String DONG_BAC = "Đông Bắc";
        public static readonly String DONG_NAM = "Đông Nam";
        public static readonly String TAY_BAC = "Tây Bắc";
        public static readonly String TAY_NAM = "Tây Nam";

        public static readonly int[] P_TRUNG_CUNG = { 1, 1 };
        public static readonly int[] P_DONG = { 1, 0 };
        public static readonly int[] P_TAY = { 1, 2 };
        public static readonly int[] P_NAM = { 0, 1 };
        public static readonly int[] P_BAC = { 2, 1 };
        public static readonly int[] P_DONG_BAC = { 2, 0 };
        public static readonly int[] P_DONG_NAM = { 0, 0 };
        public static readonly int[] P_TAY_BAC = { 2, 2 };
        public static readonly int[] P_TAY_NAM = { 0, 2 };

        private static readonly int[][] LOGIC_PHI_TINH_THUAN = { P_TRUNG_CUNG, P_TAY_BAC, P_TAY, P_DONG_BAC, P_NAM, P_BAC, P_TAY_NAM, P_DONG, P_DONG_NAM };
        private static readonly int[][] LOGIC_PHI_TINH_NGHICH = { P_TRUNG_CUNG, P_DONG_NAM, P_DONG, P_TAY_NAM, P_BAC, P_NAM, P_DONG_BAC, P_TAY, P_TAY_BAC };


        private static readonly Map<int, String> MAP_SO_TEN_PHI_TINH = new Map<int, string>()
                                                                                    .withValue(1,NHAT_BACH).withValue(2,NHI_HAC)
                                                                                    .withValue(3,TAM_BICH).withValue(4,TU_LUC)
                                                                                    .withValue(5,NGU_HOANG).withValue(6,LUC_BACH)
                                                                                    .withValue(7,THAT_XICH).withValue(8,BAT_BACH)
                                                                                    .withValue(9,CUU_TU);
        private static readonly Table<String> TABLE_VI_TRI_VA_8_HUONG = new Table<string>()
                                            .with(0, 0, DONG_NAM).with(0, 1, NAM).with(0, 2, TAY_NAM)
                                            .with(1, 0, DONG).with(1, 1, TRUNG_CUNG ).with(1, 2, TAY)
                                            .with(2, 0, DONG_BAC).with(2, 1, BAC).with(2, 2, TAY_BAC);
        // tạo lạc thư phi thuận
        public static int[,] tao1LacThuSoPhiThuan(int soBatDau)
        {
            int[,] lacthu = new int[3, 3];
            foreach(int[] vitri in LOGIC_PHI_TINH_THUAN)
            {
                int value = soBatDau % 9;
                if (value == 0) value = 9;
                lacthu[vitri[0], vitri[1]] = value;
                soBatDau++;
            }
            return lacthu;
        }
        // tạo lạc thư phi nghịch
        public static int[,] tao1LacThuSoPhiNghich(int soBatDau)
        {
            int[,] lacthu = new int[3, 3];
            foreach (int[] vitri in LOGIC_PHI_TINH_NGHICH)
            {
                int value = soBatDau % 9;
                if (value == 0) value = 9;
                lacthu[vitri[0], vitri[1]] = value;
                soBatDau++;
            }
            return lacthu;
        }
        // tạo lạc thư dựa vào năm vd: 2021 -> trung tâm sẽ là 6
        public static int[,] tao1LacThuSoCuaNam(int nam)
        {
            int soBatDau = nam % 9;
            if (soBatDau == 0) soBatDau = 9;
            soBatDau = 11 - soBatDau;
            int[,] lacthu = new int[3, 3];
            foreach (int[] vitri in LOGIC_PHI_TINH_THUAN)
            {
                int value = soBatDau % 9;
                if (value == 0) value = 9;
                lacthu[vitri[0], vitri[1]] = value;
                soBatDau++;
            }
            return lacthu;
        }
        // hiển thị tên phi tinh theo dựa vào lạc thư số
        public static String hienThiTenPhiTinhTheoLacThu(int[,] lacThuSo)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    builder.Append(String.Format("{0,-18}",MAP_SO_TEN_PHI_TINH.get(lacThuSo[i, j])));
                }
                builder.Append(Environment.NewLine);
            }
            return builder.ToString();
        }
        // hiển thị lạc thư số
        public static String hienThiTheoLacThuSo(int[,] lacThuSo)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    builder.Append(lacThuSo[i, j] + " ");
                }
                builder.Append(Environment.NewLine);
            }
            return builder.ToString();
        }
        // tìm phương vị chứa ngũ hoàng dựa vào năm: ngũ hoàng thì sẽ tính cả đối của nó
        public static String timNguHoangDuaVaoNam(int nam)
        {
            String result = "Năm " + nam ;
            int[,] lacThuSo = tao1LacThuSoCuaNam(nam);
            for(int i  = 0; i < 3; i++)
                for(int j = 0; j < 3; j++)
                {
                    if(lacThuSo[i,j] == 5)
                    {
                        if (i == 1 && j == 1) return result + " Ngũ Hoàng tại Trung Cung";
                        String phuongVi1 = TABLE_VI_TRI_VA_8_HUONG.get(i, j);
                        String phuongVi2 = TABLE_VI_TRI_VA_8_HUONG.get(2 - i, 2 - j);
                        result =  result + " Ngũ Hoàng tại " + phuongVi1 + ", " + phuongVi2;
                    }
                }
            return result;
        }
        

    }
}
