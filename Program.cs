using DesafioPOO.Models;

Nokia myNokia = new ("43-9970-48284", "OldBrick", "4382942848928", "8");
Iphone myIphone = new ("41-9953-40384", "i7", "432894224923", "64");

myNokia.InstalarAplicativo("whatsapp");
myIphone.InstalarAplicativo("tim recarga");
myIphone.InstalarAplicativo("whatsapp", myIphone.Numero, myIphone.Modelo, myIphone.IMEI, myIphone.Memoria);
myNokia.InstalarAplicativo("nubank", myIphone.Numero, myIphone.Modelo, myIphone.IMEI, myIphone.Memoria);
