int[] mass = new int[5];
int min = 100;
int max = 0;
for(int i = 0; i < mass.Length; i++)
{
      mass[i] = new Random().Next(1, 100);
      Console.WriteLine($" {mass[i]}");  
}
for(int i = 0; i < mass.Length; i++)
{
      if(max < mass[i])
      {
           max = mass[i];
      }
      if(min > mass[i])
      {
           min = mass[i];
      }  
}
int difference = max - min;
Console.WriteLine(difference);