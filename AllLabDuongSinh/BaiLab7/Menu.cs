using System;
using System.Text;

namespace AllLabDuongSinh.BaiLab7
{
    public class Menu
    {
        private EmployeeManager _employeeManager = new EmployeeManager();
        public void menuEmployee()
        {
            while (true)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("|------Chương trình quản lý employee------|");
                Console.WriteLine("|-----------------------------------------|");
                Console.WriteLine("|1: Thêm mới employee.                    |");
                Console.WriteLine("|2: Hiển thi danh sách employee.          |");
                Console.WriteLine("|3: Sửa thông tin employee.               |");
                Console.WriteLine("|4: Xóa thông tin employee.               |");
                Console.WriteLine("|4: Thoát.                                |");
                Console.WriteLine("|-----------------------------------------|");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: 
                        _employeeManager.TaoMoiEmployee();
                        break;
                    case 2:
                        _employeeManager.HienThiDanhSachEmployee();
                        break;
                    case 3:
                        _employeeManager.SuaThongTinEmployee();
                        break;
                    case 4:
                        _employeeManager.XoaThongTinSinhVien();
                        break;
                    case 5:
                        break;
                }
            }
        }
    }
}