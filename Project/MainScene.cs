﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class MainScene
    {
        
        List<UserStatus>userStatuses = new List<UserStatus>();

        public void MainS()
        {
            string[] a = new string[4];
            List<string> userstatus = new List<string>();
         
            Random random = new Random();
            int rand1;
            int rand2;
            int rand3;
            while (true)
            {
                rand1 = random.Next(0, 4);
                rand2 = random.Next(0, 4);
                rand3 = random.Next(0, 4);
                if (rand1 != rand2 && rand1 != rand3 && rand2 != rand3)
                {
                    break;
                }
            }


            a[0] = "공격력";
            a[1] = "방어력";
            a[2] = "체력";
            a[3] = "치명타확률";

            Console.WriteLine("능력치 중 하나를 고르시오.");
            Console.WriteLine($"1.{a[rand1]}\n2.{a[rand2]}\n3.{a[rand3]}");
              
            int add = random.Next(0, 10);
            ConsoleKeyInfo key = Console.ReadKey();

            if(key.KeyChar=='1')
            {
                if (a[rand1].Equals("공격력"))
                {
                    userStatuses.Add(new UserStatus(10, 0, 0, 0));
                    Console.WriteLine("공격력이 올랐습니다");
                }if (a[rand1].Equals("방어력"))
                {
                    userStatuses.Add(new UserStatus(0, 10, 0, 0));
                    Console.WriteLine("방어력이 올랐습니다.");
                }
                if (a[rand1].Equals("체력"))
                {
                    userStatuses.Add(new UserStatus(0, 0, 10, 0));
                    Console.WriteLine("체력이 올랐습니다.");
                }
                if (a[rand1].Equals("치명타확률"))
                {
                    userStatuses.Add(new UserStatus(0, 0, 0, 10));
                    Console.WriteLine("치명타확률이 올랐습니다");
                }
                
                
            }
            if (key.KeyChar == '2')
            {
                if (a[rand2].Equals("공격력"))
                {
                    userStatuses.Add(new UserStatus(10, 0, 0, 0));
                    Console.WriteLine("공격력이 올랐습니다");
                }
                if (a[rand2].Equals("방어력"))
                {
                    userStatuses.Add(new UserStatus(0, 10, 0, 0));
                    Console.WriteLine("방어력이 올랐습니다.");
                }
                if (a[rand2].Equals("체력"))
                {
                    userStatuses.Add(new UserStatus(0, 0, 10, 0));
                    Console.WriteLine("체력이 올랐습니다.");
                }
                if (a[rand2].Equals("치명타확률"))
                {
                    userStatuses.Add(new UserStatus(0, 0, 0, 10));
                    Console.WriteLine("치명타확률이 올랐습니다");
                }
            }

            if (key.KeyChar == '3')
            {
                if (a[rand3].Equals("공격력"))
                {
                    userStatuses.Add(new UserStatus(10, 0, 0, 0));
                    Console.WriteLine("공격력이 올랐습니다");
                }
                if (a[rand3].Equals("방어력"))
                {
                    userStatuses.Add(new UserStatus(0, 10, 0, 0));
                    Console.WriteLine("방어력이 올랐습니다.");
                }
                if (a[rand3].Equals("체력"))
                {
                    userStatuses.Add(new UserStatus(0, 0, 10, 0));
                    Console.WriteLine("체력이 올랐습니다.");
                }
                if (a[rand3].Equals("치명타확률"))
                {
                    userStatuses.Add(new UserStatus(0, 0, 0, 10));
                    Console.WriteLine("치명타확률이 올랐습니다");
                }
            }


        }
    }
}
