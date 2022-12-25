// Блок-схема: Найти среднее арифметическое элементов массива, 
// заполненного случайными целыми числами от 0 до 99. 
// Размер массива задаёт пользователь. 

Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double [] arrey = new double[size];
double sum = 0;
Console.Write("Массив : ");
Random rand = new Random();
for (int i = 0; i < arrey.Length; i++)
{
    arrey[i] = new Random().Next(100);
    sum += arrey[i]; 
    Console.Write(arrey[i] + " ");
}
Console.WriteLine();
Console.Write($"Среднее арефмитическое : {Math.Round((sum / size), 1)}");
