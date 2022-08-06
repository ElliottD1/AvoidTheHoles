using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("World Map:");
            Console.WriteLine(@"  1 2 3 4 5 6
  ___________
1|. . . . . .|
2|. . . . . .|
3|. . ☺ . . .|
4|. . . . . .|
5|. . . . . .|
6|. . . . . ♣|
  -----------");
            Console.Write("You are at ☺\n Get to ♣!\nBut be Careful of holes...\n");
            int i = 2;//x axis
            int b = 2;//y axis
            game(i, b);
        }
        static void game(int i, int b)
        {
            int r = i;
            int c = b;
            char[,] map =
            {
                {'.','.','.','.','.','.'},
                {'.','♦','.','.','.','.'},
                {'.','.','☺','.','♦','.'},
                {'.','.','♦','.','.','.'},
                {'.','.','.','.','♦','.'},
                {'.','.','.','.','.','♣'},
                {'.','.','.','.','.','.'}
            };

            char start = map[2, 2];
            string input = Console.ReadLine();
            if (input == "w")
            {
                try
                {
                    i--;
                start = map[i, b];
                Console.WriteLine(@"  1 2 3 4 5 6
  ___________
1|. . . . . .|
2|. . . . . .|
3|. . . . . .|
4|. . . . . .|
5|. . . . . .|
6|. . . . . ♣|
  -----------");
                Console.WriteLine("You: {0}, Row: {1}, Column: {2}", map.GetValue(r, c+1), r, c+1);
                if (start == map[5,5])
                    {
                        Console.WriteLine("You Win.. Oh, a treausre chest, let's see what's inside!\n...\n...\n...\nNevermind it's a Fridge.");
                    }
                    else
                    {
                    }
                if (start == map[1, 1] || start == map[3, 2] || start == map[2, 4] || start == map[4, 4])
                {
                    
                    Console.WriteLine("You failed as you fell in a hole.");
                    Console.WriteLine("Play again? (Yes/No): ");
                    string answer = Console.ReadLine();
                    if (answer == "Yes")
                    {
                        Main(null);
                    }
                    else if (answer == "no")
                    {
                        Console.WriteLine("Thanks For Playing!");
                    }
                    else
                    {
                        Main(null);
                    }
                    Console.ReadLine();
                }
                else
                {
                    game(i, b);
                }
                }
                catch
                {
                    i++;
                    Console.WriteLine("You: {0}, Row: {1}, Column: {2}", map.GetValue(r, c+1), r+1, c+1);
                    game(i, b);
                    
                }
                

            }
            else if (input == "s")
            {
                try
                {
                    i++;
                start = map[i, b];
                    Console.WriteLine(@"  1 2 3 4 5 6
  ___________
1|. . . . . .|
2|. . . . . .|
3|. . . . . .|
4|. . . . . .|
5|. . . . . .|
6|. . . . . ♣|
  -----------");
                Console.WriteLine("You: {0}, Row: {1}, Column: {2}", map.GetValue(r+1, c+2), r+2, c+1);
                if (start == map[5,5])
                    {
                        Console.WriteLine("You Win.. Oh, a treausre chest, let's see what's inside!\n...\n...\n...\nNevermind it's a Fridge.");
                    }
                    else
                    {
                    }
                if (start == map[1, 1] || start == map[3, 2] || start == map[2, 4] || start == map[4, 4])
                {
                    Console.WriteLine("You failed as you fell in a hole.");
                    Console.WriteLine("Play again? (Yes/No): ");
                    string answer = Console.ReadLine();
                    if (answer == "Yes")
                    {
                        Main(null);
                    }
                    else if (answer == "no")
                    {
                        Console.WriteLine("Thanks For Playing!");
                    }
                    else
                    {
                        Main(null);
                    }
                    Console.ReadLine();
                }
                else
                {
                    game(i, b);
                }
            }
                catch
                {
                    i--;
                    Console.WriteLine("You: {0}, Row: {1}, Column: {2}", map.GetValue(r-1, c+2), r, c+1);
                    game(i,b);

                }
                }
                
            else if (input == "a")
            {
                try
                {
                    b--;
                start = map[i, b];
                    Console.WriteLine(@"  1 2 3 4 5 6
  ___________
1|. . . . . .|
2|. . . . . .|
3|. . . . . .|
4|. . . . . .|
5|. . . . . .|
6|. . . . . ♣|
  -----------");
                Console.WriteLine("You: {0}, Row: {1}, Column: {2}", map.GetValue(r+1, c), r+1, c);
                if (start == map[5,5])
                    {
                        Console.WriteLine("You Win.. Oh, a treausre chest, let's see what's inside!\n...\n...\n...\nNevermind it's a Fridge.");
                    }
                else
                    {
                    }
                if (start == map[1, 1] || start == map[3, 2] || start == map[2, 4] || start == map[4, 4])
                {
                    Console.WriteLine("You failed as you fell in a hole.");
                    Console.WriteLine("Play again? (Yes/No): ");
                    string answer = Console.ReadLine();
                    if (answer == "Yes")
                    {
                        Main(null);
                    }
                    else if (answer == "no")
                    {
                        Console.WriteLine("Thanks For Playing!");
                    }
                    else
                    {
                        Main(null);
                    }
                    Console.ReadLine();
                }
                else
                {
                    game(i, b);
                }
                }
                catch
                {
                    b++;
                    Console.WriteLine("You: {0}, Row: {1}, Column: {2}", map.GetValue(r+1, c+1), r+1, c+1);
                    game(i, b);
                }
                
            }
            else if (input == "d")
            {
                try
                {
                    b++;
                start = map[i, b];
                    Console.WriteLine(@"  1 2 3 4 5 6
  ___________
1|. . . . . .|
2|. . . . . .|
3|. . . . . .|
4|. . . . . .|
5|. . . . . .|
6|. . . . . ♣|
  -----------");
                Console.WriteLine("You: {0}, Row: {1}, Column: {2}", map.GetValue(r+1, c+1), r+1, c+2);
                if (start == map[5,5])
                    {
                        Console.WriteLine("You Win.. Oh, a treausre chest, let's see what's inside!\n...\n...\n...\nNevermind it's a Fridge.");
                    }
                    else
                    {
                    }
                if (start == map[1, 1] || start == map[3, 2] || start == map[2, 4] || start == map[4, 4])
                {
                    Console.WriteLine("You failed as you fell in a hole.");
                    Console.WriteLine("Play again? (Yes/No): ");
                    string answer = Console.ReadLine();
                    if (answer == "Yes")
                    {
                        Main(null);
                    }
                    else if (answer == "no")
                    {
                        Console.WriteLine("Thanks For Playing!");
                    }
                    else
                    {
                        Main(null);
                    }
                    Console.ReadLine();
                }
                else
                {
                    game(i, b);
                }

                }
                catch
                {
                    b--;
                    Console.WriteLine("You: {0}, Row: {1}, Column: {2}", map.GetValue(r+1, c), r+1, c+1);
                    game(i, b);
                }
            }

            Console.ReadLine();
        }
    }
}
//        static bool Restart()
//        {
//            Console.ReadLine();
//            bool res = false;
//            Console.WriteLine("Play again? (Yes/No): ");
//            string answer=Console.ReadLine();
//            answer= answer.Trim();
//            if (answer=="yes")
//            {
//                res = true;
//            }
//            else if (answer=="no")
//            {
//                res = false;
//            }
//            else
//            {
//                Console.WriteLine("Please print yes or no");
//                Restart();
//            }
//            return res;
            
//        }
//    }
//}
