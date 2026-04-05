// Console.WriteLine("its Day 2. and i am  MAKING 1 EASY PROJECT  ");
// Console.WriteLine("ENTER A NUMBER :");
// int num =Convert.ToInt32(Console.ReadLine());
// for(int i=1;i<=10;i++)
// {
//     Console.WriteLine( num +" * "+i+" = "+ num*i);
// }

// Console.WriteLine("its Day 2. and i am  MAKING 1 MEDIUM  PROJECT  ");
// Console.WriteLine("ENTER A NUMBER :");
// int num =Convert.ToInt32(Console.ReadLine());
// for(int i=0;i<num;i++)
// {
//     for(int j=0;j<i;j++)
//     {
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }

Console.WriteLine("its Day 2. and i am  MAKING 1 difficult PROJECT  ");
Console.WriteLine("ENTER A NUMBER :");
int num =Convert.ToInt32(Console.ReadLine());
for(int i=0;i<num;i++)
{
    for(int j=1;j<=i;j++)
    {
        Console.Write(j);
    }
     for(int j=i-1;j>0;j--)
    {
        Console.Write(j);
    }
    Console.WriteLine();
}