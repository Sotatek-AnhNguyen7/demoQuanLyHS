using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYHOCSINH2
{
    class SinhViens
    { 
         
        public clsSinhVien TimSinhVienTheoMa(List<clsSinhVien> arr, string strMa)
        { 
            foreach (clsSinhVien sv in arr)
            {
                if (sv.MaSinhVien == strMa)
                { 
                    return sv; 
                }
            }
            return null;
        }//VaGioiTinh
        public clsSinhVien TimSinhVienTheoMa(List<clsSinhVien> arr, string strMa, string strGioiTinh)
        {
            foreach (clsSinhVien sv in arr)
            {
                if (sv.MaSinhVien == strMa && sv.GioiTinh  == strGioiTinh )
                {
                    return sv;
                }
            }
            return null;
        }

        public List<clsSinhVien> DanhSachSinhVienGioiTinh(List<clsSinhVien> arr, string strGioiTinh)
        {
            List<clsSinhVien> arrResult = new List<clsSinhVien> ();
            foreach (clsSinhVien sv in arr)
            {
                if (sv.GioiTinh == strGioiTinh)
                {
                    arrResult.Add (sv);
                }
            }
            return arrResult;
        }

        public List<clsSinhVien> DanhSachSinhVienTP(List<clsSinhVien> arr, string strQueQuan)
        {
            List<clsSinhVien> arrResult = new List<clsSinhVien>();
            foreach (clsSinhVien sv in arr)
            {
                if (sv.QueQuan.Contains(strQueQuan))
                {
                    arrResult.Add(sv);
                }
            }
            return arrResult;
        }
        public List<clsSinhVien> DanhSachSinhVienTheoMaFor(List<clsSinhVien> arr, string strMa)
        {
            List<clsSinhVien> arrResult = new List<clsSinhVien>();
            for (int i=0;i<arr.Count;i++)
            {
                if (arr[i].MaSinhVien ==strMa  )
                {
                    arrResult.Add(arr[i]);
                }
            }
            return arrResult;
            
        }

    }
    
    
}
