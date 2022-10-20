Console.Write("enter number A: ");
string Sa = Console.ReadLine();

Console.Write("enter number B: ");
string Sb = Console.ReadLine();

int a = int.Parse(Sa);
int b = int.Parse(Sb);

int max = a;

if (a > max) max = a;
if (b > max) max = b; 

Console.Write(" max = ");
Console.WriteLine(max); 