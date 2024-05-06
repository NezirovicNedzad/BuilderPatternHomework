using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternHomework
{
    public class LekBuilder : IBuilder
    {


        private Lek  _lek=new Lek();

  
        
       
        public void addNaziv(string N)
        {
            _lek.Naziv = N;
        }

        public void addProizvodjac(string P)
        {
            _lek.Proizvodjac = P;
        }

        public void addCena(int c)
        {
            _lek.Cena = c;
        }

        public void addTip(string T)
        {
            _lek.Tip = T;   
        }
        public void addStepenZavisnosti(int S)
        {
           _lek.StepenZavisnosti = S;   
        }

        public void addStepenRezistentnosti(int R)
        {
          _lek.StepenRezistentnosti = R;    
        }

        public void addDoziranje(string d)
        {
           _lek.Doziranje = d;  
        }

        public void addVremeIsteka(DateTime D)
        {
           _lek.VremeIsteka = D;    
        }

        public void addUputsvo(string U)
        {
          _lek.Uputstvo = U; 
        }


        public Lek Build()
        {

            return _lek;
        }

       
    }
}
