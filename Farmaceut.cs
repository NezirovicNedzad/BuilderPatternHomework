using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternHomework
{
    public class Farmaceut //lekar je director

        
      
    {




      
            private IBuilder lekBuilder;

            public Farmaceut(IBuilder builder)
            {
                lekBuilder = builder;
            }

            public void KreirajOslobađajućiLek(string ime, int cena,string Proizvodjac,DateTime vreme)
            {
               
                lekBuilder.addNaziv(ime);
                lekBuilder.addProizvodjac(Proizvodjac); 
                lekBuilder.addCena(cena);
                lekBuilder.addDoziranje("Prema potrebi");
                lekBuilder.addVremeIsteka(vreme);   
                lekBuilder.addUputsvo("Koristite prema preporuci lekara lekara.");
            }

            public void KreirajStandardniLek(string ime, int cena,string Tip,string Proizvodjac ,string doziranje,int stepenZavisnosti,int stepenRezistentosti,DateTime vreme)
            {
                lekBuilder.addNaziv(ime);
                lekBuilder.addTip(Tip); 
                lekBuilder.addProizvodjac(Proizvodjac);
                lekBuilder.addCena(cena);
                lekBuilder.addDoziranje(doziranje);
                lekBuilder.addStepenZavisnosti(stepenZavisnosti);
                lekBuilder.addStepenRezistentnosti(stepenRezistentosti);
            lekBuilder.addVremeIsteka(vreme);
            lekBuilder.addUputsvo("Pratite uputstvo na pakovanju.");
            }
        

    }
}
