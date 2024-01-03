namespace Homwork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.\n이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.\n");
            Console.WriteLine("1. 상태 보기\n2. 인벤토리\n3. 상점");
            Console.Write("\n원하시는 행동을 입력해주세요.\n>>");

            int Success;
            string choiceMenu = Console.ReadLine();
            bool isSuccess = int.TryParse(choiceMenu, out Success);

            if (isSuccess)
            {
                if (Success <= 3 && Success > 0)
                {
                    Console.Clear();
                    Console.WriteLine("상태 보기\n캐릭터의 정보가 표시됩니다.\n");

                    // 캐릭터 정보
                    Console.WriteLine("Lv. ");
                    Console.WriteLine("도토리 ( 전사 )");
                    Console.WriteLine("공격력: ");
                    Console.WriteLine("방어력: ");
                    Console.WriteLine("체  력: ");
                    Console.WriteLine("Gold: ");

                    Console.Write("\n0. 나가기\n원하시는 행동을 입력해주세요.\n>>");

                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
            }


            

        }
    }
}
