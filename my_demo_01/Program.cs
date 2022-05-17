using System;
namespace my_demo_01
{ 
    public struct Person//结构
    {
        public string name;  //字段  也起到存数据的作用  但是和变量有区别  变量只能存取一个值
        // 但是字段可以存取很多值 
        public int age;
        public char gender;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //xx大学管理系统
            // 性别 姓名 年龄    依次声明变量 5000人  要15000个变量  

            Person zsperson;
            zsperson.gender = '男';
            zsperson.name = "张三";
            zsperson.age = 22;

            Person lsperson;
            lsperson.age = 21;
            lsperson.gender = '女';
            lsperson.name = "李四";  // 用了结构  5000 人  只需要5000 个变量
        }
        
    }
}