// Console.WriteLine(" ITS DAY 5 AND I AM MAKING 1 EASY PROJECT");
// string oddeven(int number)
// {
//     if(number %2==0)
//     {
//         return "IT IS EVEN NUMBER";
//     }
//     else
//     {
//         return  "IT IS ODD NUMBER";
//     }
// }
// string prime(int number)
// {
//     for(int i=2;i<number/2;i++)
//     {
//         if(number%i==0)
//         {
//             return " IT IS NOT A PRIME NUMBER";
//         }
//     }
//     return " IT IS A PRIME NUMBER";
// }
// Console.Write("ENTER A NUMBER :");
// int num=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(oddeven(num));
// Console.WriteLine(prime(num));

Console.WriteLine(" ITS DAY 5 AND I AM MAKING 1 MEDIUM PROJECT");
int add( int one, int two)
{
    return one+two;
}
int sub( int one, int two)
{
    return one-two;
}
int mul( int one, int two)
{
    return one*two;
}
int div( int one, int two)
{
    return one/two;
}
Console.Write("ENTER IST NUMBER :");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("ENTER SECOND NUMBER :");
int b=Convert.ToInt32(Console.ReadLine());
while(true)
{
Console.WriteLine("1. ADDITION :");
Console.WriteLine("2. SUBTRACTION :");
Console.WriteLine("3. MULTIPLICATION :");
Console.WriteLine("4. DIVISON  :");
Console.WriteLine("5. EXIT :");
Console.WriteLine("ENTER YOUR CHOICE :");
int choice= Convert.ToInt32(Console.ReadLine());
switch(choice)
{
    case 1:
    Console.WriteLine(add(a,b));
    break;
    case 2:
    Console.WriteLine(sub(a,b));
    break;
    case 3:
    Console.WriteLine(mul(a,b));
    break;
    case 4:
    Console.WriteLine(div(a,b));
    break;
    case 5:
    return;
    default:
    Console.WriteLine("ENTER CORRECT NUMBER");
    break;
}
}
