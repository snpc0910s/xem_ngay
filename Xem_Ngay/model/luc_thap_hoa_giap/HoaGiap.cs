using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;
using Xem_Ngay.model._64que;

namespace Xem_Ngay.model.luc_thap_hoa_giap
{
    public class HoaGiap
    {
        public String ten;
        public NguHanh nguHanhNapAm;
        public ThienCan thienCan;
        public DiaChi diaChi;
        public List<Que> ques;

        public HoaGiap(ThienCan thienCan, DiaChi diaChi) {
            this.thienCan = thienCan;
            this.diaChi = diaChi;
            this.ten = this.thienCan.ten + " " + this.diaChi.ten;
            this.nguHanhNapAm = this.tinhNguHanhNapAm();
            this.ques = new List<Que>();
        }
        public HoaGiap themQue(Que que)
        {
            this.ques.Add(que);
            return this;
        }

        public String toString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.ten +":  " + this.nguHanhNapAm.ten +  ":");
            foreach(Que que in ques)
            {
                sb.Append(" "+ que.toLog() + "  ");
            }
            return sb.ToString();
        }

        private NguHanh tinhNguHanhNapAm()
        {
            String tenThienCan = this.thienCan.ten;
            String tenDiaChi = this.diaChi.ten;

            String[] arr1 = { "Tý", "Sửu", "Ngọ", "Mùi" };
            String[] arr2 = { "Dần", "Mão", "Thân", "Dậu" };
            String[] arr3 = { "Thìn", "Tị", "Tuất", "Hợi" };
            int saveStart = 0;
            if (arr1.Contains(tenDiaChi)) saveStart = 4;
            if (arr2.Contains(tenDiaChi)) saveStart = 5;
            if (arr3.Contains(tenDiaChi)) saveStart = 1;
            int saveRun = -1;
            if (tenThienCan.Equals("Giáp") || tenThienCan.Equals("Ất")) saveRun = 0;
            if (tenThienCan.Equals("Bính") || tenThienCan.Equals("Đinh")) saveRun = 1;
            if (tenThienCan.Equals("Mậu") || tenThienCan.Equals("Kỷ")) saveRun = 2;
            if (tenThienCan.Equals("Canh") || tenThienCan.Equals("Tân")) saveRun = 3;
            if (tenThienCan.Equals("Nhâm") || tenThienCan.Equals("Quý")) saveRun = 4;
            int cal = (saveStart + saveRun) % 5;
            if (cal == 0) cal = 5;

            switch (cal)
            {
                case 1: return NguHanhInstance.HOA;
                case 2: return NguHanhInstance.THO;
                case 3: return NguHanhInstance.MOC;
                case 4: return NguHanhInstance.KIM;
                case 5: return NguHanhInstance.THUY;
                default: return NguHanhInstance.UNKNOWN;
            }
        }
    }
}
