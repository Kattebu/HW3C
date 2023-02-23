// Ex4 доп
Console.Write("введите сумму вклада: ");
int deposite = Convert.ToInt32(Console.ReadLine());
if (deposite<100)
{
    Console.WriteLine("Общая сумма: "+ Math.Round((deposite+deposite*0.05),2));
}
else if (deposite<200)
{
Console.WriteLine("Общая сумма: "+ Math.Round((deposite+deposite*0.07),2));
}
else
{
    Console.WriteLine("Общая сумма: "+ Math.Round((deposite+deposite*0.1),2));
}