int[] mass = new int[4];
int sum = 0;
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(100, 1000);
    Console.WriteLine($" {mass[i]}");
}
for (int i = 1; i < mass.Length; i = i + 2)
{
    sum = sum + mass[i];
    Console.WriteLine($" {mass[i]}");
}
Console.WriteLine(sum);