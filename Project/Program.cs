﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start startScreen = new Start();
            startScreen.Scene();

            Character character = new Character();
            character.Selected();

            MainScene scene = new MainScene();
            scene.MainS();
        }
    }
}
