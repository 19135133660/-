using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <100;i++ )
            {
                Console.WriteLine(" 1.加法\t 2.减法\t 3.乘法\t 4.除法");
                Console.WriteLine("请选择要进行的运算：");
                int a;
                a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        JiaFa n1 = new JiaFa();
                        Console.WriteLine("当前为加法运算：");
                        n1.x = Convert.ToInt32(Console.ReadLine());
                        n1.y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("和为：{0}", n1.x + n1.y);
                        break;
                    case 2:
                        JianFa n2 = new JianFa();
                        Console.WriteLine("当前为减法运算：");
                        n2.x = Convert.ToInt32(Console.ReadLine());
                        n2.y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("差为：{0}", n2.x - n2.y);
                        break;
                    case 3:
                        ChengFa n3 = new ChengFa();
                        Console.WriteLine("当前为乘法运算：");
                        n3.x = Convert.ToInt32(Console.ReadLine());
                        n3.y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("积为：{0}", n3.x * n3.y);
                        break;
                    case 4:
                        ChuFa n4 = new ChuFa();
                        Console.WriteLine("当前为除法运算：");
                        n4.x = Convert.ToInt32(Console.ReadLine());
                        n4.y = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            Console.WriteLine("商为：{0}", n4.x / n4.y);
                        }
                        catch
                        {
                            Console.WriteLine("分母不能为0");
                        }
                        break;
                    default:
                        Console.WriteLine("请重新选择：");
                        break;
                }
            }
        }
        class JiaFa
        {
            public int x;
            public int y;
        }
        class JianFa
        {
            public int x;
            public int y;
        }
        class ChengFa
        {
            public int x;
            public int y;
        }
        class ChuFa
        {
            public int x;
            public int y;
        }
    }
}
