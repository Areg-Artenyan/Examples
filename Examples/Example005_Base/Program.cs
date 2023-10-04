int a = 5;
int b = 1;
int c = 2;
int g = 8;
int r = 6;

int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;
if(g > max) max = g;
if(r > max) max = r;

Console.Write("Max = ");
Console.Write(max);