using System;

namespace OrdinamentoVettori
{
    class Program
    {
        static void Main(string[] args)
        {
            //creazione e riempimento del vettore con numeri interi 
            int [] vettore = new int [10] { 11, 55, -9, 7, 74, 147, -87, 6, 0, 18};

            //metodo per ordinare i numeri del vettore
            ordina(vettore);

            //ciclo per stampare i numeri in ordine crescente
            for (int i = 0; i < 10; i++)
                Console.WriteLine(vettore[i]);

            Console.ReadKey();
        }

        //metodo per l'ordinamento dei numeri del vettore
        static void ordina (int[] vettore)
        {
            Array.Sort(vettore);
        }

     
    }
}
