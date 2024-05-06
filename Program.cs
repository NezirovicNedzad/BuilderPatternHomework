// See https://aka.ms/new-console-template for more information



using BuilderPatternHomework;


var lekBuilder = new LekBuilder();
lekBuilder.addNaziv("Paracetamol");

var lek=lekBuilder.Build(); 


DateTime dateTime = new DateTime(2024, 5, 6, 15, 30, 0);
DateTime dateTime2 = new DateTime(2025, 2, 6, 22, 30, 0);


// Kreiraj builder
IBuilder builder = new LekBuilder();

// Kreiraj direktora
Farmaceut farmaceutDirector = new Farmaceut(builder);

// Farmaceut kreira oslobađajući lek
farmaceutDirector.KreirajOslobađajućiLek("Aspirin", 500,"Hemofarm",dateTime);

// Dohvati kreirani lek
Lek medicine = builder.Build();

// Ispisi informacije o leku
Console.WriteLine("Kreirani oslobađajući lek:");//Pod oslobodjavajucim lekom se podrazumeva lek koji ne resava neki hitan problem,nego poboljsava i odrzava trenutno zdravlje
Console.WriteLine(medicine);

// Farmaceut kreira standardni lek
farmaceutDirector.KreirajStandardniLek("Prozac", 1200,"Antidepresiv","Hemofarm", "200mg",9,0,dateTime2);

// Dohvati kreirani lek
medicine = builder.Build();

// Ispisi informacije o leku
Console.WriteLine("\nKreirani standardni lek:");
medicine.ispis();
