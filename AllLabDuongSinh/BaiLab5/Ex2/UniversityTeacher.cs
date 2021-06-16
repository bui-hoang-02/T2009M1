namespace AllLabDuongSinh.BaiLab5.Ex2
{
    public class UniversityTeacher: Person, IEmployeeAction
    {
        private IEmployeeAction _employeeActionImplementation;
        public string UniversityTeacherCode { get; set; }
        
        public int EnglishSkillLevel { get; set; } // 1 level tăng thêm 10% lương

        public double CalculateSalary()
        {
            if (SeniorLecture < 60000)
            {
                throw new AmountException("Senior lecture can not get less tham 60,000 salary", FullName);
            }

            if (Bouns > 10000)
            {
                throw new AmountException("Bonus is more than 10,000", FullName);
            }

            return BaseSalary * Skillevel + ((BaseSalary / 10) * EnglishSkillLevel) + SeniorLecture + Bouns;
        }

        public double Calculateslary()
        {
            return _employeeActionImplementation.Calculateslary();
        }
    }
}