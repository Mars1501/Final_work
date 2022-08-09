int num = Convert.ToInt32(Console.ReadLine());
string[] array = new string[num];
List<string> arrayNew = new List<string>();
for (int i = 0; i < num; i++)
{
    Console.Write($"Введите {i + 1} элемент массива: ");
    array[i] = Console.ReadLine();
    if (array[i].Length <= 3) arrayNew.Add(array[i]);
}
