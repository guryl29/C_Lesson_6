Console.WriteLine("Введите размер массива:");
int size = int.Parse(Console.ReadLine());

int [] array = new int [size];
int count = 0;

for ( int i=0; i<array.Length; i++)
{
    Console.WriteLine($"Введите элемент массива под индексом {i}");
    array[i]= int.Parse(Console.ReadLine());
}
Console.Write("Массив: ");
Console.Write("[");

Console.Write(string.Join(",", array));
Console.Write("]");

for(int i=0; i<array.Length; i++)
{
    if(array[i]>0)
    {
        count=count + 1;
    }  

}
Console.WriteLine(" количество положитльных чисел в массиве = " + count );

