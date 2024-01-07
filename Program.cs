namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string username = "abcd", usernameenter;
    string password = "1234", passwordenter;
s:;
    Console.Clear();
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = default;
    Console.Write("enter your username: ");
    usernameenter = Console.ReadLine();
    Console.Write("enter your password: ");
    passwordenter = Console.ReadLine();
    if (passwordenter == password && usernameenter == username)
    {
    l:
        //inja menu ast.
        //1- karbar inja mitavanad range background v foreground ra az miane rang haye sabz ghermez abi entekhab konad
        //
        //2- bazie hads adade entekhab shode tavasote system
        //
        //3- mashin hesasb 
        //
        //4-khoruj az barname
        Console.Clear();
        Console.WriteLine("welcome {0}",username);
        Console.WriteLine();
        int select = 0;
        Console.BackgroundColor= ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("1- Diplay");
        Console.WriteLine("2- Game");
        Console.WriteLine("3- calculator ");
        Console.WriteLine("4- exit ");
        Console.Write("your selection: ");
        Console.ForegroundColor = ConsoleColor.Blue;
        select = Convert.ToInt16(Console.ReadLine());
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        //taghiree rang ha (RGB)
        if (select == 1)
        {
            char l = ' ';
            Console.Write("enter b for BackgroundColor or f for ForegroundColor:");
            l = Convert.ToChar(Console.ReadLine());
            char color;
            //for background
            if (l == 'b')
            {
                Console.WriteLine("r for red / g for green / b for blue");
                color = Convert.ToChar(Console.ReadLine());
                switch (color)
                {
                    case 'r':
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        goto l;
                    case 'g':
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Clear();
                        goto l;
                    case 'b':
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        goto l;
                }
            }
            else if (l == 'f')
            {
                //for foreground
                Console.WriteLine("r for red / g for green / b for blue");
                color = Convert.ToChar(Console.ReadLine());
                switch (color)
                {
                    case 'r':
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        goto l;
                    case 'g':
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Clear();
                        goto l;
                    case 'b':
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        goto l;
                }
            }
        }
        else if (select == 2)
        {
            Random rand = new Random();
            int random = rand.Next(1, 100);
            //Console.WriteLine(random);
            bool Fla = true;
            while (Fla == true)
            {
            K:;
                int usernumber;
                Console.WriteLine("enter your guess number(between 1-100) :");
                usernumber = Convert.ToInt16(Console.ReadLine());
                if (usernumber >= 0 && usernumber <= 100)
                {
                    if (usernumber > random)
                    {
                        Console.WriteLine("MY NUMBER IS SMALLER!");

                    }
                    if (usernumber < random)
                    {
                        Console.WriteLine("MY NUMBER IS BIGGER!");
                    }
                    if (usernumber == random)
                    {
                        Console.WriteLine("YOU WIN! MY NUMBER WAS {0}", random);
                        Fla = true;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("wrong");
                    Console.Clear();
                    goto K;
                }
            }
            Console.WriteLine("press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            goto l;
        }
        //mashin hesab(4 amal asli)
        if (select == 3)
        {
            int firstnum, secondnum;
            char operation;
            Console.WriteLine("enter your first number");
            firstnum = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter your operator");
            operation = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("enter your second number");
            secondnum = Convert.ToInt16(Console.ReadLine());
            switch (operation)
            {
                case '+':
                    Console.Write("the answer is : ");
                    Console.WriteLine(firstnum + secondnum);
                    break;
                case '-':
                    Console.Write("the answer is : ");
                    Console.WriteLine(firstnum - secondnum);
                    break;
                case '*':
                    Console.Write("the answer is : ");
                    Console.WriteLine(firstnum * secondnum);
                    break;
                case '/':
                    Console.Write("the answer is : ");
                    Console.WriteLine(firstnum / secondnum);
                    Console.WriteLine();
                    break;
            }
            Console.ReadKey();
            Console.Clear();
            goto l;

        }

    }
    else
    {
        Console.Clear() ;
        Console.WriteLine("*** YOU ENTERED WRONG USERNAME OR PASSWORD! ***");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("enter a new username: ");
        username = Console.ReadLine();

        Console.Write("enter a new password: ");
        password = Console.ReadLine();
        Console.Clear();
        goto s;
    }
        }
    }

