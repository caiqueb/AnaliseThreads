using AnaliseThreads.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;

namespace AnaliseThreads
{
    public partial class Form1 : Form
    {
        //Crianção de vetores tamanho N
        private int[] vetorInsertion = new int[50000];
        private int[] vetorInsertionParalelo = new int[50000];
        private int[] vetorBubble = new int[50000];
        private int[] vetorBubbleParalelo = new int[50000];
        private int[] vetorQuick = new int[50000];
        private int[] vetorQuickParalelo = new int[50000];
        private int[] vetorMerge = new int[50000];
        private int[] vetorMergeParalelo = new int[50000];
        private int[] vetorSelection = new int[50000];
        private int[] vetorSelectionParalelo = new int[50000];
        //Set de Cronometros
        private Stopwatch cronometro1 = new Stopwatch();
        private Stopwatch cronometro2 = new Stopwatch();
        private Stopwatch cronometro3 = new Stopwatch();
        private Stopwatch cronometro4 = new Stopwatch();
        private Stopwatch cronometro5 = new Stopwatch();
        private Stopwatch cronometro6 = new Stopwatch();
        private Stopwatch cronometro7 = new Stopwatch();
        private Stopwatch cronometro8 = new Stopwatch();
        private Stopwatch cronometro9 = new Stopwatch();
        private Stopwatch cronometro10 = new Stopwatch();
        private Stopwatch cronometro11 = new Stopwatch();
        private Stopwatch cronometro12 = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
            //botão não clicaveis
            btnExecutarSingle.Enabled= false;
            btnExecutarMulti.Enabled= false;
        }
        //Função Botão Criar vetor
        private void btnCriarVetor_Click(object sender, EventArgs e)
        {
            Random randNum = new Random();//função random para numeros aleatorios
            int[] vetor = new int[50000];//criação vetor
            //cria vetor com numeros aleatorios e seta vetores a serem ordenados
            for (int i = 0; i < 50000; i++)
            {
                vetor[i] = randNum.Next(0, 50000);
                lbListaDesordenado.Items.Add(vetor[i]);
                vetorBubble[i] = vetor[i];
                vetorInsertion[i] = vetor[i];
                vetorQuick[i] = vetor[i];
                vetorMerge[i] = vetor[i];
                vetorSelection[i] = vetor[i];
                vetorBubbleParalelo[i] = vetor[i];
                vetorInsertionParalelo[i] = vetor[i];
                vetorQuickParalelo[i] = vetor[i];
                vetorMergeParalelo[i] = vetor[i];
                vetorSelectionParalelo[i] = vetor[i];
            }
            //botoes passam a ser clicaveis
            btnExecutarSingle.Enabled = true;
            btnExecutarMulti.Enabled = true;
            btnCriarVetor.Enabled = false;
        }
        //Refresh de temporizadores
        private void cronometro1Tik_Tick(object sender, EventArgs e)
        {
            this.lblCronometro1.Text = cronometro1.ElapsedMilliseconds.ToString("S:00 MS:000");
        }
        private void cronometro2TIk_Tick(object sender, EventArgs e)
        {
            this.lblCronometro2.Text = cronometro2.ElapsedMilliseconds.ToString("S:00 MS:000");
        }
        private void cronometro3Tik_Tick(object sender, EventArgs e)
        {
            this.lblCronometro3.Text = cronometro3.ElapsedMilliseconds.ToString("S:00 MS:000");
        }

        private void cronometro4Tik_Tick(object sender, EventArgs e)
        {
            this.lblCronometro4.Text = cronometro4.ElapsedMilliseconds.ToString("S:00 MS:000");
        }

        private void cronometro5Tik_Tick(object sender, EventArgs e)
        {
            this.lblCronometro5.Text = cronometro5.ElapsedMilliseconds.ToString("S:00 MS:000");
        }

        private void cronometro6Tik_Tick(object sender, EventArgs e)
        {
            this.lblCronometro6.Text = cronometro6.ElapsedMilliseconds.ToString("S:00 MS:000");
        }
        private void cronometro7Tik_Tick(object sender, EventArgs e)
        {
            this.lblCronometro7.Text = cronometro7.ElapsedMilliseconds.ToString("S:00 MS:000");
        }

        private void cronometro8Tik_Tick(object sender, EventArgs e)
        {
            this.lblCronometro8.Text = cronometro8.ElapsedMilliseconds.ToString("S:00 MS:000");
        }

        private void cronometro9Tik_Tick(object sender, EventArgs e)
        {
            this.lblCronometro9.Text = cronometro9.ElapsedMilliseconds.ToString("S:00 MS:000");
        }

        private void cronometro10Tik_Tick(object sender, EventArgs e)
        {
            this.lblCronometro10.Text = cronometro10.ElapsedMilliseconds.ToString("S:00 MS:000");
        }

        private void cronometro11Tik_Tick(object sender, EventArgs e)
        {
            this.lblCronometro11.Text = cronometro11.ElapsedMilliseconds.ToString("S:00 MS:000");
        }

        private void cronomet12Tik_Tick(object sender, EventArgs e)
        {
            this.lblCronometro12.Text = cronometro12.ElapsedMilliseconds.ToString("S:00 MS:000");
        }
        //Botão de ordenação single thread
        private void btnExecutarSingle_Click(object sender, EventArgs e)
        {
            //Iniciam temporizadores, Ordenam seus respectivos vetores com seu tipo de função e printa valores ordenados na listbox
            cronometro6.Start();
            int i;
            cronometro1.Start();
            Algoritmos_Organizacao.BubbleSort(vetorBubble);
            for (i = 0; i < 50000; i++)
            {
                lbBubbleSingle.Items.Add(vetorBubble[i]);
            }
            cronometro1.Stop();
            cronometro2.Start();
            Algoritmos_Organizacao.SelectionSort(vetorSelection);
            for (i = 0; i < 50000; i++)
            {
                lbSelectionSingle.Items.Add(vetorSelection[i]);
            }
            cronometro2.Stop();
            cronometro3.Start();
            Algoritmos_Organizacao.MergeSort(vetorMerge, 0, (vetorMerge.Length - 1));
            for (i = 0; i < 50000; i++)
            {
                lbMergeSingle.Items.Add(vetorMerge[i]);
            }
            cronometro3.Stop();
            cronometro4.Start();
            Algoritmos_Organizacao.InsertionSort(vetorInsertion);
            for (i = 0; i < 50000; i++)
            {
                lbInsertionSingle.Items.Add(vetorInsertion[i]);
            }
            cronometro4.Stop();
            cronometro5.Start();
            Algoritmos_Organizacao.QuickSort(vetorQuick);
            for (i = 0; i < 50000; i++)
            {
                lbQuickSingle.Items.Add(vetorQuick[i]);
            }
            cronometro5.Stop();
            cronometro6.Stop();
            btnExecutarSingle.Enabled = false;

        }

        //criação de threads a serem executadas simultaneamente
        public void ThreadPrintaBubble()
        {
            cronometro7.Start();
            Algoritmos_Organizacao.BubbleSort(vetorBubbleParalelo);
            for (int i = 0; i < 50000; i++)
            {
                lbBubbleMulti.Items.Add(vetorBubbleParalelo[i]);
            }
            cronometro7.Stop();
        }
        public void ThreadPrintaSelection()
        {
            cronometro8.Start();
            Algoritmos_Organizacao.SelectionSort(vetorSelectionParalelo);
            for (int i = 0; i < 50000; i++)
            {
                lbSelectionMulti.Items.Add(vetorSelectionParalelo[i]);
            }
            cronometro8.Stop();
        }
        public void ThreadPrintaMerge()
        {
            cronometro9.Start();
            Algoritmos_Organizacao.MergeSort(vetorMergeParalelo, 0, (vetorMergeParalelo.Length - 1));
            for (int i = 0; i < 50000; i++)
            {
                lbMergeMulti.Items.Add(vetorMergeParalelo[i]);
            }
            cronometro9.Stop();
        }
        public void ThreadPrintaInsertion()
        {
            cronometro10.Start();
            Algoritmos_Organizacao.InsertionSort(vetorInsertionParalelo);
            for (int i = 0; i < 50000; i++)
            {
                lbInsertionMulti.Items.Add(vetorInsertionParalelo[i]);
            }
            cronometro10.Stop();
        }
        public void ThreadPrintaQuick()
        {
            cronometro11.Start();
            Algoritmos_Organizacao.QuickSort(vetorQuickParalelo);
            for (int i = 0; i < 50000; i++)
            {
                lbQuickMulti.Items.Add(vetorQuickParalelo[i]);
            }
            cronometro11.Stop();
        }
        //botão para ordenar paralelamente
        private void btnExecutarMulti_Click(object sender, EventArgs e)
        {
            
            cronometro12.Start();//inicia temporizador
            //Iniciando Threads criadas
            Thread Printa1 = new Thread(ThreadPrintaBubble);
            Thread Printa2 = new Thread(ThreadPrintaSelection);
            Thread Printa3 = new Thread(ThreadPrintaMerge);
            Thread Printa4 = new Thread(ThreadPrintaInsertion);
            Thread Printa5 = new Thread(ThreadPrintaQuick);
 
            //Start nas threads
            Printa1.Start();
            Printa2.Start(); 
            Printa3.Start();
            Printa4.Start(); 
            Printa5.Start();
            //Join para acabarem todas juntas.
            Printa1.Join();
            Printa2.Join();
            Printa3.Join();
            Printa4.Join();
            Printa5.Join();

            cronometro12.Stop();
            btnExecutarMulti.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListBox.CheckForIllegalCrossThreadCalls = false; //aceita illegalcross
        }

       
    }
    
}
