// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int num,r,sum = 0,t;
Console.Write("Введите пятизначное число:");
int n = Convert.ToInt32(Console.ReadLine());
if(n>9999 && n<100000)
{
for(t=n;n!=0;n=n/10)
{
r=n % 10;
sum=sum*10+r;
}
if(t==sum)
Console.Write($"{t} является палиндромом");
else
Console.Write($"{t} не является палиндромом");
} else
Console.Write("Введите пятизначное число");