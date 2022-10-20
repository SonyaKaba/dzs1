Console.WriteLine("enter number: ");
string Sa = Console.ReadLine();

int a = int.Parse(Sa);
int i = 2;
while (i <= a)
{
    if (i % 2 == 0)
      Console.WriteLine(i);
    i++;  
}