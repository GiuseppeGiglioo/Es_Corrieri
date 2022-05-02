using Es_Corrieri;

var Corriere1 = new Corrieri("BRT");
var Corriere2 = new Corrieri("SDA");
var Corriere3 = new Corrieri("DHL");
var Postino = new Corrieri("Poste IT");



var paccoamazon = new Pacco("AmazonStore", "Mario Rossi", 5, 22, 12, 15);
var paccoshein = new Pacco("Shein", "Camilla Ros", 21, 10, 34, 23);
var tasse = new Plico("Comune", "Cittadino Distratto", 220, 2, 4);
var multa = new Plico("Equitalia", "Evasore", 767, 1, 4);


Postino.AddSpedizioni(multa);
Postino.AddSpedizioni(tasse);

Corriere3.AddSpedizioni(paccoamazon);
Corriere3.AddSpedizioni(paccoshein);

Console.WriteLine($"Il{Corriere3} ha da spedire i pacchi: {paccoamazon} e {paccoshein} ");
Console.WriteLine(Corriere3.GetSped());
Console.WriteLine($"Con un ingombro pari a: {Corriere3.TotSped()}");
Console.ReadLine();

