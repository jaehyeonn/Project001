using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Character
    {
        public void Selected()
        {

            int selectedCharacterIndex = ShowCharacterSelection();

            // 선택된 캐릭터에 따라 다음 동작 수행
            switch (selectedCharacterIndex)
            {
                case 1:
                    Console.WriteLine("유준호 가(이) 선택되었습니다.");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("유준호와 여정을 떠납니다.");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("숲에 도착한 유준호 신비로운 힘을 얻습니다.");
                    // 선택된 캐릭터 1에 대한 처리
                    break;
                case 2:
                    Console.WriteLine("이미정 가(이) 선택되었습니다.");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("이미정과 여정을 떠납니다.");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("숲에 도착한 이미정 신비로운 힘을 얻습니다.");
                    // 선택된 캐릭터 2에 대한 처리
                    break;
                case 3:
                    Console.WriteLine("박시연 가(이) 선택되었습니다.");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("박시연과 여정을 떠납니다.");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("숲에 도착한 박시연 신비로운 힘을 얻습니다.");
                    // 선택된 캐릭터 3에 대한 처리
                    break;
                default:
                    Console.WriteLine("유효하지 않은 선택입니다.");
                    break;
            }

            Console.ReadLine();
            Console.Clear();
        }

        public int ShowCharacterSelection()
        {
            Console.WriteLine("겨울의 탑 캐릭터 선택");
            Console.WriteLine("1. 유준호");
            Console.WriteLine("2. 이미정");
            Console.WriteLine("3. 박시연");
            Console.Write("선택할 캐릭터 번호를 입력하세요: ");
            int selectedCharacterIndex = Convert.ToInt32(Console.ReadLine());
            return selectedCharacterIndex;
        }
    }
}
