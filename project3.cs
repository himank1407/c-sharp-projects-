// Console.WriteLine("its Day 3. and i am  MAKING 1 EASY PROJECT  ");
// Console.WriteLine(" ENTER THE SIZE OF ARRAY:");
// int size=Convert.ToInt32(Console.ReadLine());
// int[] arr=new int[size];
// int maxi=int.MinValue;
// int mini=int.MaxValue;
// for(int i=0;i<size;i++)
// {
//     Console.Write("ENTER "+(i+1)+" element :");
//     arr[i]=Convert.ToInt32(Console.ReadLine());
// }
// for(int i=0;i<size;i++)
// {
//    if(arr[i]<mini)
//     {
//         mini=arr[i];
//     }
//     if(arr[i]>maxi)
//     {
//         maxi=arr[i];
//     }
// }
// Console.WriteLine("MAXIMUM VALUE IS "+maxi);
// Console.WriteLine("MINIMUM VALUE IS "+mini);
// for(int i=0;i<size;i++)
// {
//     Console.WriteLine("THE "+(i+1)+" element : "+arr[i]);
// }
Console.WriteLine("its Day 3. and i am  MAKING 1 difficult PROJECT  ");
Console.WriteLine(" ENTER THE SIZE OF ARRAY:");
int size=Convert.ToInt32(Console.ReadLine());
int[] arr=new int[size];
for(int i=0;i<size;i++)
{
    Console.Write("ENTER "+(i+1)+" element :");
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
int last;
Console.WriteLine(" ENTER  NUMBER   FOR  ROTATION OF ARRAY:");
int rotate=Convert.ToInt32(Console.ReadLine());
for (int i=0;i<rotate;i++)
{
    last=arr[size-1];
    for (int j=size-1;j>0;j--)
    {
        arr[j]=arr[j-1];
    }
    arr[0]=last;
}
for(int i=0;i<size;i++)
{
    Console.WriteLine("THE "+(i+1)+" element : "+arr[i]);
}
// Console.WriteLine("its Day 3. and i am  MAKING 1 MEDIUM  PROJECT  ");
// Console.WriteLine(" ENTER THE SIZE OF ARRAY:");
// int size=Convert.ToInt32(Console.ReadLine());
// int[] arr=new int[size];
// for(int i=0;i<size;i++)
// {
//     Console.Write("ENTER "+(i+1)+" element :");
//     arr[i]=Convert.ToInt32(Console.ReadLine());
// }
// Array.Sort(arr);
// int second=  arr[size-2];
// Console.WriteLine(" SECOND LARGEST NUMBER IS :"+second);