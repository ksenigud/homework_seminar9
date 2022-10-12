int Sum (int n, int m)
{
if (n == m)
return n;
 return Sum(n - 1, m) + n;
}
int m = new Random().Next(1,10);
Console.WriteLine("M= " + m);
int n = new Random().Next(1,10);
Console.WriteLine("N= " + n);
if(m >= n)
Console.WriteLine("not work");
else 
Console.WriteLine(Sum(n, m));
