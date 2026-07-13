using System;

class Program
{
    static void Main(string[] args)
    {
        //输入半径
        Console.WriteLine("请输入圆的半径：");
        double r = double.Parse(Console.ReadLine());

        //计算
        double cir = 2 * Math.PI * r;
        double area = Math.PI * r * r;

        //输出结果
        Console.WriteLine($"半径:{r}");
        Console.WriteLine($"圆的周长:{cir:F2}"); 
        Console.WriteLine($"圆的面积:{area:F2}");


    }
}
