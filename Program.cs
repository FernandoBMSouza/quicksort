int[] a = new int[] { 7, 9, 2, 5, 1, 10, 4, 8, 6, 3 };
QuickSort(a, 0, a.Length - 1);
for (int i = 0; i < a.Length; i++)
{
    System.Console.Write(a[i] + " ");
}

void QuickSort(int[] a, int p, int r)
{
    if (p < r) //se posição inicial for menor que final
    {
        int q = Partition(a, p, r);
        QuickSort(a, p, q - 1); //chamando quicksort do lado esquerdo do pivot
        QuickSort(a, q + 1, r); //chamando quicksort do lado direito do pivot
    }
}

int Partition(int[] a, int p, int r)
{
    int x = a[r]; //x recebe o último elemento do vetor setando como pivot
    int i = p - 1; //y recebe o index da posição inicial menos 1
    for (int j = p; j < r; j++)
    {
        if (a[j] <= x)
        {
            i++;
            Swap(a, i, j);
        }
    }
    Swap(a, i + 1, r);
    return i + 1;
}

void Swap(int[] a, int p1, int p2)
{
    int aux = a[p1];
    a[p1] = a[p2];
    a[p2] = aux;
}