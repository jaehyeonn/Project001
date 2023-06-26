//using System;

//namespace WinterTower
//{
//    class Program
//    {
//        public void Game()
//        {
//            Console.WriteLine("겨울의 탑 - 텍스트 알피지");

//            // 캐릭터 생성
//            Character player = CreateCharacter();

//            Console.WriteLine("게임을 시작합니다!");

//            // 게임 루프
//            bool gameOver = false;
//            while (!gameOver)
//            {
//                Console.WriteLine("어떤 동작을 수행하시겠습니까?");
//                Console.WriteLine("1. 전투");
//                Console.WriteLine("2. 아이템 사용");
//                Console.WriteLine("3. 게임 종료");
//                Console.Write("동작 번호를 입력하세요: ");
//                int action = Convert.ToInt32(Console.ReadLine());

//                switch (action)
//                {
//                    case 1:
//                        StartBattle(player);
//                        break;
//                    case 2:
//                        UseItem(player);
//                        break;
//                    case 3:
//                        gameOver = true;
//                        break;
//                    default:
//                        Console.WriteLine("잘못된 입력입니다. 다시 선택해주세요.");
//                        break;
//                }

//                Console.WriteLine();
//            }

//            Console.WriteLine("게임을 종료합니다.");
//            Console.ReadLine();
//        }

//        static Character CreateCharacter()
//        {
//            Console.WriteLine("캐릭터 생성");
//            Console.Write("캐릭터 이름을 입력하세요: ");
//            string name = Console.ReadLine();

//            Console.Write("캐릭터 직업을 선택하세요 (전사, 마법사, 궁수): ");
//            string job = Console.ReadLine();

//            // 선택한 직업에 따라 캐릭터 생성
//            Character character;
//            switch (job)
//            {
//                case "전사":
//                    character = new Warrior(name);
//                    break;
//                case "마법사":
//                    character = new Mage(name);
//                    break;
//                case "궁수":
//                    character = new Archer(name);
//                    break;
//                default:
//                    character = new Character(name);
//                    break;
//            }

//            Console.WriteLine("캐릭터가 생성되었습니다!");
//            Console.WriteLine("이름: " + character.Name);
//            Console.WriteLine("직업: " + character.Job);

//            return character;
//        }

//        static void StartBattle(Character player)
//        {
//            Console.WriteLine("전투를 시작합니다!");

//            // 전투 로직 구현
//            // 여기에서는 단순히 메시지 출력만 예시로 작성하였습니다.
//            Console.WriteLine(player.Name + "이(가) 전투를 시작합니다!");
//            Console.WriteLine("적과의 전투 진행...");
//            Console.WriteLine(player.Name + "이(가) 승리하였습니다!");
//        }

//        static void UseItem(Character player)
//        {
//            Console.WriteLine("아이템 사용");

//            // 아이템 사용 로직 구현
//            // 여기에서는 단순히 메시지 출력만 예시로 작성하였습니다.
//            Console.WriteLine(player.Name + "이(가) 아이템을 사용합니다!");
//            Console.WriteLine("아이템 사용 완료!");
//        }
//    }

//    class Character
//    {
       
//        public string Name { get; }
//        public string Job { get; }

//        public Character(string name)
//        {
//            Name = name;
//            Job = "일반인";
//        }
//    }
//}

//class Warrior : Character
//{
//    public Warrior(string name) : base(name)
//    {
//        Job = "전사";
//    }
//}

//class Mage : Character
//{
//    public Mage(string name) : base(name)
//    {
//        Job = "마법사";
//    }
//}

//class Archer : Character
//{
//    public Archer(string name) : base(name)
//    {
//        Job = "궁수";
//    }
//}
