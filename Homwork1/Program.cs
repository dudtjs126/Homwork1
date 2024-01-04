namespace Homwork1
{  
    internal class Program
    {
        /*public static void AnyKey()
        {
            Console.WriteLine("잘못된 입력입니다.\n아무키나 입력하면 처음 화면으로 돌아갑니다.");
            Console.ReadKey(true);
            Main();
        }*/




        class State
        {
            public int level = 01;
            public int damage = 10;
            public int defense = 5;
            public int stamina = 100;
            public int gold = 1500;
        }

        class ItemList
        {
            public string[] itemName = {"무쇠갑옷" , "스파르타의 창" , "낡은 검"};
            public string[] itemStateType = { "방어력", "공격력", "공격력" };
            public int[] itemState = {5 , 7 , 2};
            public string[] itemDescription = 
                {"무쇠로 만들어져 튼튼한 갑옷입니다." , 
                 "스파르타의 전사들이 사용했다는 전설의 창입니다." ,
                 "쉽게 볼 수 있는 낡은 검 입니다."};

            public void itemInfo()
            {
                for (int i = 0; i < itemName.Length; i++)
                {
                    Console.WriteLine($"{itemName[i]}       | {itemStateType[i]}  {itemState[i]} | {itemDescription[i]}");
                }
            }
        }


        static void Main(string[] args)
        {
            int Success;
            int state_Success;


            while (true)
            {
                // 게임 시작 화면
                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.\n이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.\n");
                Console.WriteLine("1. 상태 보기\n2. 인벤토리\n3. 상점");
                Console.Write("\n원하시는 행동을 입력해주세요.\n>>");

                string choiceMenu = Console.ReadLine();
                bool isSuccess = int.TryParse(choiceMenu, out Success);

                if (isSuccess)
                {
                    // 1. 상태 보기 화면
                    if (Success == 1)
                    {
                        Console.Clear();

                        while (true)
                        {
                            Console.WriteLine("상태 보기\n캐릭터의 정보가 표시됩니다.\n");

                            State state = new State();

                            // 캐릭터 정보
                            Console.WriteLine("Lv. {0}", state.level);
                            Console.WriteLine("도토리 ( 전사 )");
                            Console.WriteLine("공격력: {0}", state.damage);
                            Console.WriteLine("방어력: {0}", state.defense);
                            Console.WriteLine("체  력: {0}", state.stamina);
                            Console.WriteLine("Gold: {0}", state.gold);

                            Console.Write("\n0. 나가기\n원하시는 행동을 입력해주세요.\n>>");

                            choiceMenu = Console.ReadLine();
                            isSuccess = int.TryParse(choiceMenu, out state_Success);

                            if (isSuccess)
                            {
                                if (state_Success == 0)
                                {
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("잘못된 입력입니다.\n0을 입력하여 나가기를 진행해 주세요.\n");
                                }
                            }
                        }

                    }

                    // 2. 인벤토리 화면
                    else if (Success == 2)
                    {
                        Console.Clear();

                        Console.WriteLine("인벤토리\n보유 중인 아이템을 관리할 수 있습니다.\n\n");
                        Console.WriteLine("[아이템 목록]");

                        ItemList item = new ItemList();
                        item.itemInfo();

                        Console.WriteLine("\n1. 장착 관리\n0. 나가기\n");
                        Console.Write("원하시는 행동을 입력해 주세요.\n>>");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("잘못된 입력입니다.\n게임 시작 화면으로 돌아갑니다.\n");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("잘못된 입력입니다.\n게임 시작 화면으로 돌아갑니다.\n");
                }
            }
            
        }

    
    }
}
