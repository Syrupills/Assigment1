using System;
Console.ForegroundColor = ConsoleColor.Green;


string r1 = " ", r2 = " ", r3 = " ", r4 = " ", r5 = " ", r6 = " ", r7 = " ", r8 = " ", r9 = " ";
string R = "X";
string input;
int inputNumber = 0;
int Rnumber = 0;
Console.WriteLine("Welcome to Tic Tac Toe!");
Console.WriteLine("_______________________");
Console.WriteLine();
int i = 0;
while (i < 9)
{
    Console.WriteLine($" {r1} | {r2} | {r3}");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {r4} | {r5} | {r6}");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {r7} | {r8} | {r9}");


    if (Rnumber % 2 == 0) R = "X";
    else R = "O";

    while (Rnumber < 9)
    {

        Console.Write($"{R}'s move > ");
        input = Console.ReadLine();
        if (!int.TryParse(input, out inputNumber)) continue;
        switch (inputNumber)
        {
            case 1:
                if (r1 != " ")
                {
                    Console.WriteLine("Illegal move! Try again");
                    continue;
                }
                r1 = R;
                break;
            case 2:
                if (r2 != " ")
                {
                    Console.WriteLine("Illegal move! Try again");
                    continue;
                }
                r2 = R;
                break;
            case 3:
                if (r3 != " ")
                {
                    Console.WriteLine("Illegal move! Try again");
                    continue;
                }
                r3 = R;
                break;
            case 4:
                if (r4 != " ")
                {
                    Console.WriteLine("Illegal move! Try again");
                    continue;
                }
                r4 = R;
                break;
            case 5:
                if (r5 != " ")
                {
                    Console.WriteLine("Illegal move! Try again");
                    continue;
                }
                r5 = R;
                break;
            case 6:
                if (r6 != " ")
                {
                    Console.WriteLine("Illegal move! Try again");
                    continue;
                }
                r6 = R;
                break;
            case 7:
                if (r7 != " ")
                {
                    Console.WriteLine("Illegal move! Try again");
                    continue;
                }
                r7 = R;
                break;
            case 8:
                if (r8 != " ")
                {
                    Console.WriteLine("Illegal move! Try again");
                    continue;
                }
                r8 = R;
                break;
            case 9:
                if (r9 != " ")
                {
                    Console.WriteLine("Illegal move! Try again");
                    continue;
                }
                r9 = R;
                break;
            default:
                Console.WriteLine("Illegal move! Try Again");
                continue;

        }
        i++;
        Rnumber++;
        break;



    }

}

Console.WriteLine("Game Over!");

