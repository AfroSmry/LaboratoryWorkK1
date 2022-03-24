// 𝑎 = 1 + 𝑠𝑖𝑛2( 𝑥 + 𝑦) / |2𝑥/ 𝑠𝑖𝑛2( 𝑥 + 𝑦)| + z


Console.WriteLine("Введите X");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите Y");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите Z");
double z = Convert.ToDouble(Console.ReadLine());

double s = Math.Sin(x + y);

s *= s;

double a = (1 + s) / Math.Sqrt(2 * x / s) + z;

Console.WriteLine(a);