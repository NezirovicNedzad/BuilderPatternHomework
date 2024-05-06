using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternHomework
{
    public class Lek
    {



        public string Naziv { get; set; }

        public string Proizvodjac { get; set; }


        public string Tip { get; set; }
        public int Cena { get; set; }


        public string Doziranje { get; set; }
        public DateTime VremeIsteka { get; set; }



        public int StepenRezistentnosti { get; set; }

        public string Uputstvo { get; set; }
        public int StepenZavisnosti { get; set; }


    

        // Format the DateTime object into a string
        
        public override string ToString()
        {
            return $"Ime: {Naziv},\nProizvodjac: {Proizvodjac},\nDoziranje: {Doziranje},\nUputstvo: {Uputstvo}\nVreme isticanja: {VremeIsteka}";
        }

        public void ispis()
        {
        
        
Console.WriteLine($"Ime: {Naziv},\nProizvodjac: {Proizvodjac},\nTip:{Tip}\nDoziranje: {Doziranje},\nUputstvo: {Uputstvo}\nVreme isticanja: {VremeIsteka}\nStepenRezistentnosti:{StepenRezistentnosti}\nStepenZavisnosti:{StepenZavisnosti}");   
        
        }




    }
}
