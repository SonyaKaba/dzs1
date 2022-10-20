Console.WriteLine("enter number A: ");
string Sa = Console.ReadLine();

Console.Write("enter number B: ");
string Sb = Console.ReadLine();

Console.Write("enter number C: ");
string Sc = Console.ReadLine();

int a = int.Parse(Sa);
int b = int.Parse(Sb);
int c = int.Parse(Sc);

int max = a;

if (a > max) max = a;
if (b > max) max = b; 
if (c > max) max = c;


Console.Write(" max = ");
Console.WriteLine(max);