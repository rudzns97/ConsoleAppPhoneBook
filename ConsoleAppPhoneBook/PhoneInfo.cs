using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPhoneBook
{
    public class PhoneInfo
    {
        string name; //필수
        string phoneNumber; //필수
        string birth; //선택

        PhoneBookManager manager = new PhoneBookManager();

        public PhoneInfo(string name, string num)
        {
            //필수 2개
            this.name = name;
            phoneNumber = num;   
        }
        public PhoneInfo(string name, string num, string birth)
        {
            //3개
            this.name = name;
            phoneNumber = num;
            this.birth = birth;
        }

        public void ShowPhoneInfo()
        {
            Console.Write("이름 : "+name+" ");
            Console.Write("전화번호 : " + phoneNumber + " ");
            Console.WriteLine("생일 : " + birth);

        }
        
    }
}
