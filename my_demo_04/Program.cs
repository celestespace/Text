namespace demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = @"D:\BaiduNetdiskWorkspace\论文\UWB";
            //Console.WriteLine(path);
            //Console.ReadKey();

            //@ 将字符串按照原格式输出

            //            Console.WriteLine(@"今天天气好晴朗，
            //处处好风光");


            //算数运算符
            //+ - * / % 加 减 乘 除 取余

            //int n1 = 10;
            //int n2 = 3;
            //int result = n1 / n2;
            //Console.WriteLine(result); //int 整数


            //  取平均分

            //int chinese = 50;
            //int english = 44;
            //int math = 55;
            //Console.WriteLine("总成绩是{0}， 平均成绩是{1}", chinese + english + math, (chinese + math + english) / 3);


            // 计算

            //int r = 5;
            //double area = 3.14 * r * r;
            //double perimeter = 2 * 3.14 * r;
            //Console.WriteLine("圆的面积是{0}, 圆的周长是{1}", area,perimeter);

            // 计算 

            //int T_shirt = 35;
            //int trousers = 70;
            //int money = 3 * T_shirt + 5 * trousers;
            //double realmoney = 0.88 * money;
            //Console.WriteLine("三件T恤和无条裤子的价格是{0}", 3* T_shirt + 5* trousers);
            //Console.WriteLine("8.8折之后的价格是：{0}", realmoney);

            // 类型转换  隐式和显式 隐式也叫自动类型转换  显式也叫强制类型转换
            // 显式   语法 
            // （待转换的类型）要转换的值
            //double d = 1.23;
            //int a = (int)d;
            //Console.WriteLine(a);

            //int a = 10;
            //int b = 3;
            //double d = a*1.0 / b;// 整数除整数依然是整数
            //Console.WriteLine("{0:0.00}", d);//占位符输出  0 ： 后  0. 后面几个零  就保留几个小数

            //int a = 46;
            //int b = a / 7;
            //int c = a % 7;
            //Console.WriteLine("46天是{0}周零{1}天", b ,c);

            //int a = 107653;
            //int days = 107653 / 86400;
            //int hours = (107653 - 86400) / 3600;
            //int minutes = (107653 % 3600) / 60;
            //int seconds = 107653 / 60;
            //Console.WriteLine("天：{0}小时：{1} 分：{2} 秒：{3}", days, hours, minutes, seconds);

            #region  // 输入秒  输出时间
            //Console.WriteLine( "请输入秒");
            //int a = int.Parse(Console.ReadLine());
            //if (a >= 86400)
            //{
            //    int days = a / 86400;
            //    int hours = (a - 86400) / 3600;
            //    int minutes = (a % 3600) / 60;
            //    int seconds = a % 60;
            //    Console.WriteLine("天：{0}小时：{1} 分：{2} 秒：{3}", days, hours, minutes, seconds);
            //}
            //else if(a>= 3600 & a< 86400)
            //{
            //    int days = 0;
            //    int hours = a / 3600;
            //    int minutes = (a % 3600) / 60;
            //    int seconds = a % 60;
            //    Console.WriteLine("天：{0}小时：{1} 分：{2} 秒：{3}", days, hours, minutes, seconds);
            //}
            //else if (a >= 60 & a < 3600)
            //{
            //    int days = 0;
            //    int hours = 0;
            //    int minutes = (a % 3600) / 60;
            //    int seconds = a % 60;
            //    Console.WriteLine("天：{0}小时：{1} 分：{2} 秒：{3}", days, hours, minutes, seconds);
            //}
            //else if (a< 60)
            //{
            //    int days = 0;
            //    int hours = 0;
            //    int minutes = 0;
            //    int seconds = a;
            //    Console.WriteLine("天：{0}小时：{1} 分：{2} 秒：{3}", days, hours, minutes, seconds);
            //}
            #endregion //输入秒输出天小时   

            #region string 转换为 int 用convert
            //Console.WriteLine("请输入名字：");
            //string name = Console.ReadLine();
            //Console.WriteLine("请输入数学成绩：");
            //string math = Console.ReadLine();
            //Console.WriteLine("请输入语文成绩：");
            //string chinese = Console.ReadLine();
            //Console.WriteLine("请输入英语成绩：");
            //string english = Console.ReadLine();
            //int math1 = Convert.ToInt32(math);
            //int chinese1 = Convert.ToInt32(chinese);
            //int english1 = Convert.ToInt32(english);
            //int total = math1 + chinese1 + english1;
            //int mean = (math1 + chinese1 + english1)/ 3;
            //Console.WriteLine("你的名字是：{0}\n你的数学成绩是：{1}\n你的英语成绩是：{2}\n你的语文成绩是：{3}\n总成绩是：{4}\n平均成绩是{5}",
            //    name,math1, english1, chinese1, total, mean);
            #endregion

            #region ++和--分为前和后 a++  ++a 最终都是给变量加一或减一  区别是运算顺序
            //int number = 10;
            //int result = 10 + number++;
            ////int result = 10 + ++number;
            //Console.WriteLine(number);
            //Console.WriteLine(result);
            #endregion


            ////对于 ++ -- 这样只需要一个操作就能完成的运算，称之为一元运算符
            //int a = 5;
            //int b = a++ + ++a * 2 + --a + a++;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            // Console.WriteLine(1500>1);

            #region 判断闰年
            ////  判断闰年  满足两个条件之一
            ////  1,能被400整除   2，能被4整除但是不能被100整除
            //Console.WriteLine("请输入年份： ");
            //int years = Convert.ToInt32(Console.ReadLine());
            //if(years% 400 == 0 || (years % 4 == 0 && years % 100 != 0))
            //{
            //    Console.WriteLine("是闰年");
            //}
            //else
            //{
            //    Console.WriteLine("不是闰年");
            //}
            #endregion


            #region  比较三个数字大小
            //Console.WriteLine("请分别输入三个数字");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //int n3 = Convert.ToInt32(Console.ReadLine());
            //if(n1 > n2 && n1 > n3)
            //{
            //    Console.WriteLine(n1);
            //}
            //else if(n2 > n1 && n2 > n3)
            //{
            //    Console.WriteLine(n2);
            //}
            //else
            //{
            //    Console.WriteLine(n3);
            //}
            #endregion

            #region  提示用户输入密码8888 如果不对提示再输一次
            //string pwd = Convert.ToString(8888);
            ////int d = 1;
            ////double dd = (double)d;
            //Console.WriteLine("请输入密码：");
            //string intpwd = Console.ReadLine();
            //if(intpwd == pwd)
            //{
            //    Console.WriteLine("密码正确");
            //}
            //else
            //{
            //    Console.WriteLine("密码错误\n请重新输入");
            //}
            #endregion

            #region  提示输入用户名  然后再输入密码  如果用户名是 admin 且密码是8888，提示正确 
            ////  否则 如果用户名不是admin 提示用户名不存在
            ////  如果用户名是admin则提示密码错误
            ////Console.WriteLine("请输入用户名：");
            ////string user = Console.ReadLine();
            ////Console.WriteLine("请输入密码：");
            ////string pwd = Console.ReadLine();
            ////if(user == "admin" && pwd == "8888")
            ////{
            ////    Console.WriteLine("登录成功！");
            ////}
            ////else if(user != "admin")
            ////{
            ////    Console.WriteLine("用户名不存在");
            ////}
            ////else if(user == "admin" && pwd != "8888")
            ////{
            ////    Console.WriteLine("密码错误！");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("情况不存在！");
            ////}
            //Console.WriteLine("请输入用户名：");
            //string user = Console.ReadLine();
            //if(user == "admin")
            //{
            //    Console.WriteLine("请输入密码：");
            //    string pwd = Console.ReadLine(); 
            //    if(pwd == "8888")
            //    {
            //        Console.WriteLine("登录成功！");
            //    }
            //    else
            //    {
            //        Console.WriteLine("密码错误！");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("用户名不存在！");
            //}
            #endregion

            #region 异常捕获
            //Console.WriteLine("请输入数字：");
            //bool b = true;
            //int a = 0;// 定义变量
            //try
            //{
            //    a = Convert.ToInt32(Console.ReadLine());
            //}
            //catch
            //{
            //    Console.WriteLine("请输入数字！");
            //    b = false;
            //}
            //if (b)
            //{
            //    Console.WriteLine(a * 2);
            //}
            #endregion

            #region 让用户输入姓名，然后显示上辈子是什么职业
            //Console.WriteLine("请输入姓名：");
            //string name = Console.ReadLine();
            //switch (name)
            //{
            //    case "赵": Console.WriteLine("医生");
            //        break;
            //    case "钱": Console.WriteLine("警察");
            //        break ;
            //    case "孙": Console.WriteLine("客服");
            //        break;
            //    default: Console.WriteLine("不认识");
            //        break;
            //}


            #endregion


            //int a=0;
            //do
            //{
            //    Console.WriteLine(a);
            //    a++;
            //}
            //    while(a< 5);

            #region  请用户输入年份，再输入月份，输出该月的天数（结合平闰年）
            //Console.WriteLine("请输入年份和月份：");
            //int years = Convert.ToInt32(Console.ReadLine());
            //int months = Convert.ToInt32(Console.ReadLine());
            //if (years % 400 == 0 || (years % 4 == 0 && years % 100 != 0))
            //{
            //    switch (months)
            //    {
            //        case 1:
            //        case 3:
            //        case 5:
            //        case 7:
            //        case 8:
            //        case 10:
            //        case 12:
            //            {
            //                Console.WriteLine("{0}月有31天", months);
            //                break;
            //            }
            //        case 2:
            //            {
            //                Console.WriteLine("{0}月有28天", months);
            //                break;
            //            }
            //        case 4:
            //        case 6:
            //        case 9:
            //        case 11:
            //            {
            //                Console.WriteLine("{0}月有30天", months);
            //                break;
            //            }
            //        default:
            //            {
            //                Console.WriteLine("情况不存在，请重新输入！");
            //                break;
            //            }
            //    }

            //}
            //else if (years > 0)
            //{
            //    switch (months)
            //    {
            //        case 1:
            //        case 3:
            //        case 5:
            //        case 7:
            //        case 8:
            //        case 10:
            //        case 12:
            //            {
            //                Console.WriteLine("{0}月有31天", months);
            //                break;
            //            }
            //        case 2:
            //            {
            //                Console.WriteLine("{0}月有27天", months);
            //                break;
            //            }
            //        case 4:
            //        case 6:
            //        case 9:
            //        case 11:
            //            {
            //                Console.WriteLine("{0}月有30天", months);
            //                break;
            //            }
            //        default:
            //            {
            //                Console.WriteLine("情况不存在，请重新输入！");
            //                break;
            //            }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("请输入正确的年份和月份！");
            //}
            #endregion

            #region  while  循环   练习
            //int i = 0;
            //int sum = 0;
            //while(i <= 100)
            //{
            //    //  1 - 100 偶数相加
            //    //if (i % 2 == 0)
            //    //{
            //    //    sum += i;
            //    //}   
            //    //i++;

            //    // 奇数相加
            //    if (i % 2 != 0)
            //    {
            //        sum += i;
            //    }
            //    i++;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region 输入年份和月份判断天数
            //Console.WriteLine("请输入年份：");
            //int year = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入月份：");
            //int month = Convert.ToInt32(Console.ReadLine());
            //if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            //{
            //    switch (month)
            //    {
            //        case 1:
            //        case 3:
            //        case 5:
            //        case 7:
            //        case 8:
            //        case 10:
            //        case 12:
            //            {
            //                Console.WriteLine("{0}年{1}月有31天", year, month);
            //                break;
            //            }
            //        case 2:
            //            {
            //                Console.WriteLine("{0}年{1}月有29天", year, month);
            //                break;
            //            }
            //        default:
            //            {
            //                Console.WriteLine("{0}年{1}月有30天", year, month);
            //                break;
            //            }
            //    }//switch  结束的括号
            //}// if 结束的括号
            //else if (year > 0)
            //{               
            //        switch (month)
            //        {
            //            case 1:
            //            case 3:
            //            case 5:
            //            case 7:
            //            case 8:
            //            case 10:
            //            case 12:
            //                {
            //                    Console.WriteLine("{0}年{1}月有31天", year, month);
            //                    break;
            //                }
            //            case 2:
            //                {
            //                    Console.WriteLine("{0}年{1}月有28天", year, month);
            //                    break;
            //                }
            //            default:
            //                {
            //                    Console.WriteLine("{0}年{1}月有30天", year, month);
            //                    break;
            //                }
            //        }// switch 结束的括号


            //}// else if 结束的括号
            //else
            //{
            //    Console.WriteLine("输入不正确，程序退出");
            //}// else 结束的括号
            #endregion

            #region 输入班级人数  然后依次输入学员成绩  计算班级学员的平均成绩和总成绩
            //Console.WriteLine("请输入班级人数：");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int score = 0;
            //int i = 1;
            //int sum = 0;
            //double mean = 0;

            //while (i <= num)
            //{
            //    Console.WriteLine("请输入第{0}个学员成绩：", i);
            //    score = Convert.ToInt32(Console.ReadLine());
            //    sum += score;
            //    i++;
            //}
            //mean = sum * 1.0 / num;
            //Console.WriteLine("{0}个人的平均成绩是： {1:0.00}总成绩是：{2}",num, mean, sum);

            #endregion

            #region 问会不会 yes放学 no不放学再问一遍  十遍之后啥都放学                        
            //int i=0;
            //while (i < 10)
            //{
            //    Console.WriteLine("这道题你会了么？");
            //    string ans = Console.ReadLine();
            //    if (ans == "yes")
            //    {
            //        Console.WriteLine("放学");
            //        break;
            //    }
            //    else if (ans == "no")
            //    {
            //        i++;
            //        if (i == 10)
            //        {
            //            Console.WriteLine("放学");
            //        }
            //        Console.WriteLine(i);
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            #endregion

            #region 计算增长到哪年到一定数目
            //int year = 2006;
            //double people = 80000;
            //while(people < 200000)
            //{
            //    people *= 1.25;
            //    year++;
            //}
            //Console.WriteLine("{0}年学员人数达到20万人", year);
            #endregion

            #region 不断提示用户输入一个数字  当用户输入end的时候显示刚才输入的最大值
            //  错误示范！！！！！！
            //Console.WriteLine("请输入一个数字：");
            //string n = Console.ReadLine();
            //int max = 0;
            //while (n != "end")
            //{
            //    int _ = Convert.ToInt32(n);
            //    if (_ > max)
            //    {
            //        max = _;
            //    }
            //}
            //while(n == "end")
            //{
            //    Console.WriteLine("刚才输入的最大值是{0}", max);
            //}
            //string n;
            //int max = 0;
            //do
            //{
            //    Console.WriteLine("请输入一个数字：");
            //    n = Console.ReadLine();
            //    try
            //    {
            //        if (Convert.ToInt32(n) > max)
            //        {
            //            max = Convert.ToInt32(n);
            //        }
            //    }
            //    catch
            //    {

            //    }
            //} while (n != "end");
            //Console.WriteLine("刚才输入的最大值是：{0}", max);
            #endregion

            #region  水仙花数   百位的立方 + 十位的立方 + 个位的立方等于当前这个百位数字
            //for (int i = 100; i < 1000; i++)
            //{
            //    int a = (int)Math.Pow(i / 100, 3);
            //    int b = (int)Math.Pow((i % 100) / 10, 3);
            //    int c = (int)Math.Pow(i % 10, 3);
            //    //int a = i / 100;
            //    //int b = i % 100 / 10;
            //    //int c = i % 10;

            //    //if (a * a * a + b * b * b + c * c * c == i)

            //    if (a + b + c == i)
            //    {
            //        Console.WriteLine("{0}是一个水仙花数", i);
            //    }
            //}
            //for (int i = 100; i <= 999; i++)
            //{
            //    int a = i / 100 % 10;
            //    int b = i / 10 % 10;
            //    int c = i % 10;
            //    if (a * a * a + b * b * b + c * c * c == i)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine(521 % 100);
            #endregion

            #region 九九乘法口诀
            //for (int i = 1; i < 10 ; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        int a = i * j;
            //        Console.Write("{0}*{1}={2}\t", i, j ,a);                  
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region  循环输入5个人的年龄并计算平均年龄 如果输入负数或者大于100 则报错
            //int sum = 0;
            //bool b = true;
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("请输入第{0}个人的年龄", i);
            //    try
            //    {
            //        int old = Convert.ToInt32(Console.ReadLine());
            //        if (old > 0 && old <= 100)
            //        {
            //            sum += old;
            //        }
            //        else
            //        {
            //            Console.WriteLine("请输入0-100之间的数！");
            //            b = false;
            //            break;
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("输入的年龄不正确，程序退出！");
            //        b =false;
            //        break;
            //    }
            //}
            //if (b)
            //{
            //    Console.WriteLine("平均年龄是{0}", sum * 1.0 / 5);
            //}
            #endregion

            #region 计算质数
            //for (int i = 2; i < 100; i++)
            //{
            //    bool b = true;
            //    for (int j = 2; j < i; j++)
            //    {
            //        if(i % j == 0)//除尽了说明不是质数
            //        {
            //            b = false;
            //            break;
            //        }
            //    }
            //    if (b)
            //    {
            //        Console.WriteLine("{0}是一个质数", i);
            //    }
            //}            
            #endregion

            #region 三元表达式
            //Console.WriteLine("请输入第一个数：");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数：");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //int max = n1>n2 ? n1:n2;
            //Console.WriteLine(max);
            #endregion

            #region 三元表达式2
            //Console.WriteLine("请输入姓名：");
            //string name = Console.ReadLine();
            //string result = name == "张三" ? "流氓" : "好人";
            //Console.WriteLine(result);
            #endregion

            #region  产生随机数
            //Random r = new Random();  //创建产生随机数的对象
            //int rNumber = r.Next(1, 10);// 限定随机数范围 左闭右开区间
            //Console.WriteLine(rNumber);
            #endregion

            #region  常量
            //int number = 10;
            //number = 20;  //变量可以被赋值
            //const int number2 = 30;//常量不可以被赋值

            #endregion

            #region 数组 
            ////int[] nums = new int[10];
            //// 数组的声明方式
            //int[] nums = { 1, 2, 3, 4, 5, 6 };
            //int[] nums2 = new int[] { 1, 2, 3, 4, 5 };
            #endregion

            #region  从一个整数数组中取出最大的整数  最小整数 总和  平均值 

            #endregion

            #region 方法的练习
          
            //static int MaxValue()
            //{
            //    int a, b;
            //    Console.WriteLine("请输入第一个值：");
            //    a = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("请输入第二个值：");
            //    b = Convert.ToInt32(Console.ReadLine());
            //    if(a > b)
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

           
        }//main函数的结束括号        
        #region  方法 ： 输出两个数大的值
        public static int MaxValue()
        {
            int a, b;
            Console.WriteLine("请输入第一个值：");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个值：");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
            return 0;
        }
        #endregion

        #region 错误的
        //public static int MaxValue(int a, int b)
        //{
        //    return a > b ? a : b;
        //}
        #endregion 
    }//class 的结束括号
}
