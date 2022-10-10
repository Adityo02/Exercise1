using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        //deklrasi array int dengan ukuran 60
        private int[] Adit = new int[60];

        //deklarasi variabel int untuk menyimpan banyaknya data yang disimpan pada array
        private int n;

        //fungsi / method untuk menerima masukan
        public void read()
        {
            //menrima angka untuk menentukan banyaknya data yang disimpan pada array 
            while (true)
            {
                Console.Write("masukkan banyaknya elemen pada array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 60)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 60 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan elemen array ");
            Console.WriteLine("-----------------------");

            // Pengguna memasukkan elemen pada array 
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                Adit[i] = Int32.Parse(s1);
            }

        }
        public void display()
        {
            // Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" Element array yang telah tersusun ");
            Console.WriteLine("-----------------------------------");
            for (int AA = 0; AA < n; AA++)
            {
                Console.WriteLine(Adit[AA]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++) // for n - 1 passes
            {
                //pada pass i, bandingkan n - 1 elemen pertama dengan elemen selanjutnya
                for (int AA = 0; AA < n - i; AA++)
                {
                    if (Adit[AA] > Adit[AA + 1]) // jika elmen tidak dalam urutan yang benar
                    {
                        // tukar elemen
                        int temp;
                        temp = Adit[AA];
                        Adit[AA] = Adit[AA + 1];
                        Adit[AA + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            // creating the object of the BubbleSort class
            Program mylist = new Program();

            //pemanggilan fungsi untuk menerima elemen array
            mylist.read();

            //pemanggilan fungsi untuk mengurutkan array 
            mylist.BubbleSortArray();

            //pemanggilan fungsi untuk menampilkan array yang tersusun
            mylist.display();

            //exit
            Console.WriteLine("\n\n Tekan 'ENTER' Untuk Keluar.");
            Console.Read();
        }
    }
}