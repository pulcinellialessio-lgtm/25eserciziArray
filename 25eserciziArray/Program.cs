namespace _25eserciziArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Che esercizio vuoi fare?");
            int es = Convert.ToInt32(Console.ReadLine());

            if (es == 1)
            {
                int[] array1;

                Console.WriteLine("Dimmi la dimensione del vettore");
                int num = Convert.ToInt32(Console.ReadLine());

                array1 = new int[num];

                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("Dimmi il " + (i + 1) + "° valore");
                    int numero = Convert.ToInt32(Console.ReadLine());

                    array1[i] = numero;
                }

                // stampa dei valori del vettore al contrario
                for (int i = num - 1; i >= 0; i--)
                {
                    Console.WriteLine("I numeri sono: " + array1[i]);
                }
            }
            else if (es == 2)
            {
                int[] array2;

                Console.WriteLine("Dimmi la dimensione del vettore");
                int num1 = Convert.ToInt32(Console.ReadLine());

                array2 = new int[num1];

                for (int i = 0; i < num1; i++)
                {
                    Console.WriteLine("Dimmi il " + (i + 1) + "° valore");
                    int numero1 = Convert.ToInt32(Console.ReadLine());

                    array2[i] = numero1;
                }

                // controlla e stampa i numeri pari

                for (int i = 0; i < num1; i++)
                {

                    if (i % 2 == 0)
                    {
                        Console.WriteLine("I numeri sono: " + array2[i]);
                    }
                }
            }
            else if (es == 3)
            {
                int[] array3;

                Console.WriteLine("Dimmi la dimensione del vettore");
                int num2 = Convert.ToInt32(Console.ReadLine());

                array3 = new int[num2];

                for (int i = 0; i < num2; i++)
                {
                    Console.WriteLine("Dimmi il " + (i + 1) + "° valore");
                    int numero2 = Convert.ToInt32(Console.ReadLine());

                    array3[i] = numero2;
                }

                // controlla e stampa i numeri dispari

                for (int i = 0; i < num2; i++)
                {
                    if (array3[i] % 2 != 0)
                    {
                        Console.WriteLine("I numeri sono: " + array3[i]);
                    }
                }
            }
            else if (es == 4)
            {
                int[] array4;

                Console.WriteLine("Dimmi la dimensione del vettore");
                int num3 = Convert.ToInt32(Console.ReadLine());

                array4 = new int[num3];

                for (int i = 0; i < num3; i++)
                {
                    Console.WriteLine("Dimmi il " + (i + 1) + "° valore");
                    int numero3 = Convert.ToInt32(Console.ReadLine());

                    array4[i] = numero3;
                }

                int p = 0, q = 0;

                // conteggio valori pari e dispari

                for (int i = 0; i < num3; i++)
                {
                    if (array4[i] % 2 != 0)
                    {
                        p = p + 1;
                    }
                    else
                    {
                        q = q + 1;
                    }
                }

                // Stampa dei risultati

                Console.WriteLine("I numeri pari sono: " + q);
                Console.WriteLine("I numeri dispari sono: " + p);

            }
            else if (es == 5)
            {
                int[] array5;

                Console.WriteLine("Dimmi la dimensione del vettore");
                int num4 = Convert.ToInt32(Console.ReadLine());

                array5 = new int[num4];

                for (int i = 0; i < num4; i++)
                {
                    Console.WriteLine("Dimmi il " + (i + 1) + "° valore");
                    int numero4 = Convert.ToInt32(Console.ReadLine());

                    array5[i] = numero4;
                }

                int min = array5[0], max = array5[0], somma = 0, l = 0, indiceMin = 1000000, indiceMax = -1000000;
                float media;

                // Calcolo di minimo, massimo e somma necessaria per la media

                for (int i = 1; i < num4; i++)
                {
                    if (min > array5[i])
                    {
                        min = array5[i];
                        indiceMin = i;
                    }

                    if (max < array5[i])
                    {
                        max = array5[i];
                        indiceMax = i;
                    }

                    somma = somma + array5[i];

                    l = l + 1;
                }

                // Calcolo della media

                media = somma / l;

                // Stampa dei risultati

                Console.WriteLine("Il numero minimo è: " + min + " nella posizione " + indiceMin);
                Console.WriteLine("Il numero massimo è: " + max + " nella posicione " + indiceMax);
                Console.WriteLine("la media è: " + media);
                Console.WriteLine("la somma è " + somma);
            }
            else if (es == 6)
            {
                int[] array6;

                Console.WriteLine("Dimmi la dimensione del vettore");
                int num5 = Convert.ToInt32(Console.ReadLine());

                array6 = new int[num5];

                for (int i = 0; i < num5; i++)
                {
                    Console.WriteLine("Dimmi il " + (i + 1) + "° valore");
                    int numero5 = Convert.ToInt32(Console.ReadLine());

                    array6[i] = numero5;
                }

                Console.WriteLine("dimmi un numero");
                int x = Convert.ToInt32(Console.ReadLine());

                int m = 0, M = 0;

                //conto i valori per determinare la lunghezza dei vettori

                for (int i = 0; i < array6.Length; i++)
                {
                    if (array6[i] < x)
                    {

                        m++;
                    }
                    else
                    {

                        M++;
                    }
                }

                // creo i vettori e inserisco i valori

                int[] vet1 = new int[m];
                int[] vet2 = new int[M];
                int indxvet1 = 0, indxvet2 = 0;

                for (int i = 0; i < array6.Length; i++)
                {
                    if (array6[i] < x)
                    {
                        vet1[indxvet1] = array6[i];
                        indxvet1++;
                    }
                    else
                    {
                        vet2[indxvet2] = array6[i];
                        indxvet2++;
                    }
                }

                for (int i = 0; i < vet1.Length; i++)
                {
                    Console.Write($"{vet1[i]}  ");
                }
                Console.Write("    ");
                for (int i = 0; i < vet2.Length; i++)
                {
                    Console.Write($"{vet2[i]}  ");
                }

            }
            else if (es == 7)
            {
                int[] array7;

                Console.WriteLine("Dimmi la dimensione del vettore");
                int num6 = Convert.ToInt32(Console.ReadLine());

                array7 = new int[num6];

                for (int i = 0; i < num6; i++)
                {
                    Console.WriteLine("Dimmi il " + (i + 1) + "° valore");
                    int numero6 = Convert.ToInt32(Console.ReadLine());

                    array7[i] = numero6;
                }

                // Input dei valori a e b

                Console.WriteLine("Dimmi un numero");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dimmi un altro numero");
                int b = Convert.ToInt32(Console.ReadLine());

                // controlla e stampa i numeri compresi tra a e b

                for (int i = 0; i < num6; i++)
                {
                    if (array7[i] >= a && array7[i] <= b)
                    {
                        Console.WriteLine("I numeri compresi tra a e b sono: " + array7[i]);
                    }
                }
            }
            else if(es == 8)
            {
                int[] array8;

                Console.WriteLine("Dimmi la dimensione del vettore");
                int num7 = Convert.ToInt32(Console.ReadLine());

                array8 = new int[num7];

                for (int i = 0; i < num7; i++)
                {
                    Console.WriteLine("Dimmi il " + (i + 1) + "° valore");
                    int numero7 = Convert.ToInt32(Console.ReadLine());

                    array8[i] = numero7;
                }

                Console.WriteLine("Dimmi un numero");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dimmi un altro numero");
                int b = Convert.ToInt32(Console.ReadLine());

                int count = 0;

                // Conta i numeri non compresi tra a e b

                for (int i = 0; i < num7; i++)
                {
                    if (array8[i] < a || array8[i] > b)
                    {
                        count++;
                    }
                }

                // Stampa il conteggio

                Console.WriteLine("I numeri non compresi tra a e b sono: " + count);
            }
            else if(es == 9)
            {
                int[] array9;

                Console.WriteLine("Dimmi la dimensione del vettore");
                int num8 = Convert.ToInt32(Console.ReadLine());

                array9 = new int[num8];

                for (int i = 0; i < num8; i++)
                {
                    Console.WriteLine("Dimmi il " + (i+1) + "° valore");
                    int numero8 = Convert.ToInt32(Console.ReadLine());

                    array9[i] = numero8;
                }

                // Input dei valori a,b,c,d

                Console.WriteLine("Dimmi un numero");   
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dimmi un altro numero");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dimmi un altro numero");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dimmi un altro numero");
                int d = Convert.ToInt32(Console.ReadLine());

                bool t = false;

                // controlla e stampa i numeri compresi tra a e b e poi tra c e d

                for (int i = 0; i< num8; i++)
                {
                    if (array9[i] >=a && array9[i] <= b)
                    {
                        Console.WriteLine("I numeri compresi tra a e b sono: " + array9[i]);
                        t = true;
                    }
                    
                    if(t==true && array9[i] >= c && array9[i] <= d)
                    {
                        Console.WriteLine("I numeri compresi tra c e d sono: " + array9[i]);
                    }       
                }
            }
            else if (es == 10)
            {
                int[] array10;

                Console.WriteLine("Dimmi la dimensione del vettore");
                int num9 = Convert.ToInt32(Console.ReadLine());

                array10 = new int[num9];

                for (int i = 0; i < num9; i++)
                {
                    Console.WriteLine("Dimmi il " + (i+1) + "° valore");
                    int numero9 = Convert.ToInt32(Console.ReadLine());

                    array10[i] = numero9;
                }

                // Input dei valori a,b,c,d

                Console.WriteLine("Dimmi un numero");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dimmi un altro numero");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dimmi un altro numero");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dimmi un altro numero");
                int d = Convert.ToInt32(Console.ReadLine());

                int count = 0;

                // Conta i numeri non compresi tra a e b e tra c e d

                for (int i = 0; i < num9; i++)
                {
                    if (array10[i] < a || array10[i] > b && array10[i] < c || array10[i] > d)
                    {
                        count++;
                    }
                }

                Console.WriteLine("I numeri non compresi tra a e b e tra c e d sono: " + count);
            }
        }
    }
}
