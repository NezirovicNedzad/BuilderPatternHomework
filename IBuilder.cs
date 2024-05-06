using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternHomework
{
     public interface IBuilder
    {

        void addNaziv(string N);
        void addProizvodjac(string P);
        void addCena(int c);
        void addTip(string T);  


        void addStepenZavisnosti(int S);
        void addStepenRezistentnosti(int R);


        void addDoziranje(string d);
        void addVremeIsteka(DateTime D);
        void addUputsvo(string U);
        Lek Build();
    }
}
