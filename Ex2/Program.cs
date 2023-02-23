// Ex2
Console.Write("введите координату точки A по оси x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату точки A по оси y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату точки A по оси z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("введите координату точки B по оси x: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату точки B по оси y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату точки A по оси z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

var result = Math.Sqrt(Math.Pow(x2-x1,2)+ Math.Pow(y2-y1,2)+ Math.Pow(z2-z1,2));
Console.WriteLine(Math.Round(result,2));
