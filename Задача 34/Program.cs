int [] mass = new int[4];
int number = 0;
for(int i = 0; i < mass.Length; i++)
{
      mass[i] = new Random().Next(100, 1000);
      Console.WriteLine($" {mass[i]}");  
}
for(int i = 0; i < mass.Length; i++)
{
      if(mass[i] % 2 == 0)
      {
           number++;
      }    
}
Console.WriteLine(number);