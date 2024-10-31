namespace HSELAB3;
 
class Program
{
    static void Main(string[] args)
    {
        double a = Math.PI / 5;
        double b = 9 * Math.PI / 5;
        int k = 10;
        int n = 40;
        double epsilon = 0.0001;
        double h = (b - a) / k;
 
        Console.WriteLine("Вычисление функции");
        Console.WriteLine($"{"X",10}\t{"SN",10}\t{"SE",10}\t{"Y",10}");
 
        for (int i = 0; i < k; i++)
        {
            double x = a + i * h;
 
            // Сумма SN для заданного n
            double SN = 0;
            for (int j = 1; j <= n; j++)
            {
                SN += Math.Cos(j * x) / j;
            }
 
            // Сумма SE для заданной точности ε
            double SE = 0;
            double elem;
            int m = 1;
            do
            {
                elem = Math.Cos(m * x) / m;
                SE += elem;
                m++;
            }
            while (Math.Abs(elem) >= epsilon);
 
            // Точное значение функции
            double Y = -Math.Log(Math.Abs(2 * Math.Sin(x / 2)));
 
            // Вывод результатов
            Console.WriteLine($"{x,10:F4}\t{SN,10:F4}\t{SE,10:F4}\t{Y,10:F4}");
        }
    }
}