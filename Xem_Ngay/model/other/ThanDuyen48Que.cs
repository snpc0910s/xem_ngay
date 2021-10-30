using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xem_Ngay.common;
using Xem_Ngay.ultility;
using Xem_Ngay.model.luc_thap_hoa_giap;
using Xem_Ngay.model._64que;
namespace Xem_Ngay.model.other
{
    public class ThanDuyen48Que
    {
        // so sánh lần lượt các trụ với nhau xem có thuân âm dương hay không ? không quan tâm trụ tên gì tatCaTru
        private static readonly List<String> NAM_THANG_NGAY_GIO = new List<String>() {"nam","thang","ngay","gio","toa","gc1","gc2" };

        public static TableFixed<String,String,String> reportThanDuyen(Map<String, String> tatCaTru)
        {
            TableFixed<String, String, String> tableReport = new TableFixed<string, string, string>(NAM_THANG_NGAY_GIO, NAM_THANG_NGAY_GIO);
            
            foreach (KeyValuePair<string, String> hoaGiap1 in tatCaTru)
            {
                String keyTru1 = hoaGiap1.Key; //  "nam","thang","ngay","gio","toa","gc1","gc2"
                String tenQue1 = hoaGiap1.Value; // dia thien thai abc ...
                foreach (KeyValuePair<string, String> hoaGiap2 in tatCaTru)
                {
                    String keyTru2 = hoaGiap2.Key; //  "nam","thang","ngay","gio","toa","gc1","gc2"
                    if (keyTru1.Equals(keyTru2)) continue; // neu lap lai thi bo qua
                    String tenQue2 = hoaGiap2.Value; // dia thien thai abc ...

                    // test thân duyên 2 quẻ 1 lần
                    StatusTransfer<Map<String, String>> thanduyen = AllQueDich.kiemTraThanDuyen2QueTheoTen(tenQue1, tenQue2);
                    if(thanduyen.status == true)
                    {
                        // 2 quẻ là thân duyên
                        Map<String, String> amDuong2que = thanduyen.data; // key1:ngay <"Địa Lôi Phục","Dương">  key2:gio <"Thiên Trạch Lý","Âm">

                        //String amduongque1 = amDuong2que.get(tenQue1);
                        //String amduongque2 = amDuong2que.get(tenQue2);
                        //tableReport.add(keyTru1, keyTru2, amduongque1);
                        //tableReport.add(keyTru2, keyTru1, amduongque2);
                        foreach (KeyValuePair<String, String> queAD in amDuong2que)
                        {
                            String tenQueAD = queAD.Key;
                            String hang = null;
                            String cot = null;
                            String tenAD = queAD.Value;
                            if (tenQueAD.Equals(tenQue1)) //so sanh 1 trong 2
                            {
                                hang = keyTru1;
                                cot = keyTru2;
                            }
                            else
                            {
                                hang = keyTru2;
                                cot = keyTru1;
                            }
                            tableReport.add(hang, cot, tenAD);
                        }
                    }
                    else
                    {
                            // khác quẻ
                            // kiểm tra phụ mẫu quái
                            if (AllQueDich.ALL_TEN_PHU_MAU_QUE.ContainsKey(tenQue1))
                            {
                                tableReport.add(keyTru1, keyTru1, AllQueDich.ALL_TEN_PHU_MAU_QUE.get(tenQue1));
                                if (tenQue1.Equals(tenQue2))
                                {
                                // trùng quẻ
                                tableReport.add(keyTru2, keyTru2, AllQueDich.ALL_TEN_PHU_MAU_QUE.get(tenQue2));
                                }
                            }
                            else
                            {
                                if (AllQueDich.ALL_TEN_PHU_MAU_QUE.ContainsKey(tenQue2))
                                {
                                    tableReport.add(keyTru2, keyTru2, AllQueDich.ALL_TEN_PHU_MAU_QUE.get(tenQue2));
                                }
                                else
                                {
                                    tableReport.add(keyTru1, keyTru2, thanduyen.message);
                                    tableReport.add(keyTru2, keyTru1, thanduyen.message);
                                }
                            }                   
                    }
                }
            }
            return tableReport;
        }
    }
}
