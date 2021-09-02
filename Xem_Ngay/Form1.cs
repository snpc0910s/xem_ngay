using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Xem_Ngay.model._64que;
using Xem_Ngay.model.luc_thap_hoa_giap;
using Xem_Ngay.ultility;
using Xem_Ngay.model.hado_lacthu;
using Xem_Ngay.model.son_huong;

namespace Xem_Ngay
{
    public partial class Form1 : Form
    {

        private static List<HoaGiap> saverThang = new List<HoaGiap>();
        private static List<HoaGiap> saverNgay = new List<HoaGiap>();
        private static List<HoaGiap> saverGio = new List<HoaGiap>();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // init ****************************************
            this.initBoldKQQuaiKhiHKDQ();
            this.initWidthGrid();
            this.intitDataSourceExcel();
            // end init ************************************

            // test
            //List<HoaGiap> hoaGiaps = LucThapHoaGiap.layCacHoaGiapTheo1Khoang("bính dần", "canh ngọ");
            //String filter = "bt:Đinh;bd:Thìn,Dần;bk:2;bv:2";
            //String filter = "cq:Đại Tráng,Tổn;bv:2,9;bk:8,2";
            //List<HoaGiap> hoaGiapAfterFilter = LucThapHoaGiap.locListHoaGiapByLogic(hoaGiaps,filter);
            //List<HoaGiapDonGian> hoagiapdongian = LucThapHoaGiap.listHoaGiapToHoaGiapDonGian(hoaGiapAfterFilter);
            //this.updateListHoaGiapDonGianToDataGrid(this.gridNgay, hoagiapdongian);

            //bool check1 = LucThapHoaGiap.checkViTriHoaGiapThoaMan1Khoang("Mậu Thìn","Ất Sửu","Canh Ngọ"); // true
            //bool check2 = LucThapHoaGiap.checkViTriHoaGiapThoaMan1Khoang("Quý Hợi", "Nhâm Tuất", "Bính Dần");
            //bool check3 = LucThapHoaGiap.checkViTriHoaGiapThoaMan1Khoang("", "", "");

            //int[,] lacthuSo = LacThu.tao1LacThuSoCuaNam(2022);
            //String loging = LacThu.hienThiTheoLacThuSo(lacthuSo);
            //this.logNam.AppendText(loging);
            //String statusNguHoang = LacThu.timNguHoangDuaVaoNam(2021);
            //this.logNam.AppendText(statusNguHoang);

        }
        // init some thing
        public void initBoldKQQuaiKhiHKDQ() {
            Font fontQuai = new Font("Arial", 12, FontStyle.Bold);
            // nam
            this.kqNamQuaiKhi.Font = fontQuai;
            this.kqNamVanKhi.Font = fontQuai;
            // thang
            this.kqThangQuaiKhi.Font = fontQuai;
            this.kqThangVanKhi.Font = fontQuai;
            // ngay
            this.kqNgayQuaiKhi.Font = fontQuai;
            this.kqNgayVanKhi.Font = fontQuai;
            // gio
            this.kqGioQuaiKhi.Font = fontQuai;
            this.kqGioVanKhi.Font = fontQuai;
            // toa
            this.kqToaQuaiKhi.Font = fontQuai;
            this.kqToaVanKhi.Font = fontQuai;
            // gia chu1 
            this.kqGC1QuaiKhi.Font = fontQuai;
            this.kqGC1VanKhi.Font = fontQuai;
            // gia chu 2
            this.kqGC2QuaiKhi.Font = fontQuai;
            this.kqGC2VanKhi.Font = fontQuai;
        }
        private void initWidthGrid()
        {
            this.setGirdViewTimeShow(this.gridNam);
            this.setGirdViewTimeShow(this.gridThang);
            this.setGirdViewTimeShow(this.gridNgay);
            this.setGirdViewTimeShow(this.gridGio);
            this.setGirdViewTimeShow(this.gridToa);
            this.setGirdViewTimeShow(this.gridGC1);
            this.setGirdViewTimeShow(this.gridGC2);
        }
        
        private void intitDataSourceExcel()
        {
            //List<ThongTinThang> thongtins = DocGioiHanThangTrongNamExcel.layThongTinThangTuResource();
        }
        // tìm kiếm
        private void btnTimNam_Click(object sender, EventArgs e)
        {
            String input = StringUtil.replaceMoreSpaceAndTrim(this.txtNam.Text);
            if (input.Equals("")) return;
            List<HoaGiap> hoaGiaps = null;
            // detect Nam
            if (RegexUtil.laNam(input))
            {
                HoaGiap hoaGiapTimDuoc = LucThapHoaGiap.timHoaGiapTheoNam(Convert.ToInt32(input));
                List<HoaGiap> lTemp = new List<HoaGiap>();
                lTemp.Add(hoaGiapTimDuoc);
                hoaGiaps = lTemp;
            }
            else
            {
                hoaGiaps = LucThapHoaGiap.timHoaGiapByTen(input);
            }
            if (hoaGiaps == null) return;
            List<HoaGiapDonGian> hoagiapdongian = LucThapHoaGiap.listHoaGiapToHoaGiapDonGian(hoaGiaps);
            this.updateListHoaGiapDonGianToDataGrid(this.gridNam, hoagiapdongian);
            // reset trụ tháng
            this.resetCotThang();
        }

        private void btnTimThang_Click(object sender, EventArgs e)
        {
            String input = StringUtil.replaceMoreSpaceAndTrim(this.txtThang.Text);
            if (input.Equals("")) return;
            List<HoaGiap> hoaGiaps = LucThapHoaGiap.locListHoaGiapByLogic(saverThang, input); // loc
            List<HoaGiapDonGian> hoagiapdongian = LucThapHoaGiap.listHoaGiapToHoaGiapDonGian(hoaGiaps);
            this.updateListHoaGiapDonGianToDataGrid(this.gridThang, hoagiapdongian);
        }
        private void btnTimNgay_Click(object sender, EventArgs e)
        {
            String input = this.txtNgay.Text.ToLower().Trim();
            if (input.Equals("")) return;
            // chỉ có ngày mới được phép được search trong 64 quẻ không phụ thuộc vào tháng
            // bình thường sẽ click chọn ngày thì mới gen ra tháng. nhưng ở đây là đặc biệt được phép chọn ngày trước rồi quyết định chọn tháng sau
            // không được chọn tháng trước
            Map<String, List<String>> logic = HoaGiap.chuyenStringToMapLogic(input);
            List<HoaGiap> hoaGiaps = null;
            // chỉ cần tồn tại 1 trong các key sau thì sẽ ưu tiên số 1 bỏ qua các cái khác
            //if (logic.ContainsKey("s64"))
            //{   // s64 là search trong 64 quẻ
            //    List<String> listSearch = logic.get("s64");
            //    // hiện tại không phát triển tính năng search trong 64 quẻ
            //}
            if (logic.ContainsKey("s60"))
            {   // s64 là search trong 60 hoa giáp muốn chọn ngày trước rồi gợi ý ngược lại tháng thôi
                List<String> listSearch = logic.get("s60");
                hoaGiaps = LucThapHoaGiap.timHoaGiapThuoc1ListTen(listSearch);
            }
            // lọc như bình thường. nếu không tồn tại các key trên
            if (logic.ContainsKey("s64") == false && logic.ContainsKey("s60") == false)
            {
                hoaGiaps = LucThapHoaGiap.locListHoaGiapByMapLogic(saverNgay, logic); // loc
            }
            if (hoaGiaps == null) hoaGiaps  = new List<HoaGiap>(); // rỗng
            List<HoaGiapDonGian> hoagiapdongian = LucThapHoaGiap.listHoaGiapToHoaGiapDonGian(hoaGiaps);
            this.updateListHoaGiapDonGianToDataGrid(this.gridNgay, hoagiapdongian);
            // reset trụ giờ
            this.resetCotGio();
        }

        private void btnTimGio_Click(object sender, EventArgs e)
        {
            String input = this.txtGio.Text.ToLower().Trim();
            if (input.Equals("")) return;
            List<HoaGiap> hoaGiaps = LucThapHoaGiap.locListHoaGiapByLogic(saverGio, input); // loc
            List<HoaGiapDonGian> hoagiapdongian = LucThapHoaGiap.listHoaGiapToHoaGiapDonGian(hoaGiaps);
            this.updateListHoaGiapDonGianToDataGrid(this.gridGio, hoagiapdongian);
            this.updateMauSacNgayVaDem(); // màu sắc ngày và đêm
        }

        private void btnTimToa_Click(object sender, EventArgs e)
        {
            String input = StringUtil.replaceMoreSpaceAndTrim(this.txtToa.Text);
            if (input.Equals("")) return;
            List<HoaGiap> hoaGiaps = LucThapHoaGiap.timHoaGiapByTen(input);
            List<HoaGiapDonGian> hoagiapdongian = LucThapHoaGiap.listHoaGiapToHoaGiapDonGian(hoaGiaps);
            this.updateListHoaGiapDonGianToDataGrid(this.gridToa, hoagiapdongian);
        }

        private void btnTimGC1_Click(object sender, EventArgs e)
        {
            String input = StringUtil.replaceMoreSpaceAndTrim(this.txtGC1.Text);
            if (input.Equals("")) return;
            List<HoaGiap> hoaGiaps = null;
            // detect Nam
            if (RegexUtil.laNam(input))
            {
                HoaGiap hoaGiapTimDuoc = LucThapHoaGiap.timHoaGiapTheoNam(Convert.ToInt32(input));
                List<HoaGiap> lTemp = new List<HoaGiap>();
                lTemp.Add(hoaGiapTimDuoc);
                hoaGiaps = lTemp;
            }
            else
            {
                hoaGiaps = LucThapHoaGiap.timHoaGiapByTen(input);
            }
            if (hoaGiaps == null) return;
            List<HoaGiapDonGian> hoagiapdongian = LucThapHoaGiap.listHoaGiapToHoaGiapDonGian(hoaGiaps);
            this.updateListHoaGiapDonGianToDataGrid(this.gridGC1, hoagiapdongian);
        }

        private void btnTimGC2_Click(object sender, EventArgs e)
        {
            String input = StringUtil.replaceMoreSpaceAndTrim(this.txtGC2.Text);
            if (input.Equals("")) return;
            List<HoaGiap> hoaGiaps = null;
            // detect Nam
            if (RegexUtil.laNam(input))
            {
                HoaGiap hoaGiapTimDuoc = LucThapHoaGiap.timHoaGiapTheoNam(Convert.ToInt32(input));
                List<HoaGiap> lTemp = new List<HoaGiap>();
                lTemp.Add(hoaGiapTimDuoc);
                hoaGiaps = lTemp;
            }
            else
            {
                hoaGiaps = LucThapHoaGiap.timHoaGiapByTen(input);
            }
            if (hoaGiaps == null) return;
            List<HoaGiapDonGian> hoagiapdongian = LucThapHoaGiap.listHoaGiapToHoaGiapDonGian(hoaGiaps);
            this.updateListHoaGiapDonGianToDataGrid(this.gridGC2, hoagiapdongian);
        }

        // chỉnh màu ngũ hành tìm kiếm
        private void updateListHoaGiapDonGianToDataGrid(DataGridView grid, List<HoaGiapDonGian> hoagiapdongian)
        {
            grid.Rows.Clear();
            foreach (HoaGiapDonGian dongian in hoagiapdongian)
            {
                grid.Rows.Add(dongian.quaiKhi, dongian.tenQue, dongian.quaiVan, dongian.tenHoaGiap);
            }
            updateColorNguHanhGridView(grid);
            grid.Rows[0].Selected = false;
        }
        private void updateColorNguHanhGridView(DataGridView grid)
        {
            int allRow = grid.Rows.Count;
            for(int i = 0; i < allRow-1; i++)
            {
                // update quai khi
                String valueCell = grid.Rows[i].Cells[0].Value.ToString(); // cot quai khi
                Color c = this.mauSacTheoHKDQQuaiKhiString(valueCell);
                grid.Rows[i].Cells[0].Style.ForeColor = c;

                // quai van
                String valueCell2 = grid.Rows[i].Cells[2].Value.ToString(); // cot quai van
                Color c2 = this.mauSacTheoHKDQQuaiKhiString(valueCell2);
                grid.Rows[i].Cells[2].Style.ForeColor = c2;

            }
        }
        // update ngày và đêm của ngày
        private void updateMauSacNgayVaDem()
        {
            int allRow = this.gridGio.Rows.Count;
            for (int i = 0; i < allRow - 1; i++)
            {
                String valueCell = this.gridGio.Rows[i].Cells[3].Value.ToString(); // cot hoa giap
                if(valueCell.IndexOf("Mão") > -1 || valueCell.IndexOf("Dậu") > -1) 
                       this.gridGio.Rows[i].Cells[1].Style.BackColor = Color.DarkGray;
                if (valueCell.IndexOf("Tuất") > -1 || 
                    valueCell.IndexOf("Hợi") > -1 || 
                    valueCell.IndexOf("Tý") > -1 || 
                    valueCell.IndexOf("Sửu") > -1 || 
                    valueCell.IndexOf("Dần") > -1)
                {
                    this.gridGio.Rows[i].Cells[1].Style.BackColor = Color.Gray;
                }
            }
        }
        public void resetMauThang()
        {
            int allRow = this.gridThang.Rows.Count;
            for (int i = 0; i < allRow - 1; i++)
            {
                this.gridThang.Rows[i].Cells[1].Style.BackColor = Color.White;
            }
        }
        // end tìm kiếm

        // update line ket qua
        private void updateKetQuaNam(HoaGiapDonGian dongian) {
            this.kqNamHoaGiap.Text = dongian.tenHoaGiap;
            this.kqNamQuaiKhi.Text = dongian.quaiKhi+"";
            this.kqNamQuaiKhi.ForeColor = this.mauSacTheoHKDQ(dongian.quaiKhi);
            this.kqNamQue.Text = dongian.tenQue;
            this.kqNamVanKhi.Text = dongian.quaiVan + "";
            this.kqNamVanKhi.ForeColor = this.mauSacTheoHKDQ(dongian.quaiVan);
            Que que =  AllQueDich.MAPPING_TEN_QUE_VS_QUE.get(dongian.tenQue);
            if (que.isPhuMauQue())
            {
                if (que.layAmDuongQue() == true) this.kqNamStatus.Text = "quẻ Dương";
                else this.kqNamStatus.Text = "quẻ Âm";
            }else
            {
                this.kqNamStatus.Text = "--";
            }
        }
        private void updateKetQuaThang(HoaGiapDonGian dongian)
        {
            this.kqThangHoaGiap.Text = dongian.tenHoaGiap;
            this.kqThangQuaiKhi.Text = dongian.quaiKhi + "";
            this.kqThangQuaiKhi.ForeColor = this.mauSacTheoHKDQ(dongian.quaiKhi);
            this.kqThangQue.Text = dongian.tenQue;
            this.kqThangVanKhi.Text = dongian.quaiVan + "";
            this.kqThangVanKhi.ForeColor = this.mauSacTheoHKDQ(dongian.quaiVan);
            Que que = AllQueDich.MAPPING_TEN_QUE_VS_QUE.get(dongian.tenQue);
            if (que.isPhuMauQue())
            {
                if (que.layAmDuongQue() == true) this.kqThangStatus.Text = "quẻ Dương";
                else this.kqThangStatus.Text = "quẻ Âm";
            }
            else
            {
                this.kqThangStatus.Text = "--";
            }
        }
        private void updateKetQuaNgay(HoaGiapDonGian dongian)
        {
            this.kqNgayHoaGiap.Text = dongian.tenHoaGiap;
            this.kqNgayQuaiKhi.Text = dongian.quaiKhi + "";
            this.kqNgayQuaiKhi.ForeColor = this.mauSacTheoHKDQ(dongian.quaiKhi);
            this.kqNgayQue.Text = dongian.tenQue;
            this.kqNgayVanKhi.Text = dongian.quaiVan + "";
            this.kqNgayVanKhi.ForeColor = this.mauSacTheoHKDQ(dongian.quaiVan);
            Que que = AllQueDich.MAPPING_TEN_QUE_VS_QUE.get(dongian.tenQue);
            if (que.isPhuMauQue())
            {
                if (que.layAmDuongQue() == true) this.kqNgayStatus.Text = "quẻ Dương";
                else this.kqNgayStatus.Text = "quẻ Âm";
            }
            else
            {
                this.kqNgayStatus.Text = "--";
            }
        }
        private void updateKetQuaGio(HoaGiapDonGian dongian)
        {
            this.kqGioHoaGiap.Text = dongian.tenHoaGiap;
            this.kqGioQuaiKhi.Text = dongian.quaiKhi + "";
            this.kqGioQuaiKhi.ForeColor = this.mauSacTheoHKDQ(dongian.quaiKhi);
            this.kqGioQue.Text = dongian.tenQue;
            this.kqGioVanKhi.Text = dongian.quaiVan + "";
            this.kqGioVanKhi.ForeColor = this.mauSacTheoHKDQ(dongian.quaiVan);
            Que que = AllQueDich.MAPPING_TEN_QUE_VS_QUE.get(dongian.tenQue);
            if (que.isPhuMauQue())
            {
                if (que.layAmDuongQue() == true) this.kqGioStatus.Text = "quẻ Dương";
                else this.kqGioStatus.Text = "quẻ Âm";
            }
            else
            {
                this.kqGioStatus.Text = "--";
            }
        }
        private void updateKetQuaToa(HoaGiapDonGian dongian)
        {
            this.kqToaHoaGiap.Text = dongian.tenHoaGiap;
            this.kqToaQuaiKhi.Text = dongian.quaiKhi + "";
            this.kqToaQuaiKhi.ForeColor = this.mauSacTheoHKDQ(dongian.quaiKhi);
            this.kqToaQue.Text = dongian.tenQue;
            this.kqToaVanKhi.Text = dongian.quaiVan + "";
            this.kqToaVanKhi.ForeColor = this.mauSacTheoHKDQ(dongian.quaiVan);
            Que que = AllQueDich.MAPPING_TEN_QUE_VS_QUE.get(dongian.tenQue);
            if (que.isPhuMauQue())
            {
                if (que.layAmDuongQue() == true) this.kqToaStatus.Text = "quẻ Dương";
                else this.kqToaStatus.Text = "quẻ Âm";
            }
            else
            {
                this.kqToaStatus.Text = "--";
            }
        }
        private void updateKetQuaGC1(HoaGiapDonGian dongian)
        {
            this.kqGC1HoaGiap.Text = dongian.tenHoaGiap;
            this.kqGC1QuaiKhi.Text = dongian.quaiKhi + "";
            this.kqGC1QuaiKhi.ForeColor = this.mauSacTheoHKDQ(dongian.quaiKhi);
            this.kqGC1Que.Text = dongian.tenQue;
            this.kqGC1VanKhi.Text = dongian.quaiVan + "";
            this.kqGC1VanKhi.ForeColor = this.mauSacTheoHKDQ(dongian.quaiVan);
            Que que = AllQueDich.MAPPING_TEN_QUE_VS_QUE.get(dongian.tenQue);
            if (que.isPhuMauQue())
            {
                if (que.layAmDuongQue() == true) this.kqGC1Status.Text = "quẻ Dương";
                else this.kqGC1Status.Text = "quẻ Âm";
            }
            else
            {
                this.kqGC1Status.Text = "--";
            }
        }
        private void updateKetQuaGC2(HoaGiapDonGian dongian)
        {
            this.kqGC2HoaGiap.Text = dongian.tenHoaGiap;
            this.kqGC2QuaiKhi.Text = dongian.quaiKhi + "";
            this.kqGC2QuaiKhi.ForeColor = this.mauSacTheoHKDQ(dongian.quaiKhi);
            this.kqGC2Que.Text = dongian.tenQue;
            this.kqGC2VanKhi.Text = dongian.quaiVan + "";
            this.kqGC2VanKhi.ForeColor = this.mauSacTheoHKDQ(dongian.quaiVan);
            Que que = AllQueDich.MAPPING_TEN_QUE_VS_QUE.get(dongian.tenQue);
            if (que.isPhuMauQue())
            {
                if (que.layAmDuongQue() == true) this.kqGC2Status.Text = "quẻ Dương";
                else this.kqGC2Status.Text = "quẻ Âm";
            }
            else
            {
                this.kqGC2Status.Text = "--";
            }
        }
        
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

 
        // choose update to ket qua *****************************************************************
        private void gridNam_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            HoaGiapDonGian newHoaGiap = this.layHoaGiapDonGianRowIndex(this.gridNam, rowIndex);
            if (newHoaGiap == null) return; // error when click empty line
            updateKetQuaNam(newHoaGiap);
            // update Tháng theo năm
            HoaGiap hoaGiapFind = LucThapHoaGiap.timChinhXacDauTien(newHoaGiap.tenHoaGiap);
            List<HoaGiap> hoaGiaps = hoaGiapFind.lay12Thang();
            // lưu lại các tháng khi chọn năm
            saverThang = hoaGiaps;
            List<HoaGiapDonGian> hoagiapdongian = LucThapHoaGiap.listHoaGiapToHoaGiapDonGian(hoaGiaps);
            this.updateListHoaGiapDonGianToDataGrid(this.gridThang, hoagiapdongian);
        }

        private void gridThang_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            HoaGiapDonGian newHoaGiap = this.layHoaGiapDonGianRowIndex(this.gridThang, rowIndex);
            if (newHoaGiap == null) return; // error when click empty line
            updateKetQuaThang(newHoaGiap);
            // update ngày theo tháng theo năm
            String layNamChonHienTai = this.kqNamHoaGiap.Text;
            String layThangChonHienTai = newHoaGiap.tenHoaGiap;
            List<HoaGiap> hoaGiaps = LucThapHoaGiap.layNgayTrongThangTrongNam(layNamChonHienTai,layThangChonHienTai);
            // lưu lại các ngày
            saverNgay = hoaGiaps;
            List<HoaGiapDonGian> hoagiapdongian = LucThapHoaGiap.listHoaGiapToHoaGiapDonGian(hoaGiaps);
            this.updateListHoaGiapDonGianToDataGrid(this.gridNgay, hoagiapdongian);
        }
        private void gridNgay_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            HoaGiapDonGian newHoaGiap = this.layHoaGiapDonGianRowIndex(this.gridNgay, rowIndex);
            if (newHoaGiap == null) return; // error when click empty line
            updateKetQuaNgay(newHoaGiap);
            // update Giờ theo ngày
            HoaGiap hoaGiapFind = LucThapHoaGiap.timChinhXacDauTien(newHoaGiap.tenHoaGiap);
            List<HoaGiap> hoaGiaps = hoaGiapFind.lay12Gio();
            // lưu lại các tháng khi chọn năm
            saverGio = hoaGiaps;
            List<HoaGiapDonGian> hoagiapdongian = LucThapHoaGiap.listHoaGiapToHoaGiapDonGian(hoaGiaps);
            this.updateListHoaGiapDonGianToDataGrid(this.gridGio, hoagiapdongian);
            this.updateMauSacNgayVaDem(); // màu sắc ngày và đêm của giờ
            this.resetMauThang(); // reset chonj mau thang
        }

        private void gridGio_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            HoaGiapDonGian newHoaGiap = this.layHoaGiapDonGianRowIndex(this.gridGio, rowIndex);
            if (newHoaGiap == null) return; // error when click empty line
            updateKetQuaGio(newHoaGiap);
        }

        private void gridToa_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            HoaGiapDonGian newHoaGiap = this.layHoaGiapDonGianRowIndex(this.gridToa, rowIndex);
            if (newHoaGiap == null) return; // error when click empty line
            updateKetQuaToa(newHoaGiap);
        }

        private void gridGC1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            HoaGiapDonGian newHoaGiap = this.layHoaGiapDonGianRowIndex(this.gridGC1, rowIndex);
            if (newHoaGiap == null) return; // error when click empty line
            updateKetQuaGC1(newHoaGiap);
        }

        private void gridGC2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            HoaGiapDonGian newHoaGiap = this.layHoaGiapDonGianRowIndex(this.gridGC2, rowIndex);
            if (newHoaGiap == null) return; // error when click empty line
            updateKetQuaGC2(newHoaGiap);
        }
        private HoaGiapDonGian layHoaGiapDonGianRowIndex(DataGridView gird , int rowIndex) {
            if (gird.Rows[rowIndex].Cells[0].Value == null) return null;
            int quaiKhi = Int32.Parse(gird.Rows[rowIndex].Cells[0].Value.ToString());
            String tenQue = gird.Rows[rowIndex].Cells[1].Value.ToString();
            int quaiVan = Int32.Parse(gird.Rows[rowIndex].Cells[2].Value.ToString());
            String tenHoaGiap = gird.Rows[rowIndex].Cells[3].Value.ToString();
            return new HoaGiapDonGian(tenHoaGiap, quaiKhi, tenQue, quaiVan);
        }
        // reset các cột của kết quả 
        private void resetCotNam()
        {
            this.kqNamHoaGiap.Text = "--";
            this.kqNamQuaiKhi.Text = "--";
            this.kqNamQue.Text = "--";
            this.kqNamVanKhi.Text = "--";
        }
        private void resetCotThang()
        {
            this.kqThangHoaGiap.Text = "--";
            this.kqThangQuaiKhi.Text = "--";
            this.kqThangQue.Text = "--";
            this.kqThangVanKhi.Text = "--";
        }
        private void resetCotNgay()
        {
            this.kqNgayHoaGiap.Text = "--";
            this.kqNgayQuaiKhi.Text = "--";
            this.kqNgayQue.Text = "--";
            this.kqNgayVanKhi.Text = "--";
        }
        private void resetCotGio()
        {
            this.kqGioHoaGiap.Text = "--";
            this.kqGioQuaiKhi.Text = "--";
            this.kqGioQue.Text = "--";
            this.kqGioVanKhi.Text = "--";
        }
        public void resetCotToa()
        {
            this.kqToaHoaGiap.Text = "--";
            this.kqToaQuaiKhi.Text = "--";
            this.kqToaQue.Text = "--";
            this.kqToaVanKhi.Text = "--";
        }
        public void resetCotGC1()
        {
            this.kqGC1HoaGiap.Text = "--";
            this.kqGC1QuaiKhi.Text = "--";
            this.kqGC1Que.Text = "--";
            this.kqGC1VanKhi.Text = "--";
        }
        public void resetCotGC2()
        {
            this.kqGC2HoaGiap.Text = "--";
            this.kqGC2QuaiKhi.Text = "--";
            this.kqGC2Que.Text = "--";
            this.kqGC2VanKhi.Text = "--";
        }

        // end choose update to ket qua *****************************************************************
        // khac
        private Color mauSacTheoHKDQ(int quaiKhi)
        {
            if (quaiKhi == 4 || quaiKhi == 9) return Color.Gray;
            if (quaiKhi == 3 || quaiKhi == 8) return Color.Green;
            if (quaiKhi == 2 || quaiKhi == 7) return Color.Red;
            if (quaiKhi == 1 || quaiKhi == 6) return Color.Black;
            return Color.Orange;
        }
        private Color mauSacTheoHKDQQuaiKhiString(String squaiKhi)
        {
            int quaiKhi = Int32.Parse(squaiKhi);
            if (quaiKhi == 4 || quaiKhi == 9) return Color.Gray;
            if (quaiKhi == 3 || quaiKhi == 8) return Color.Green;
            if (quaiKhi == 2 || quaiKhi == 7) return Color.Red;
            if (quaiKhi == 1 || quaiKhi == 6) return Color.Black;
            return Color.Orange;
        }
        private void setGirdViewTimeShow(DataGridView grid)
        {
            grid.Columns[0].Width = 36;
            grid.Columns[1].Width = 120;
            grid.Columns[2].Width = 36;
            grid.Columns[3].Width = 64;
        }
        //action label reset kq ----------------------------
        private void resetNam_Click(object sender, EventArgs e)
        {
            this.resetCotNam();
        }

        private void resetThang_Click(object sender, EventArgs e)
        {
            this.resetCotThang();
        }

        private void resetNgay_Click(object sender, EventArgs e)
        {
            this.resetCotNgay();
        }

        private void resetGio_Click(object sender, EventArgs e)
        {
            this.resetCotGio();
        }

        private void resetToa_Click(object sender, EventArgs e)
        {
            this.resetCotToa();
        }

        private void resetGC1_Click(object sender, EventArgs e)
        {
            this.resetCotGC1();
        }

        private void resetGC2_Click(object sender, EventArgs e)
        {
            this.resetCotGC2();
        }
        // tìm tháng từ ngày phục vụ cho việc tìm ngày rồi mới tìm tháng
        private void btnTimThangTuNgay_Click(object sender, EventArgs e)
        {
            String tenHoaGiapNam = this.kqNamHoaGiap.Text;
            String tenHoaGiapNgay = this.kqNgayHoaGiap.Text;
            if(tenHoaGiapNam.Equals("--") || tenHoaGiapNgay.Equals("--"))
            {
                // show dialog thông báo
                return;
            }else
            {
                List<String> listThangTimDuoc = LucThapHoaGiap.timNhungThangThoaMan1HoaGiap(tenHoaGiapNgay,tenHoaGiapNam);
                this.boiMauThangThoaManNgayTrongNam(listThangTimDuoc);
            }
        }
        // bôi màu tháng thoả mãn ngày và năm
        private void boiMauThangThoaManNgayTrongNam(List<String> listThangTimDuoc)
        {
            int allRow = this.gridThang.Rows.Count;
            for (int i = 0; i < allRow - 1; i++)
            {
                String valueCell = this.gridThang.Rows[i].Cells[3].Value.ToString(); // cot hoa giap
                bool keyActive = false;
                foreach(String tenThang in listThangTimDuoc)
                {
                    if(valueCell.IndexOf(tenThang) > -1)
                    {
                        keyActive = true;
                        break;
                    }
                }
                if(keyActive == true)
                {
                    // bôi màu
                    this.gridThang.Rows[i].Cells[1].Style.BackColor = Color.LightGreen;
                }
                else
                {
                    // không bôi màu
                    this.gridThang.Rows[i].Cells[1].Style.BackColor = Color.White;
                }
            }
        }
    }
}
