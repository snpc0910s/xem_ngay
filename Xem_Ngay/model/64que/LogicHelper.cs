using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.bat_quai;
namespace Xem_Ngay.model._64que
{
    public class LogicHelper
    {
        public static int tinhQuaiKhiHKDQ(BatQuai ngoaiQuai) {
            Console.WriteLine(ngoaiQuai.ten);
            if (ngoaiQuai.ten.Equals(BatQuaiInstance.CAN.ten)) return 9;
            if (ngoaiQuai.ten.Equals(BatQuaiInstance.DOAI.ten)) return 4;
            if (ngoaiQuai.ten.Equals(BatQuaiInstance.LY.ten)) return 3;
            if (ngoaiQuai.ten.Equals(BatQuaiInstance.CHAN.ten)) return 8;
            if (ngoaiQuai.ten.Equals(BatQuaiInstance.TON.ten)) return 2;
            if (ngoaiQuai.ten.Equals(BatQuaiInstance.KHAM.ten)) return 7;
            if (ngoaiQuai.ten.Equals(BatQuaiInstance.CANAS.ten)) return 6;
            if (ngoaiQuai.ten.Equals(BatQuaiInstance.KHON.ten)) return 1;
            return 0;
        }
        // công thức không đúng
        public static int tinhQuaiVanHKDQ(BatQuai ngoaiQuai, BatQuai noiQuai)
        {
            bool[] nhiPhanNgoai = ngoaiQuai.nhiPhan;
            bool[] nhiPhanNoi = noiQuai.nhiPhan;

            bool[] resultCompare = new bool[3];

            int count = 0;
            if (nhiPhanNgoai[0] == nhiPhanNoi[0]) {
                resultCompare[0] = true;
                count++;
            }
            if (nhiPhanNgoai[1] == nhiPhanNoi[1])
            {
                resultCompare[1] = true;
                count++;
            }
            if (nhiPhanNgoai[2] == nhiPhanNoi[2])
            {
                resultCompare[2] = true;
                count++;
            }
            // khac nhau hoan toan
            if (count == 0) return 9;
            // giong nhau hoan toan
            if (count == 3) return 1;
            // khac nhau
            int countFalse = 0;
            int countTrue = 0;
            for (int i = 0; i < 3; i++) {
                if (resultCompare[i] == true) {
                    countTrue++;
                }
                else
                {
                    countFalse++;
                }
            }
            bool chooseDifferent = countTrue > countFalse ? false : true;
            int position = 0;
            for (int i = 0; i < 3; i++)
            {
                if (resultCompare[i] == chooseDifferent) {
                    // lưu vị trí nghi khác biệt
                    position = i + 1;
                    break;
                }
            }
            // không đổi
            if (chooseDifferent == true) {
                if (position == 3) return 5;
                if (position == 2) return 3;
                if (position == 1) return 2;
            }
            // đổi
            if (chooseDifferent == false)
            {
                if (position == 3) return 6;
                if (position == 2) return 7;
                if (position == 1) return 8;
            }
            return 0;
        }
    }
}
