// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int siz = vvod("Введите размерность массива ");
int min = 100; //vvod("Введите минимальное значение элемента массива ");
int max = 999; //vvod("Введите максимальное значение элемента массива ");

int[] array = GetRandomArray(siz, min, max);

int count = 0;
for(int i = 0; i<array.Length; i++)
{
  if (array[i] % 2 == 0) count++;
}

Console.WriteLine($"[{String.Join(",", array)}] -> {count}");

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