using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.model.ngu_hanh;
using Xem_Ngay.model._64que;
using Xem_Ngay.ultility;

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
        // support top 1 convert to logic
        public static Map<String,List<String>> chuyenStringToMapLogic(String input)
        {
            Map<String, List<String>> logic = new Map<string, List<string>>();
            // vd: template  iput :  cx:Quý Hợi;cq:Tấn,Minh Di;bt:Nhâm,Quý;bd:Tý,Sửu;bk:1,2,5;bv:2,7 
            String[] commands = input.Split(';');
            foreach(String command in commands)
            {
                if (command.Trim().Equals("")) continue;
                String[] kvs = command.Split(':');
                String key = kvs[0];
                String[] vs = kvs[1].Split(',');
                List<String> lvalue = new List<String>();
                foreach(String v in vs)
                {
                    lvalue.Add(v);
                }
                logic.add(key, lvalue);
            }


            return logic;
        }

        // top 1 tinh nang xac nhan thoa man
        public bool thoaManDieuKien(Map<String,List<String>> logic)
        {
            // ƯU TIÊN BỎ TRƯỚC RỒI SẼ CHỌN SAU

            bool boKey = false;
            // bỏ thiên can
            if (logic.ContainsKey("bt"))
            {
                List<String> multi = logic.get("bt");
                String tca = this.thienCan.ten.ToUpper();
                foreach (String s in multi)
                {
                    if (tca.Equals(s.ToUpper()))
                    {
                        boKey = true;
                        break;
                    }
                }
            }
            // bỏ dia chi
            if (logic.ContainsKey("bd"))
            {
                List<String> multi = logic.get("bd");
                String dca = this.diaChi.ten.ToUpper();
                foreach (String s in multi)
                {
                    if (dca.Equals(s.ToUpper()))
                    {
                        boKey = true;
                        break;
                    }
                }
            }
            // bỏ quai khi
            if (logic.ContainsKey("bk"))
            {
                List<String> multi = logic.get("bk");
                if(this.ques.Count == 1)
                {
                    String quaikhi = this.ques[0].quaiKhi+"";
                    foreach (String s in multi)
                    {
                        if (quaikhi.Equals(s))
                        {
                            boKey = true;
                            break;
                        }
                    }
                }
                else
                {
                    // =2
                    String quaikhi1 = this.ques[0].quaiKhi + "";
                    String quaikhi2 = this.ques[1].quaiKhi + "";
                    bool key1 = true;
                    bool key2 = true;
                    foreach (String s in multi)
                    {
                        if (quaikhi1.Equals(s)) key1 =  false;
                        if (quaikhi2.Equals(s)) key2 =  false;
                    }
                    if (key1 == false && key2 == false)
                    {
                        boKey = true;
                    }
                }
            }
            // bỏ quai van
            if (logic.ContainsKey("bv"))
            {
                List<String> multi = logic.get("bv");
                if (this.ques.Count == 1)
                {
                    String quaivan = this.ques[0].quaiVan + "";
                    foreach (String s in multi)
                    {
                        if (quaivan.Equals(s))
                        {
                            boKey = true;
                            break;
                        }
                    }
                }
                else
                {
                    // =2
                    String quaivan1 = this.ques[0].quaiVan + "";
                    String quaivan2 = this.ques[1].quaiVan + "";
                    bool key1 = true;
                    bool key2 = true;
                    foreach (String s in multi)
                    {
                        if (quaivan1.Equals(s)) key1 = false;
                        if (quaivan2.Equals(s)) key2 = false;
                    }
                    if (key1 == false && key2 == false)
                    {
                        boKey = true;
                    }
                }
            }
            if (logic.ContainsKey("bq"))
            {
                List<String> multi = logic.get("bq");
                if(this.ques.Count == 1)
                {
                    String ttt = this.ques[0].ten.ToUpper();
                    foreach(String s in multi)
                    {
                        String ttts = s.Trim().ToUpper();
                        if(ttt.IndexOf(ttts) > -1)
                        {
                            boKey = true;
                            break;
                        }
                    }
                }else
                {
                    // == 2\
                    String ttt1 = this.ques[0].ten.ToUpper();
                    String ttt2 = this.ques[1].ten.ToUpper();
                    foreach (String s in multi)
                    {
                        String ttts = s.Trim().ToUpper();
                        if ((ttt1.IndexOf(ttts) > -1) || (ttt2.IndexOf(ttts) > -1))
                        {
                            boKey = true;
                            break;
                        }
                    }
                }
            }
            //// chọn chính xác tên hoa giáp hoặc tên quẻ
            //// chọn không thoả mãn cái nào thì là false, 1 cái thì vẫn là true
            //bool keyChoose = false;
            //if (logic.ContainsKey("cx"))
            //{
            //    List<String> multi = logic.get("cx");
            //    String tenTemp = this.ten.ToUpper();
            //    foreach (String s in multi)
            //    {
            //        if (s.ToUpper().Trim().Equals(tenTemp))
            //        {
            //            keyChoose = true; break;
            //        }
            //    }
            //}
            //if (logic.ContainsKey("cq"))
            //{
            //    List<String> multi = logic.get("cq");
            //    if (this.ques.Count == 1)
            //    {
            //        String tenTemp = this.ques[0].ten.ToUpper();

            //        foreach (String s in multi)
            //        {
            //            String ttt = s.ToUpper().Trim();
            //            if (tenTemp.IndexOf(ttt) > -1)
            //            {
            //                keyChoose = true; break;
            //            }
            //        }

            //    }
            //    else
            //    {
            //        //= 2
            //        String tenTemp1 = this.ques[0].ten.ToUpper();
            //        String tenTemp2 = this.ques[1].ten.ToUpper();
            //        foreach (String s in multi)
            //        {
            //            String ttt = s.ToUpper().Trim();
            //            if (ttt.Equals(tenTemp1) || ttt.Equals(tenTemp2))
            //            {
            //                keyChoose = true; break;
            //            }
            //        }
            //    }
            //}
            //// chọn nếu tồn tại thiên can
            //if (logic.ContainsKey("ct"))
            //{
            //    List<String> multi = logic.get("ct");
            //    String tt = this.thienCan.ten.ToUpper();
            //    foreach(String s in multi)
            //    {
            //        String st = s.ToUpper().Trim();
            //        if (st.Equals(tt))
            //        {
            //            keyChoose = true; break;
            //        }
            //    }
            //}
            //// chọn nếu tồn tại địa chi
            //if (logic.ContainsKey("cd"))
            //{
            //    List<String> multi = logic.get("cd");
            //    String tt = this.diaChi.ten.ToUpper();
            //    foreach (String s in multi)
            //    {
            //        String st = s.ToUpper().Trim();
            //        if (st.Equals(tt))
            //        {
            //            keyChoose = true; break;
            //        }
            //    }
            //}
            //// chọn nếu tồn tại quái khí
            //if (logic.ContainsKey("ck"))
            //{
            //    List<String> multi = logic.get("ck");
            //    if(this.ques.Count == 1)
            //    {
            //        String qk = this.ques[0].quaiKhi + "";
            //        foreach (String s in multi)
            //        {
            //            String ttt = s.Trim();
            //            if (qk.Equals(ttt))
            //            {
            //                keyChoose = true; break;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        // = 2
            //        String qk1 = this.ques[0].quaiKhi + "";
            //        String qk2 = this.ques[1].quaiKhi + "";
            //        foreach (String s in multi)
            //        {
            //            String ttt = s.Trim();
            //            if (qk1.Equals(ttt) || qk2.Equals(ttt))
            //            {
            //                keyChoose = true; break;
            //            }
            //        }
            //    }
            //}
            //// chọn nếu tồn tại quái vận
            //if (logic.ContainsKey("cv"))
            //{
            //    List<String> multi = logic.get("cv");
            //    if (this.ques.Count == 1)
            //    {
            //        String qk = this.ques[0].quaiVan + "";
            //        foreach (String s in multi)
            //        {
            //            String ttt = s.Trim();
            //            if (qk.Equals(ttt))
            //            {
            //                keyChoose = true; break;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        // = 2
            //        String qk1 = this.ques[0].quaiVan + "";
            //        String qk2 = this.ques[1].quaiVan + "";
            //        foreach (String s in multi)
            //        {
            //            String ttt = s.Trim();
            //            if (qk1.Equals(ttt) || qk2.Equals(ttt))
            //            {
            //                keyChoose = true; break;
            //            }
            //        }
            //    }
            //}
            //if (keyChoose == true) return true;
            if (boKey == true) return false;
            return true;
        }

        // lay 12 tháng từ thiên can
        public List<HoaGiap> lay12Thang()
        {
            String th = this.thienCan.ten;
            String di = this.diaChi.ten;
            int sttThienCan = LucThapHoaGiap.MAP_STT_STRING_THIEN_CAN.findFirstKeyByValue(th);
            int sttDiaChi = LucThapHoaGiap.MAP_STT_STRING_DIACHI.findFirstKeyByValue(di);

            int start = (sttThienCan * 2 + 1) % 10;
            int[] arrayMatchDiaChi = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            int point = 2; // Dần
            for(int i = 0; i < 12; i++)
            {
                arrayMatchDiaChi[point] = start;
                point++;
                start++;
                point = point % 12;
                start = start % 10;
                if (start == 0) start = 10;
            }
            List<HoaGiap> result = new List<HoaGiap>();
            for(int i = 0; i < 12; i++)
            {
                String eThienCan = LucThapHoaGiap.MAP_STT_STRING_THIEN_CAN.get(arrayMatchDiaChi[i]);
                String eDiaChi = LucThapHoaGiap.MAP_STT_STRING_DIACHI.get(i + 1);
                HoaGiap hoaGiap = LucThapHoaGiap.timChinhXacDauTien(eThienCan + " " + eDiaChi);
                result.Add(hoaGiap);
            }
            return result;
        }
        // lấy 12 giờ từ thiên can
        public List<HoaGiap> lay12Gio()
        {
            String th = this.thienCan.ten;
            String di = this.diaChi.ten;
            int sttThienCan = LucThapHoaGiap.MAP_STT_STRING_THIEN_CAN.findFirstKeyByValue(th);
            int sttDiaChi = LucThapHoaGiap.MAP_STT_STRING_DIACHI.findFirstKeyByValue(di);

            int start = (sttThienCan * 2 - 1) % 10;
            int[] arrayMatchDiaChi = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            int point = 0; // Dần
            for (int i = 0; i < 12; i++)
            {
                arrayMatchDiaChi[point] = start;
                point++;
                start++;
                point = point % 12;
                start = start % 10;
                if (start == 0) start = 10;
            }
            List<HoaGiap> result = new List<HoaGiap>();
            for (int i = 0; i < 12; i++)
            {
                String eThienCan = LucThapHoaGiap.MAP_STT_STRING_THIEN_CAN.get(arrayMatchDiaChi[i]);
                String eDiaChi = LucThapHoaGiap.MAP_STT_STRING_DIACHI.get(i + 1);
                HoaGiap hoaGiap = LucThapHoaGiap.timChinhXacDauTien(eThienCan + " " + eDiaChi);
                result.Add(hoaGiap);
            }
            return result;
        }
        public String toString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.ten + ":  " + this.nguHanhNapAm.ten + ":");
            foreach (Que que in ques)
            {
                sb.Append(" " + que.toLog() + "  ");
            }
            return sb.ToString();
        }
        public List<HoaGiapDonGian> toHoaGiapDonGian()
        {
            List<HoaGiapDonGian> results = new List<HoaGiapDonGian>();
            results.Add(new HoaGiapDonGian(this.ten, this.ques[0].quaiKhi, this.ques[0].ten, this.ques[0].quaiVan));
            if (this.ques.Count == 2)
            {
                results.Add(new HoaGiapDonGian(this.ten, this.ques[1].quaiKhi, this.ques[1].ten, this.ques[1].quaiVan));
            }
            return results;
        }

    }
}
