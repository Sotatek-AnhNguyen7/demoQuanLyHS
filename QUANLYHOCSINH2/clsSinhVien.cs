using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYHOCSINH2
{
    class clsSinhVien
    {
        private string _strMaSinhVien;
        private string _strTenSinhVien;
        private string _strQueQuan;
        private string _strGioiTinh;
        private DateTime _dNgaySinh;
        public string MaSinhVien
        {
            get
            {
                return _strMaSinhVien;
            }
            set
            {
                _strMaSinhVien = value;
            }
        }
        public string TenSinhVien
        {
            get
            {
                return _strTenSinhVien;
            }
            set
            {
                _strTenSinhVien = value;
            }
        }

        public string QueQuan
        {
            get
            {
                return _strQueQuan;
            }
            set
            {
                _strQueQuan = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return _strGioiTinh;
            }
            set
            {
                _strGioiTinh = value;
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return _dNgaySinh;
            }
            set
            {
                _dNgaySinh = value;
            }
        }
        /// <summary>
        /// Tạo mới thể hiện của class SinhVien
        /// </summary>
        /// <param name="strMaSV">Mã sinh viên kiểu dữ liệu string</param>
        /// <param name="strTenSV">Tên sinh viên kiểu dữ liệu string</param>
        /// <param name="strQue">Quê quán kiểu dữ liệu string</param>
        /// <param name="strSex">Giới tính kiểu dữ liệu string</param>
        /// <param name="dNgaySinh">Ngày sinh kiểu dữ liệu DateTime</param>
        public clsSinhVien(string strMaSV, string strTenSV, string strQue, string strSex, DateTime dNgaySinh)
        {
            this._strMaSinhVien = strMaSV;
            this._strTenSinhVien = strTenSV;
            this._strQueQuan = strQue;
            this._strGioiTinh = strSex;
            this._dNgaySinh = dNgaySinh;
        }

        /// <summary>
        /// Tạo mới thể hiện của class SinhVien
        /// </summary>
        /// <param name="strMaSV">Mã sinh viên kiểu dữ liệu string</param>
        /// <param name="strTenSV">Tên sinh viên kiểu dữ liệu string</param> 
        public clsSinhVien(string strMaSV, string strTenSV)
        {
            this._strMaSinhVien = strMaSV;
            this._strTenSinhVien = strTenSV; 
        }

        /// <summary>
        /// Tạo mới thể hiện của class SinhVien(mặc định)
        /// </summary> 
        public clsSinhVien( )
        { 
        }
    }
} 
