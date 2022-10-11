Delegat D = new Delegat();
Delegat.PerDel P = new Delegat.PerDel(D.zap);
P += D.Shet;
P += D.NeShet;
P += D.Prostie;
P();
Delegat D2 = new Delegat();
Delegat.PerDel P2 = new Delegat.PerDel(D2.zap);
P2 += D2.Fibo;
P2();
Console.WriteLine();
Time10 T = new Time10();
void Op(Action op) => op();
Op(T.Time);
Op(T.Date);
Op(T.NowDayWeek);
Func<double, double, double, double> F = T.PlTr;
Console.WriteLine(F(3, 5, 7));
Func<double,double> F2 = T.PlCvadr;
Console.WriteLine(F2(33));
class Delegat
{
    public delegate void PerDel();
    int[] mas = new int[10];
    Random rand = new Random();
    public void zap()
    {
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i]=rand.Next(1,35);
            Console.Write(mas[i] + " ");
        }
        Console.WriteLine();
        Console.BackgroundColor = ConsoleColor.White;
    }
    public void Shet()
    {
        for (int i = 0; i < mas.Length; i++)
        {
            if (mas[i]%2==0)
            {
                Console.Write("Четные числа тута ->> " + mas[i] + " \n");
            }
        }
    }
    public void NeShet()
    {
        for (int i = 0; i < mas.Length; i++)
        {
            if (mas[i] % 2 != 0)
            {
                Console.Write("NeЧетные числа здеся ->> " + mas[i] + " \n");
            }
        }
    }
    public void Prostie()
    {
        for (int i = 0; i < mas.Length; i++)
        {
            for (int j = 2; j <= mas[i]/2; j++)
            {
                if (mas[i] % j == 0 && mas[i]!=j)
                {
                    mas[i] = 0;
                    break;
                }
            }
            if (mas[i]!=0)
            {
                Console.WriteLine("Простое число " + mas[i] + " ");
            }
        }
    }
    public void Fibo()
    {
        Console.WriteLine("ФИБОНАЧИ=> ");
        for (int i = 0; i <= mas.GetLength(0); i++)
        {
            Console.ForegroundColor = ConsoleColor.White;
            if (i < 2)
            {
                Console.Write(mas[i] + " ");
            }
            else
            {
                Console.Write(mas[i - 1] + mas[i-2] + " ");
            }
        }
    }
}
class Time10
{
    public void Time()
    {
        Console.WriteLine("RealTime: " + System.DateTime.Now.TimeOfDay);
    }
    public void Date()
    {
        Console.WriteLine("RealDate: " + System.DateTime.Now.ToString("dddd:MMMM:yyyy"));
    }
    public void NowDayWeek()
    {
        Console.WriteLine("NowDayWeek: " + System.DateTime.Now.ToString("dddd"));
        Console.WriteLine("NowDayWeek: " + System.DateTime.Now.DayOfWeek);
    }
    public double PlTr(double a, double b, double c)
    {
        double S;
        double P;
        P = (a + b + c)/2;
        Console.Write("Perimetr ТРЕУГОЛЬНИКА-> " + P +"\nPlosha ТОЖЕ ТРЕУГОЛЬНИКА-> ");
        S = Math.Sqrt(Convert.ToDouble((P * (P - a) * (P - b) * (P - c)))); 
        return S;
    }
    public double PlCvadr(double a)
    {
        Console.ResetColor();
        double S; 
        Console.Write("\nPlosha КВАДРАТА-> ");
        S = a*a;
        return S;
    }
}

