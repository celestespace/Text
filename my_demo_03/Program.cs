/*
 占位符 
 */
int a = 1;
int b = 2;
int c = 3;
//c = a;
//a = b;
//b = c;
a = a - b;//a = -1
b = a + b;//b = 1
a = b - a;//a = 2
Console.WriteLine("第一个:{0} 第二个：{1} 第三个：{2}", a, b, c);
