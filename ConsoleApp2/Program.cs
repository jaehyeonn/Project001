using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



enum STARTSELECT
{
    SELECTTOWN,
    SELECTBATTLE,
    NONSELECT,
}

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //객체지향 프로그래밍이란
            //결국 클래스로 설계하고 
            //객체로 만들어 나가는 것.

            //저는 마을과 싸움터로 나눠서
            //입장하게 하고 싶다면
            //반복문과 조건문중

            //첫번째 static
            //
            Player NewPlayer = new Player();
            Monster newMonster = new Monster();
         
            while (true)
            {

                //함수 자체의 용도를 생각
                //한가지 용도로만 사용할 수 있나?
                STARTSELECT SelectCheck = StartSelect();
                
                switch (SelectCheck)
                {
                    case STARTSELECT.SELECTTOWN:
                        Town(NewPlayer);
                        break;
                    case STARTSELECT.SELECTBATTLE:
                        Battle(NewPlayer);
                        break;
                }
            }
        }

        static STARTSELECT StartSelect()
        {
            //분명히 있다
            //내가 못찾으면 내가 능력이 부족한거다
            //나는 콘솔 화면을 모조리 지우는 함수를 찾고싶다

            //프로그래머들은 대부분 이성적이고
            //이름을 엉망진창으로 
            Console.Clear();
            Console.WriteLine("1. 마을");
            Console.WriteLine("2. 배틀");
            Console.WriteLine("어디로 가시겠습니까?");
            //리턴이란 구문은 리턴이 되는 순간
            //함수를 완전히 종료 시킨다.
            //리턴시 그 아래 코드는 
            //소용이 없다
            ConsoleKeyInfo CKI = Console.ReadKey();

            Console.WriteLine("");

            switch (CKI.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("마을로 이동합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTTOWN;
                case ConsoleKey.D2:
                    Console.WriteLine("배틀을 시작합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTBATTLE;
                default:
                    Console.WriteLine("잘못된 선택입니다.");
                    Console.ReadKey();
                    return STARTSELECT.NONSELECT;
            }


        }
        static void Town(Player _Player)
        {
            while (true)
            {
                Console.Clear();
                _Player.StatusRender();
                Console.WriteLine("마을에서 무슨일을 하시겠습니까?.");
                Console.WriteLine("1. 체력을 회복한다.");
                Console.WriteLine("2. 무기를 강화한다.");
                Console.WriteLine("3. 마을을 나간다.");

                //프로그래밍의 전부
                //객채(클래스)를 선언해야 할 때
                //맴버변수
                //함수의 분기
                //함수의 합칠때와 쪼갤때
                
                switch (Console.ReadKey().Key)

                {
                    case ConsoleKey.D1:
                        _Player.MaxHeal();

                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        return;

                }
            }

        }
        static void Battle(Player _Player)
        {
            //Console.WriteLine("아직 개장하지 않았습니다.");
            //Console.ReadKey();

            Monster NewMonster = new Monster();

            

            while (true/*둘중 누군가가 죽을때까지*/)
            {
                Console.Clear();
                _Player.StatusRender();
               NewMonster.StatusRender();
                Console.ReadKey();
            }
        }
       
    }
}
