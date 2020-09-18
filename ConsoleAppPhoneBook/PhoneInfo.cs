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
            this.Name = name;
            phoneNumber = num;
        }
        public PhoneInfo(string name, string num, string birth)
        {
            //3개
            this.Name = name;
            phoneNumber = num;
            this.birth = birth;
        }

        public string Name { get => name; set => name = value; }

        public virtual void ShowPhoneInfo()
        {
            Console.Write("이름 : " + Name + " ");
            Console.Write("전화번호 : " + phoneNumber + " ");
            Console.WriteLine("생일 : " + birth);

        }
        //ToString()을 override해서 PhoneUnivInfo에서 사용해 보기
    }

    public class PhoneUnivInfo : PhoneInfo
    {
        string major;
        int year;

        public PhoneUnivInfo(string name, string phoneNumber, string major, int year) : base(name, phoneNumber)
        {
            this.major = major;
            this.year = year;
        }

        public override void ShowPhoneInfo()
        {
            base.ShowPhoneInfo();
        }
    }
    public class PhoneCompanyInfo : PhoneInfo
    {
        string company;
        public PhoneCompanyInfo(string name, string num, string company) : base(name, num)
        {
            this.company = company;
        }

        public override void ShowPhoneInfo()
        {
            base.ShowPhoneInfo();
        }
        //public void


    } 
}
