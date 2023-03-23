// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов 
// массива.(https://learn.microsoft.com/ru-ru/dotnet/api/system.random.nextdouble?view=net-7.0)
// [3, 7.4, 22.3, 2, 78] -> 76

int siz = vvod("Введите размерность массива ");
int min = vvod("Введите минимальное значение элемента массива ");
int max = vvod("Введите максимальное значение элемента массива ");

Double[] array = GetRandomArray(siz, min, max);

Double MIN = array[0];
Double MAX = array[0];
for(int i = 0; i < array.Length; i++)
{
  if (array[i] < MIN) MIN = array[i];
  else if (array[i] > MAX) MAX = array[i];
}
Double dif = MAX - MIN;

Console.WriteLine($"[{String.Join(" , " , array)}] -> {dif}");

// Функция на ввод целочисленного значения
int vvod (string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine()!);
}

// -------------------------------Общий метод-------------------------------------------
Double[] GetRandomArray(int size, int minValue, int maxValue)
            {
                Double[] result = new Double[size];
                for (int i = 0; i < size; i++)
                {
                    result[i] = new Random().Next(minValue, maxValue);
                    result[i] += Math.Round(new Random().NextDouble(), 1);
                }  
                return result;
            }
