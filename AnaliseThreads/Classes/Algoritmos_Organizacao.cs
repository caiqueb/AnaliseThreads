using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaliseThreads.Classes
{
    internal class Algoritmos_Organizacao
    {
        //Ordenação Insertion de forma recursiva
        public static int[] InsertionSort(int[] vetor)
        {
            int i, j, atual;
            for (i = 0; i < vetor.Length; i++)
            {
                atual = vetor[i];
                j = i;
                while ((j > 0) && (vetor[j - 1] > atual))
                {
                    vetor[j] = vetor[j - 1];
                    j--;
                }
                vetor[j] = atual;
            }
            return vetor;
        }

        //ordenação Bubble de forma recursiva
        public static int[] BubbleSort(int[] vetor)
        {
            int tamanho = vetor.Length;
            int comparacoes = 0;
            int trocas = 0;

            for (int i = tamanho - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    comparacoes++;
                    if (vetor[j] > vetor[j + 1])
                    {
                        int aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                        trocas++;
                    }
                }
            }

            return vetor;
        }

        //Ordenação Quick de forma recursiva
        public static int[] QuickSort(int[] vetor)
        {
            int inicio = 0;
            int fim = vetor.Length - 1;

            Sort(vetor, inicio, fim);

            return vetor;
        }
        private static void Sort(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int p = vetor[inicio];
                int i = inicio + 1;
                int f = fim;
                while (i <= f)
                {
                    if (vetor[i] <= p)
                    {
                        i++;
                    }
                    else if (p < vetor[f])
                    {
                        f--;
                    }
                    else
                    {
                        int troca = vetor[i];
                        vetor[i] = vetor[f];
                        vetor[f] = troca;
                        i++;
                        f--;
                    }
                }
                vetor[inicio] = vetor[f];
                vetor[f] = p;

                Sort(vetor, inicio, f - 1);
                Sort(vetor, f + 1, fim);
            }
        }
        //Ordenação por Seleção
        public static int[] SelectionSort(int[] vetor)
        {
            int min, aux;
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[j] < vetor[min])
                    {
                        min = j;
                    }

                }
                if (min != i)
                {
                    aux = vetor[min];
                    vetor[min] = vetor[i];
                    vetor[i] = aux;
                }
            }
            return vetor;
        }
        //Ordenação Merge
        static public void Merge(int[] vetor, int inicio, int pivot, int fim)
        {
            int i, j, k;
            int n1 = pivot - inicio + 1;
            int n2 = fim - pivot;
            int[] L = new int[n1];
            int[] R = new int[n2];
            for (i = 0; i < n1; i++)
            {
                L[i] = vetor[inicio + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = vetor[pivot + 1 + j];
            }
            i = 0;
            j = 0;
            k = inicio;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    vetor[k] = L[i];
                    i++;
                }
                else
                {
                    vetor[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                vetor[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                vetor[k] = R[j];
                j++;
                k++;
            }
        }
        static public void MergeSort(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int pivot = (inicio + fim) / 2;
                MergeSort(vetor, inicio, pivot);
                MergeSort(vetor, pivot + 1, fim);
                Merge(vetor, inicio, pivot, fim);
            }
        }

    }
}
