using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //캡슐화

    internal class Player : FightUnit
    {
        public void PrintHP()
        {
            //함수로 만들어라
            Console.WriteLine("");
            Console.Write("현재 플레이어의 HP는");
            Console.Write(HP);
            Console.WriteLine("입니다.");
            //Console.ReadKey();  
        }

        public void MaxHeal()
        {
            //함수는 비대하지 않을수록 좋다
            // 5~10줄짜리 함수를 
            if(HP>=MAXHP)
            {
                Console.WriteLine("");
                Console.WriteLine("체력이 모두 회복되어있어서 회복할 필요가 없습니다.");
                Console.ReadKey();
            }
            else
            {
                this.HP = MAXHP;
                PrintHP();
            }
            this.HP = MAXHP;
            PrintHP();
            return ;
        }
       
    }
}
