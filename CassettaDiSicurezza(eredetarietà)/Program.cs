using CassettaDiSicurezza;
using static System.Runtime.InteropServices.JavaScript.JSType;

CassettaSicurezza cassetta = new CassettaSicurezza("1", "12434", "produttore", "12345");
CassettaSicurezza cassetta1 = new CassettaSicurezza("12", "12454", "produttore", "12346");
CassettaSicurezza cassetta2 = new CassettaSicurezza("123", "12474", "produttore", "12347");
CassettaSpeciale cassetta3 = new CassettaSpeciale("14", "123455", "prod", "11111");
CassettaSpeciale cassetta4 = new CassettaSpeciale("144", "1234556", "prod", "111112");
CassettaSpeciale cassetta5 = new CassettaSpeciale("1444", "1234558", "prod", "111115");

DocumentoLegale documento = new DocumentoLegale("123", 12.2, "documento");
Chiavi chiave = new Chiavi("123", 12,"chiaveelettrica");
GoielloPrezioso goiello = new GoielloPrezioso("123", 10,"collana");
cassetta.Aggiungere("12345", goiello);
cassetta1.Aggiungere("1234", chiave);
cassetta2.Aggiungere("12347", documento);

Console.WriteLine( $"{cassetta.ValoreAssicurata ()}\n");
Console.WriteLine($"{cassetta1.ValoreAssicurata()}\n");
Console.WriteLine($"{cassetta2.ValoreAssicurata()} \n");

cassetta1.ValoreAsssicurata_oggetto();
cassetta2.ValoreAsssicurata_oggetto();
cassetta3.ValoreAsssicurata_oggetto();

Console.WriteLine(cassetta.CodiceSeriale);
Console.WriteLine(cassetta1.CodiceSeriale);
Console.WriteLine(cassetta2.CodiceSeriale);

Console.WriteLine($"{cassetta.ValoreDichiarato_oggetto()}");
Console.WriteLine($"{cassetta1.ValoreDichiarato_oggetto()}");
Console.WriteLine($"{cassetta2.ValoreDichiarato_oggetto()}");

cassetta.Tipologia_Oggettosegreto();
cassetta1.Tipologia_Oggettosegreto();
cassetta2.Tipologia_Oggettosegreto();

cassetta.Rimuovere("12345");
cassetta1.Rimuovere("12346");
cassetta2.Rimuovere("12347");

cassetta3.Aggiungere("11111", goiello);
cassetta4.Aggiungere("111112",chiave);
cassetta5.Aggiungere("11111", documento);


Console.WriteLine($"{cassetta3.ValoreAssicurata()}\n");
Console.WriteLine($"{cassetta4.ValoreAssicurata()}\n");
Console.WriteLine($"{cassetta5.ValoreAssicurata()} \n");

Console.WriteLine(cassetta3.CodiceSeriale);
Console.WriteLine(cassetta4.CodiceSeriale);
Console.WriteLine(cassetta5.CodiceSeriale);

Console.WriteLine($"{cassetta3.ValoreDichiarato_oggetto()}");
Console.WriteLine($"{cassetta4.ValoreDichiarato_oggetto()}");
Console.WriteLine($"{cassetta5.ValoreDichiarato_oggetto()}");

cassetta3.Tipologia_Oggettosegreto();
cassetta4.Tipologia_Oggettosegreto();
cassetta5.Tipologia_Oggettosegreto();