// Ex1
Console.Write("введите число: ");
var number = Convert.ToInt32(Console.ReadLine());
if (number>=1000 && number<=99999)
{
    Console.WriteLine("число пятизначное");
    var s = number.ToString();
    for(int i=0;i<=s.Length/2;i++)
    if (s[i]==s[s.Length-1-i])
    {
    Console.WriteLine("число является палиндромом");
    break;
    }
    else
    {
    Console.WriteLine("число не является палиндромом");
    return;
    }
}
else
{
  Console.WriteLine("число не пятизначное");  
}
