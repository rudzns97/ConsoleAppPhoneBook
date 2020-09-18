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
        int PhoneUnivInfoCnt = 0;
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
            Console.WriteLine("1번.일반 2.대학 3.회사");
            Console.Write("선택 >> ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("이름 : ");
            string name = Console.ReadLine().Trim();
            //if(name.Length < 1)
            if (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("이름을 입력하세요");
                return;
            }
            else
            {
                int dataIdx = SearchName(name);
                if (dataIdx > -1)
                {
                    Console.WriteLine("이미 등록된 이름입니다. 다른 이름으로 입력하세요.");
                    return;
                }
            }

            Console.Write("번호 입력 : ");
            string num = Console.ReadLine().Trim();
            if (string.IsNullOrEmpty(num))
            {
                Console.WriteLine("전화번호를 입력하세요");
                return;
            }

            Console.Write("생일 입력 : ");
            string birth = Console.ReadLine();
            if (choice == 1)
            {
                if (birth.Length < 1)
                {
                    infoStorage[curCnt++] = new PhoneInfo(name, num);
                }
                else
                {
                    infoStorage[curCnt++] = new PhoneInfo(name, num, birth);
                }
            }
            else if (choice == 2)
            {
                
            }
            else
            {

            }


        }

        public void ListData()
        {
            //목록
            if (curCnt == 0)
            {
                Console.WriteLine("입력된 데이터가 없습니다");
                return;
            }
            for (int i = 0; i < curCnt; i++)
            {

                //PhoneInfo curInfo = infoStorage[i];
                //curInfo.ShowPhoneInfo();
                infoStorage[i].ShowPhoneInfo();
            }
        }
        public void SearchData()
        {
            //검색
            Console.WriteLine("주소록 검색을 시작합니다 : ");
            int dataIdx = SearchName();
            if (dataIdx < 0)
            {
                Console.WriteLine("검색된 데이터가 없습니다.");
            }
            else
            {
                infoStorage[dataIdx].ShowPhoneInfo();
            }
            #region 모두 찾기
            //int findCnt = 0;
            //SearchName();
            #endregion
        }
        private int SearchName()
        {
            Console.Write("이름: ");
            string name = Console.ReadLine().Trim().Replace(" ", "");

            for (int i = 0; i < curCnt; i++)
            {
                if (infoStorage[i].Name.Replace(" ", "").CompareTo(name) == 0)
                {
                    return i;
                }
            }

            return -1;
        }

        private int SearchName(string name)
        {
            for (int i = 0; i < curCnt; i++)
            {
                //==, Equals(), CompareTo()
                //if (infoStorage[i].Name.ToLower().Replace(" ","") == name.Replace(" ","")) //영어 포함 대소문자 검색 , replace로 공백 제거
                if (infoStorage[i].Name.Replace(" ", "").CompareTo(name) == 0)
                {
                    return i;
                }
                //if (!bFlag)
                //{
                //    Console.WriteLine("검색된 데이터가 없습니다.");
                //}
                //else
                //{
                //    Console.WriteLine($"총 {i}명이 검색되었습니다.");
                //}
            }
            return -1;
        }

        public void DeleteData()
        {
            //삭제
            Console.WriteLine("주소록 삭제를 시작합니다");
            Console.Write("이름 입력");
            string name = Console.ReadLine();
            int dataIdx = SearchName();
            if (dataIdx < 0)
            {
                Console.WriteLine("검색된 데이터가 없습니다.");
            }
            else
            {
                for (int i = dataIdx; i < curCnt; i++)
                {
                    infoStorage[i] = infoStorage[i + 1];
                }
                curCnt--;
                Console.WriteLine("주소록 삭제가 완료되었습니다");
            }
        }
    }
}
