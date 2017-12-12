//12.**Implement the "Falling Rocks" game in the text console. A small dwarf stays at the bottom of the screen 
//   and can move left and right (by the arrows keys). A number of rocks of different sizes and forms constantly 
//   fall down and you need to avoid a crash.
//   Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. 
//   The dwarf is (O). Ensure a constant game speed by Thread.Sleep(150).
//   Implement collision detection and scoring system.

using System;
using System.Collections.Generic;
using System.Threading;

//all objects in the game
public struct Objects
{
    public int x;
    public int y;
    public string s;
    public ConsoleColor color;
}

public class FallingRocks
{
    public static Random randomGenerator = new Random();

    public static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }

    public static int playfieldWidth = Console.WindowWidth - 15;
    //  rock types - array
    public static string[] rocks = { "^", "^^", "^^^", "@", "@@", "@@@", "*", "**", "***", "&", "&&", "&&&", "+", "++", "+++", "%", "%%", "%%%",
                                "$", "$$", "$$$", "#", "##", "###", "!", "!!", "!!!", ".", "..", "...", ";", ";;", ";;;"};
    // rock colors – array, only blue, green, cyan rocks 
    public static ConsoleColor[] colors =
    {
        ConsoleColor.Blue, ConsoleColor.Cyan,
        ConsoleColor.DarkBlue, ConsoleColor.DarkCyan,
        ConsoleColor.DarkGreen, ConsoleColor.Green,
    };


    public static void Main()
    {
        int livesCount = 7;
        double speed = 100.0;
        double acceleration = 0.5;
        //Console sizes
        Console.BufferHeight = Console.WindowHeight = 20;
        Console.BufferWidth = Console.WindowWidth = 80;

        // dwarf initialize
        Objects dwarf = new Objects();
        dwarf.x = (Console.WindowWidth - 15) / 2;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.s = "(0)";
        dwarf.color = ConsoleColor.Yellow;

        // rocks
        List<Objects> objects = new List<Objects>();

        while (true)
        {
            speed += acceleration;
            if (speed > 400)
            {
                speed = 400;
            }
            bool hitted = false;
            {
                int chance = randomGenerator.Next(0, 150);

                if (chance < 10)
                {
                    // Add bonus -> livesCount++
                    Objects bonusLive = new Objects();
                    bonusLive.color = ConsoleColor.Magenta;
                    bonusLive.s = "live";
                    bonusLive.x = randomGenerator.Next(0, playfieldWidth - 2);
                    bonusLive.y = 0;
                    objects.Add(bonusLive);
                }
                else if (chance < 15)
                {
                    // Add bonus -> Minus speed
                    Objects bonusSpeed = new Objects();
                    bonusSpeed.color = ConsoleColor.Red;
                    bonusSpeed.s = "speed";
                    bonusSpeed.x = randomGenerator.Next(0, playfieldWidth - 2);
                    bonusSpeed.y = 0;
                    objects.Add(bonusSpeed);
                }
                else
                {
                    Objects newRock = new Objects();
                    newRock.color = colors[randomGenerator.Next(1, colors.Length)];//random color
                    newRock.x = randomGenerator.Next(0, playfieldWidth - 3);
                    newRock.y = 0;
                    newRock.s = rocks[randomGenerator.Next(1, rocks.Length)];//random rock
                    objects.Add(newRock);
                }
            }
            while (Console.KeyAvailable)
            {
                // Move our dwarf (key pressed)
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }

                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.x - 1 >= 0)
                    {
                        dwarf.x--;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.x + 3 < playfieldWidth)
                    {
                        dwarf.x++;
                    }
                }
            }

            // Move rocks
            List<Objects> newList = new List<Objects>();
            for (int i = 0; i < objects.Count; i++)
            {
                Objects oldRock = objects[i];
                Objects newRock = new Objects();
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.s = oldRock.s;
                newRock.color = oldRock.color;

                // Check if rocks or bonuses are hitting us
                for (int k = 0; k < dwarf.s.Length - 1; k++)
                {
                    for (int j = 0; j < newRock.s.Length - 1; j++)
                    {
                        if (newRock.s == "speed" && (newRock.x + j == dwarf.x + k) && newRock.y == dwarf.y)
                        {
                            speed -= 20;
                        }
                        if (newRock.s == "live" && (newRock.x + j == dwarf.x + k) && newRock.y == dwarf.y)
                        {
                            livesCount++;
                        }

                        if (newRock.s != "speed" && newRock.s != "live" && (newRock.x + j == dwarf.x + k) && newRock.y == dwarf.y)
                        {
                            livesCount--;
                            speed += 30;
                            if (speed > 400)
                            {
                                speed = 400;
                            }
                            hitted = true;//flag, dwarf is hitted
                            if (livesCount <= 0)
                            {
                                PrintStringOnPosition(Console.WindowWidth - 14, 7, "GAME OVER!!!", ConsoleColor.Red);
                                PrintStringOnPosition(Console.WindowWidth - 14, 12, "Press[Enter]", ConsoleColor.Magenta);
                                PrintStringOnPosition(Console.WindowWidth - 14, 13, " to exit", ConsoleColor.Magenta);
                                Console.ReadLine();
                                return;
                            }
                        }
                    }
                }

                if (newRock.y < Console.WindowHeight)
                {
                    newList.Add(newRock);
                }

            }
            objects = newList;

            // Clear the console
            Console.Clear();

            // Redraw playfield            
            foreach (Objects rock in objects)
            {
                PrintStringOnPosition(rock.x, rock.y, rock.s, rock.color);
            }

            if (hitted)
            {
                objects.Clear();
            }
            else
            {
                PrintStringOnPosition(dwarf.x, dwarf.y, dwarf.s, dwarf.color);
            }
            // Draw info
            PrintStringOnPosition(Console.WindowWidth - 14, 4, "Lives: " + livesCount, ConsoleColor.Magenta);
            PrintStringOnPosition(Console.WindowWidth - 14, 5, "Speed: " + speed, ConsoleColor.DarkMagenta);
            PrintStringOnPosition(Console.WindowWidth - 14, 6, "Accel-n: " + acceleration, ConsoleColor.White);
            // Slow down program
            Thread.Sleep((int)(500 - speed));
        }
    }
}
//TODO :  :)