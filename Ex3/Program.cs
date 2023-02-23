// Ex3
Console.Write("введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
for(int i=1; i<=N; i++)//i+=2 = i=i+2
{
  Console.Write(Convert.ToInt32(Math.Pow(i,3)) +"\t");  
}
