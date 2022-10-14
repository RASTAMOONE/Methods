// See https://aka.ms/new-console-template for more information
int max;
int MethodMax(int var1, int var2, int var3)
{
    if (var1 > var2)
    {
        max = var1;
    }
    else
    {
        max = var2;
    }
    if (max > var3)
    {
        return max;
    }
    else
    {
        max = var3;
        return max;
    }
}
MethodMax(10, 20, 30);
Console.WriteLine(max);
int min;
int MethodMin(int var1 = 4, int var2 = 5, int var3 = 9)
{
    if (var1 < var2)
    {
        min = var1;
    }
    else
    {
        min = var2;
    }
    if (min < var3)
    {
        return min;
    }
    else
    {
        min = var3;
        return min;
    }
}
MethodMin(20,10,30);
Console.WriteLine(min);
bool TrySumIfOdd(out int sum, int par = 1, int par2 = 3) 
{
    sum = par + par2;
    if (sum % 2 == 0)
    {
        return false;
    }
    else 
    {
        return true;
    }
}
int number;
bool result = TrySumIfOdd(out number, 10, 15);
Console.Write($"{result} ");
Console.WriteLine(number);