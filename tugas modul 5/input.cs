using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_modul_5
{
    class input #kelas input
    {
        float lt, ht, lb, hb, pbb, harga; #tipedata bilangan desimal(float)
        string inputt;
        operasi ope;

        public input() 
        {
            ope = new operasi();
            inputData();
            outputData();
        }

        public void inputData()
        {
            Identitas id = new Identitas();
            Console.Clear();
            id.id();

            Console.WriteLine(" \n\nInput Data: \n");
            Console.Write("\n Luas Tanah (dalam meter persegi): ");
            inputt = Console.ReadLine();
            float.TryParse(inputt, out lt);
            ope.lt = this.lt;
            Console.Write("\n Harga Jual Tanah: Rp");
            inputt = Console.ReadLine();
            float.TryParse(inputt, out ht);
            ope.ht = this.ht;
            Console.Write("\n Luas Bangunan (dalam meter persegi): ");
            inputt = Console.ReadLine();
            float.TryParse(inputt, out lb);
            ope.lb = this.lb;
            Console.Write("\n Harga Jual Bangunan: Rp");
            inputt = Console.ReadLine();
            float.TryParse(inputt, out hb);
            ope.hb = this.hb;
            
           

        }

        public void outputData()
        {
            Identitas id = new Identitas();
            Console.Clear();
            id.id();
            ope.Mpbb();

            Console.WriteLine("\n\n ---Data--- \n");
            Console.WriteLine("Luas Tanah : "+ope.lt);
            Console.WriteLine("Nilai Jual Tanah : Rp"+ope.ht);
            Console.WriteLine("Luas Bangunan : "+ope.lb);
            Console.WriteLine("Nilai Jual Rumah : Rp"+ope.hb);


            Console.WriteLine("\n ---Hitung--- \n");
            Console.WriteLine("Nilai Jual Tanah ialah : Rp" + ope.jt);
            Console.WriteLine("Nilai Jual Bangunan ialah : Rp" + ope.jb);
            Console.WriteLine("NJOP dasar ialah : Rp" + ope.njopd);
            Console.WriteLine("\nNJOP PBB adalah : Rp" + ope.njop);
            Console.WriteLine("\nNJKP ialah : Rp" + ope.njkp);
            Console.WriteLine("PBB : Rp" + ope.pbb);
            Console.WriteLine("\n --Jadi besar Pajak Bumi dan Bangunan yang harus dibayarkan ialah : Rp" + ope.pbb+"--");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}

#sourcecode-nya banyak
