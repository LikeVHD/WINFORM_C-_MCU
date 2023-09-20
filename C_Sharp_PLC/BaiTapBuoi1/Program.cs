using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Yêu cầu người dùng nhập năm sinh
            Console.Write("Nhập năm sinh của bạn: ");

            // Đọc và chuyển đổi chuỗi nhập từ bàn phím thành số nguyên
            int namSinh;
            if (int.TryParse(Console.ReadLine(), out namSinh))
            {
                // Lấy năm hiện tại
                int namHienTai = DateTime.Now.Year;

                // Tính tuổi
                int tuoi = namHienTai - namSinh;

                // Hiển thị kết quả
                Console.WriteLine($"Tuổi của bạn là {tuoi} tuổi.");
            }
            else
            {
                Console.WriteLine("Nhập không hợp lệ. Vui lòng nhập lại năm sinh là một số nguyên.");
            }
            Console.ReadKey();
        }
    }
}
