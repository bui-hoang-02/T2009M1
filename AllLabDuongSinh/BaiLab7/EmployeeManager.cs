using System;
using System.Collections.Generic;
using System.Text;

namespace AllLabDuongSinh.BaiLab7
{
    public class EmployeeManager
    {
        private List<Employee> _listEmployee = new List<Employee>();
        
        public void TaoMoiEmployee()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Vui lòng nhập thông tin sinh viên.");
            Console.WriteLine("Nhập name employee.");
            Employee employee = new Employee();
            var nameEmployee = Console.ReadLine();
            employee.name = nameEmployee;
            Console.WriteLine("Nhập age employee.");
            var ageEmployee = int.Parse(Console.ReadLine());
            employee.age = ageEmployee;
            Console.WriteLine("Nhập salary employee.");
            var salaryEmployee = int.Parse(Console.ReadLine());
            employee.salary = salaryEmployee;
            _listEmployee.Add(employee);
        }
        
        public void HienThiDanhSachEmployee()
        {
            Console.WriteLine("Thông tin employee vừa nhập là: ");
            for (int i = 0; i < _listEmployee.Count; i++)
            {
                var employee = _listEmployee[i];
                Console.WriteLine($"Name: {employee.name}, age: {employee.age}, salary: {employee.salary}");
            }
        }
        
        public void SuaThongTinEmployee()
        {
            Console.WriteLine("Nhập name employee cần sửa.");
            var name = Console.ReadLine();
            Employee employee = null;
            for (int i = 0; i < _listEmployee.Count; i++)
            {
                var eml = _listEmployee[i];
                if (eml.name == name)
                {
                    employee = _listEmployee[i];
                    break;
                }
            }

            if (employee == null)
            {
                Console.WriteLine("Không tìm thấy name employee cần sửa. Stop.");
                return;
            }
            Console.WriteLine("Vui lòng nhập họ sinh viên cần update");
            var ageEmployee = int.Parse(Console.ReadLine());
            employee.age = ageEmployee;
            Console.WriteLine("Vui lòng nhập tên sinh viên cần update");
            var salaryEmployee = int.Parse(Console.ReadLine());
            employee.salary = salaryEmployee;
        }
        
        public void XoaThongTinSinhVien()
        {
            Console.WriteLine("Nhập name employee cần xóa.");
            var nameEmployee = Console.ReadLine();
            var index = -1;
            for (int i = 0; i < _listEmployee.Count; i++)
            {
                var emp2 = _listEmployee[i];
                if (emp2.name == nameEmployee)
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
            {
                Console.WriteLine("Không tìm thấy sinh viên.");
                return;
            }
            _listEmployee.RemoveAt(index);
            Console.WriteLine("Xóa thành công.");
        }
    }
}