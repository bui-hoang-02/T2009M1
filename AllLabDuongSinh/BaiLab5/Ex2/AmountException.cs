using System;

namespace AllLabDuongSinh.BaiLab5.Ex2
{
    public class AmountException : Exception
    {
        private string _personName;
        private string _message;

        public AmountException()
        {
            
        }

        public AmountException(string message, string personName)
        {
            this._personName = personName;
            this._personName = message;
            PrintError();
        }

        private void PrintError()
        {
            Console.Error.WriteLine($"Amount exception with person {_personName}, {_message}");
        }
    }
}