int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 39;
int b1 = 40;
int c1 = 25;
int a2 = 17777;
int b2 = 4;
int c2 = 15;
int a3 = 78;
int b3 = 560;
int c3 = 24;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);