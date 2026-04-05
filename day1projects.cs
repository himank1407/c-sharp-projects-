// Console.WriteLine("its Day 1. and i am  MAKING 1 EASY PROJECT  ");
// Console.WriteLine("ENTER YOUR NUMBER:");
// int value=Convert.ToInt32(Console.ReadLine());
// if(value>0)
// {
//     Console.WriteLine("IT A POSITIVE NUMBER");
// }
// else
// {
//     Console.WriteLine("its a negative number");
// }
// if(value %2==0)
// {
//     Console.WriteLine("its a even number");
// }
// else
// {
//     Console.WriteLine("its a odd number");
// }

// Console.WriteLine("its Day 1. and i am  MAKING 1 MEDIUM PROJECTS");
// Random random = new Random();
// int num = random.Next(1, 100);
// while(true)
// {
//    Console.WriteLine("ENTER YOUR NUMBER:");
//    int value=Convert.ToInt32(Console.ReadLine());
//     if(value==num)
//     {
//     Console.WriteLine("you got correct");
//     break;
//     }
//     else if(value<num)
//     {
//     Console.WriteLine("your number is high");
//     }
//     else
//     {
//     Console.WriteLine("your number is low");
//     }
// }

Console.WriteLine("its Day 1. and i am  MAKING 1 hard PROJECTS");
int total =10000;
while(true)
{
    Console.WriteLine("1. withdraw");
    Console.WriteLine("2. depoist");
    Console.WriteLine("3. check balance");
    Console.WriteLine("4. exit");
    int choice= Convert.ToInt32(Console.ReadLine());
    switch(choice)
    {
        case 1:
        Console.WriteLine("ENTER MONEY U WANT TO WITHDRAW:");
        int withdraw= Convert.ToInt32(Console.ReadLine());
        total=total-withdraw;
        break;
        case 2:
        Console.WriteLine("ENTER MONEY U WANT TO DEPOSIT:");
        int deposit= Convert.ToInt32(Console.ReadLine());
        total=total+deposit;
        break;
        case 3:
        Console.WriteLine("TOTAL BALANCE: "+total);
        break;
        case 4:
        Console.WriteLine("BYE BYE BYEE.");
        Environment.Exit(0);
        break;
        default:
        Console.WriteLine("ENTER CORRECT NUMBER.");
        break;
    }
}