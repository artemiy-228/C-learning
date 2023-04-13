using System;

class World{
    static void Main(){
        int c = 0;
        for (int i = 1; i <= 1000;i++){
            c += isSimple(i);
        }
        Console.WriteLine("Количество простых чисел на отрезке [1; 1000] = {0}", c);
    }
    static int isSimple(int x){
        if (x == 1){
            return 0;
        }
        for (int i = 2; i <= Math.Sqrt(x); i++){
            if (x % i == 0)
                return 0;
        }
        return 1;
    }
}
