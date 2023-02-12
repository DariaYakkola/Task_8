Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine()); 
int firstNumbers = 2;
while (firstNumbers <= N)
{
  Console.Write(firstNumbers + " ");
  firstNumbers = firstNumbers + 2;
}