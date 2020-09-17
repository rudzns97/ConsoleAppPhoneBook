using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPhoneBook
{
    public class PhoneBookManager
    {
        const int MAX_CNT = 100; //const = 상수/ 상수만 바꾸면 
        PhoneInfo[] infoStorage = new PhoneInfo[MAX_CNT];
        int curCnt = 0;

        public void ShowMenu()
        {
            //AccountManager 참조
            Console.WriteLine("--------------- 주소록 ---------------");
            Console.WriteLine("1.입력 | 2.목록 | 3.검색 | 4.삭제 | 5.종료");
            Console.WriteLine("--------------------------------------");
            Console.Write("선택 : ");
        }

        public void InputData()
        {
            //입력
            
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            if(name.Length < 1)
            {
                Console.WriteLine("이름을 입력하세요");
                return;
            }
            Console.Write("번호 입력 : ");
            string num = Console.ReadLine();
            if (num.Length < 1)
            {
                Console.WriteLine("전화번호를 입력하세요");
                return;
            }
            
            Console.Write("생일 입력 : ");
            string birth = Console.ReadLine();
            if (birth.Length < 1)
            {
                infoStorage[curCnt] = new PhoneInfo(name, num);
            }
            else
            {
                infoStorage[curCnt] = new PhoneInfo(name, num, birth);
            }
            curCnt++;

        }
        public void ListData()
        {
            //목록
            for(int i=0; i < curCnt; i++)
            {
                infoStorage[i].ShowPhoneInfo();
            }
        }
        public void SearchData()
        {
            //검색
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();

        }
        public void DeleteData()
        {
            //삭제
            Console.Write("이름 입력");
            string name = Console.ReadLine();

        }
    }
}
