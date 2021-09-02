using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using ExcelDataReader;
using System.Data;
namespace Xem_Ngay.ultility.excel_data_source
{
    public class DocGioiHanThangTrongNamExcel
    {
        private static readonly String PATH_FILE = "data_nam_thang_ngay_xem_ngay.xlsx";
        

        public static List<ThongTinThang> layThongTinThangTuResource()
        {
            List<ThongTinThang> thongtin = new List<ThongTinThang>();

            using (var stream = File.Open(PATH_FILE, FileMode.Open, FileAccess.Read))
            {
                // Auto-detect format, supports:
                //  - Binary Excel files (2.0-2003 format; *.xls)
                //  - OpenXml Excel files (2007 format; *.xlsx, *.xlsb)
                
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet();
                    var tables = result.Tables.Cast<DataTable>();
                    foreach(DataTable dataTable in tables)
                    {
                        for (int i = 1; i < dataTable.Rows.Count; i++)
                        {
                            var rowData = dataTable.Rows[i].ItemArray;
                            String nam = rowData[0].ToString();
                            String namChu = rowData[1].ToString();
                            String thang = rowData[2].ToString();
                            String ngayBatDau = rowData[3].ToString();
                            String ngayKetThuc = rowData[4].ToString();
                            ThongTinThang info = new ThongTinThang(nam,namChu,thang,ngayBatDau,ngayKetThuc);
                            thongtin.Add(info);
                        }
                    }
                }
            }

            return thongtin;
        }
        public static List<ThongTinThang> layThongTinThangTuResourceBangTenNam(String tenNam)
        {
            String tenFind = tenNam.Trim().ToUpper();
            List<ThongTinThang> thongtin = new List<ThongTinThang>();

            using (var stream = File.Open(PATH_FILE, FileMode.Open, FileAccess.Read))
            {
                // Auto-detect format, supports:
                //  - Binary Excel files (2.0-2003 format; *.xls)
                //  - OpenXml Excel files (2007 format; *.xlsx, *.xlsb)

                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet();
                    var tables = result.Tables.Cast<DataTable>();
                    foreach (DataTable dataTable in tables)
                    {
                        for (int i = 1; i < dataTable.Rows.Count; i++)
                        {
                            var rowData = dataTable.Rows[i].ItemArray;
                            String nam = rowData[0].ToString();
                            String namChu = StringUtil.replaceMoreSpaceAndTrim(rowData[1].ToString());
                            if (tenFind.Equals(namChu.Trim().ToUpper()) == false) continue;
                            String thang = StringUtil.replaceMoreSpaceAndTrim(rowData[2].ToString());
                            String ngayBatDau = StringUtil.replaceMoreSpaceAndTrim(rowData[3].ToString());
                            String ngayKetThuc = StringUtil.replaceMoreSpaceAndTrim(rowData[4].ToString());
                            ThongTinThang info = new ThongTinThang(nam, namChu, thang, ngayBatDau, ngayKetThuc);
                            thongtin.Add(info);
                        }
                    }
                }
            }

            return thongtin;
        }
    }
}
