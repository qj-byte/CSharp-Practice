/*
程序随机生成一个 1-100 之间的整数
用户反复猜
猜大了 → 提示"太大了"
猜小了 → 提示"太小了"
猜对了 → 提示"恭喜，猜了X次"
输入 0 → 退出游戏，显示答案是XXX
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        //生成1-100的随机数
        Random random = new Random();
        int answer = random.Next(1,101);



        //计数器
        int count = 0;

        //反复猜
        while(true)
        {
            count++;
            Console.WriteLine($"请输入你猜的数字（1-100），输入0退出游戏：");
            int guess = Convert.ToInt32(Console.ReadLine());
            if (guess == answer||guess==0)
                break;
            if (guess < answer)
                Console.WriteLine($" 猜小了");
            else
                Console.WriteLine($"猜大了");
        }
        Console.WriteLine($"恭喜，猜了{count}次，答案是{answer}");
    }
}
//1.没有异常处理，用户输入非数字时会报错
//2.没有判断用户输入的数字是否在1-100之间
//3.猜对和退出都说“恭喜，猜了X次，答案是XXX”，应该区分猜对和退出的情况
//4.计数器在用户输入0退出游戏时也会加1，应该在用户输入0时不计数
