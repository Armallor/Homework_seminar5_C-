// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих 
// на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int siz = vvod("Введите размерность массива ");
int min = vvod("Введите минимальное значение элемента массива ");
int max = vvod("Введите максимальное значение элемента массива ");

int[] array = GetRandomArray(siz, min, max);

int sum = 0;
for(int i = 0; i<array.Length; i++)
{
  if (i % 2 != 0) sum = sum + array[i];
}

Console.WriteLine($"[{String.Join(",", array)}] -> {sum}");

// Функция на ввод целочисленного значения
int vvod (string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine()!);
}

// -------------------------------Общий метод-------------------------------------------
int[] GetRandomArray(int size, int minValue, int maxValue)
            {
                int[] result = new int[size];
                for (int i = 0; i < size; i++)
                {
                    result[i] = new Random().Next(minValue, maxValue + 1);
                }

                return result;
            }

