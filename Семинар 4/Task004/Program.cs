// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] createMassive(int lenght)
{
    int[] massive = new int[lenght];
    int i = 0;
    while(i < massive.lenght){
        massive[i] = new Random().Next(2);
        i++;
    }
    return massive;
}
void printMassive(int[] massive){
    foreach (var item in massive)
    {
        Console.Write(item + " ");
    }
}

int[] massive = createMassive(6);
printMassive(massive);
