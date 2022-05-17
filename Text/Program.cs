using System;

//
namespace Test
{
class Program
    {
        static void Main(String[] args)
        {
            #region  第一次
            /*
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("请输入姓名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入性别");
            string sex = Console.ReadLine();
            //Console.WriteLine("姓名: “{0}”,性别:  “{1}”", name, sex);
            //Console.WriteLine("姓名: {0},性别: {1}", name, sex);
            string message = $"姓名：{name}, 性别：{sex}";
            Console.WriteLine(message);
            */
            #endregion
            double money = double.Parse(Console.ReadLine());
            bool isHouse = true;
            if (money >= 1000)
            {
                Console.WriteLine("yes");
                Console.WriteLine("no");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("rigth");
                Console.ReadKey();
                float i;
            }
        }
    }
}
