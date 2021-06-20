using System;
using System.Text;

namespace AllLabDuongSinh.BaiLab2
{
    public class Lab2Ex1
    {
        public void BaoHienXaHoi()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var sin = "193456787";
            if (sin.Length != 9)
            {
                Console.WriteLine("Sin number phải là 9 chữ số.");
                return;
            }
            
            var splitted = sin.ToCharArray();
            var sinInNumbers = new int[9];
            for (int i = 0; i < splitted.Length; i++)
            {
                sinInNumbers[i] = int.Parse(splitted[i].ToString());
            }

            var tongSoHangChan = 0;
            var tongSoHangLe = 0;
            for (int i = 0; i < sinInNumbers.Length -1; i++)
            {
                if (i % 2 == 0)
                {
                    tongSoHangLe += sinInNumbers[i];
                }
                else
                {
                    var temp = (sinInNumbers[i] * 2).ToString().ToCharArray();
                    for (int j = 0; j < temp.Length; j ++)
                    {
                        tongSoHangChan += Convert.ToInt32(temp[j].ToString());
                    }
                }
            }

            var sum = tongSoHangChan + tongSoHangLe;
            if ((sum + sinInNumbers[sinInNumbers.Length - 1]) % 10 == 0)
            {
                Console.WriteLine("This it a valid sin");
            }
            else
            {
                Console.WriteLine("err");
            }

        }
    }
}