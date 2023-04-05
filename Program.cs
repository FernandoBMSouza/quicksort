int[] a = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
quickSort(a);
for (int i = 0; i < a.Length; i++)
{
    System.Console.Write(a[i] + " ");
}


void quickSort(int[] vetor)
{
    int inicio = 0;
    int fim = vetor.Length - 1;

    QuickSort(vetor, inicio, fim);
}

void QuickSort(int[] vetor, int inicio, int fim)
{
    if (inicio < fim)
    {
        int p = vetor[inicio];
        int i = inicio + 1;
        int f = fim;

        while (i <= f)
        {
            if (vetor[i] <= p)
                i++;
            else if (p < vetor[f])
                f--;
            else
            {
                int aux = vetor[i];
                vetor[i] = vetor[f];
                vetor[f] = aux;
                i++;
                f--;
            }
        }

        vetor[inicio] = vetor[f];
        vetor[f] = p;

        QuickSort(vetor, inicio, f - 1);
        QuickSort(vetor, f + 1, fim);
    }
}