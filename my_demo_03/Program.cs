namespace 方法
{ 
    class SimpleMath
    {
        public static void Main(string[] args)
        {
            #region  方法 ： 实现输出个数中的最大值
            //static int MaxValue()
            //{
            //    int a, b;
            //    Console.WriteLine("请输入第一个值：");
            //    a = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("请输入第二个值：");
            //    b = Convert.ToInt32(Console.ReadLine());
            //    if (a > b)
            //    {
            //        Console.WriteLine(a);
            //    }
            //    else
            //    {
            //        Console.WriteLine(b);
            //    }
            //    return 0;
            //}
            //MaxValue();
            #endregion

            //string res = IsYear();
            //Console.WriteLine(res);

            //// 调用方法  GetNum
            //Console.WriteLine("请输入一个数字：");
            //string input = Console.ReadLine();
            //int num = GetNum(input);
            //Console.WriteLine("你输入的数字是：" + num);      

            ////调用 isyesorno
            //IsYesOrNo();

 
            
        }// Main 函数的结束括号
        #region 写一个方法判断一个年份是否是闰年
        ///// <summary>
        ///// 判断给定的年份是否为闰年
        ///// </summary>
        ///// <returns>是否是闰年</returns>
        //public static string IsYear()
        //{
        //    int year;
        //    Console.WriteLine("请输入年份：");
        //    year = Convert.ToInt32(Console.ReadLine());
        //    if((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
        //    {
        //        return "是闰年";
        //    }
        //    else
        //    {
        //        return "不是闰年";
        //    }
        //}
        #endregion

        #region  方法  ： 读取输入的整数 如果不是数字  提醒重新输入
        //public static int GetNum(string s)
        //{

        //    while (true)
        //    {
        //        try
        //        {
        //            int num = Convert.ToInt32(s);
        //            return num;
        //        }
        //        catch
        //        {
        //            Console.WriteLine("请输入数字!");
        //            s = Console.ReadLine();
        //        }

        //    }      
        //}
        #endregion

        #region  方法 ：　只让用户输入yes or no 否则重新输入
        ///// <summary>
        ///// 限定用户只能输入yes/no 返回输入
        ///// </summary>
        //public static void IsYesOrNo()
        //{
        //    while(true)
        //    {
        //        string s = Console.ReadLine();
        //        if (s == "yes" || s == "no")
        //        {
        //            Console.WriteLine("你的输入是：" + s);
        //            return;
        //        }
        //        else
        //        {
        //            Console.WriteLine("请输入yes/no!");
        //        }
        //    }
        //}
        #endregion

        #region 方法： 计算数组的和
        public static int SumNum(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
        #endregion

        #region 方法  求一个数组中的最大值最小值平均值总和  将返回的四个值放在一个数组中

        #endregion
    }// class 结束的括号
}