// Написать программу, которая из имеющегося массива строк формирует новый массив
// из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив
// можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

namespace FirstSertification
{
    class Program
    {
        static int CountShortString(string[] arrs)
        {
            int count = 0;
            foreach (string i in arrs)
            {
                if (i.Length <= 3) count++ ;
            }
            return count;
        }
        static string[] CreateNewShortArray(string[] arrs)
        {
            int sizeNewArray = CountShortString(arrs);
            string[] newArrs = new string[sizeNewArray];
            int j = 0;
            foreach (string i in arrs)
            {
                if (i.Length <= 3)
                {
                    newArrs[j] = i;
                    j++;
                }
            }
            return newArrs;
        }
        static void ShowArray(string[] arrs)
        {
            string[] newArrs = CreateNewShortArray(arrs);
            if (newArrs.Length > 0)
            {
                Console.WriteLine($"[ \"{string.Join("\", \"", newArrs)}\" ]");
            }
            else
            {
                Console.WriteLine("[]");
            }
        }

        static void Main(string[] args)
        {
            string[] strings1 = {"Привет", "Да", "Хорошо", "Что"};
            string[] strings2 = {"Hello", "2", "world", ":-)"};
            string[] strings3 = {"1234", "1567", "-2"};
            string[] strings4 = {"Russia", "Denmark", "Kazan"};
            ShowArray(strings1);
            ShowArray(strings2);
            ShowArray(strings3);
            ShowArray(strings4);
        }
    }
}