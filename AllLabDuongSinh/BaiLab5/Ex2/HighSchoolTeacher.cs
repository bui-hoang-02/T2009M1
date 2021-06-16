namespace AllLabDuongSinh.BaiLab5.Ex2
{
    public class HighSchoolTeacher : Person, IEmployeeAction
    {
       public string HighSchoolTeacherCode { get; set; }

       public double Calculateslary()
       {
           return BaseSalary * Skillevel + SeniorLecture + Bouns;
           throw new System.NotImplementedException();
       }
    }
}