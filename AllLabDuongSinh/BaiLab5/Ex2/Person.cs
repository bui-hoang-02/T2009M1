namespace AllLabDuongSinh.BaiLab5.Ex2
{
    public abstract class Person
    {
        public string IdentityNumber { get; set; }
        public string FullName { get; set; }
        public double BaseSalary { get; set; } //Lương cơ bản
        public int Skillevel { get; set; } // Dùng để tính thông tin lưu. salary = base 
        public double SeniorLecture { get; set; } // Cộng thêm vào lương
        public double Bouns { get; set; } // Cộng thêm vào lương
    }
}