//int f(int a,int b)
//{
//    int max=Math.Max(a,b);
//    int min=Math.Min(a,b);
//    int m = min;
//    while (m > 0)
//    {
//        if(max%m==0 && min % m == 0)
//        {
//            return m;
//        }
//        m--;
//    }
//    return 1;
//}

//Console.WriteLine(f(24,132));

//Console.Write("a= ");
//int a=  Convert.ToInt32(Console.ReadLine());
//Console.Write("b= ");
//int b= Convert.ToInt32(Console.ReadLine());

//int max1 = Math.Max(a, b);
//int min1 = Math.Min(a, b);

//int f(int max,int min)
//{
//    if(max%min==0 && min1 % min == 0)
//    {
//        return min;
//    }
//    return f(max,min-1);
//}

//Console.WriteLine(f(max1,min1));

int Hcf(int n1,int n2)
{
    if (n2 != 0)
        return Hcf(n2, n1 % n2);
    else return n1;
}

int n1 = 40, n2 = 100;
int hcf=Hcf(n1,n2);
Console.Write("Greatest Common Divisor (G.C.D) of{0} and {1} is {2}.",n1,n2,hcf);
Console.ReadKey();