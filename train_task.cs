
using System;
class HelloWorld {
  static void Main(){
    string st = Console.ReadLine();
    int min = 1, sum = 0;
    int n = Convert.ToInt32(st);
    int[] array = new int[n];
    for (int i = 0; i < n; i++ )
    {
        string temp = Console.ReadLine();
        array[i] = Convert.ToInt32(temp);
    }
    for (int i = 0; i < n; i++)
    {
        min = Math.Min(min, array[i] % 2);
        sum += array[i] * min;
    }
    Console.Write(sum);
  }
}
