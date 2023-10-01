using DesafioPOO.Models;

// inicializar lojas
var nokiaApps = new List<NokiaAppStore>();
string[] appsNokia = {"App Developer","Facebook","Google Drive","WhatsApp","Google TV","Google Photos","Messenger","Android System WebView","Google Meet","Gboard","Samsung Push Service","Google Play Games","Data Restore Tool","Android Auto","Google Calendar"};
foreach(var app in appsNokia) 
{
    nokiaApps.Add(new NokiaAppStore(app));
} 

var iphoneApps = new List<IphoneAppStore>();
string[] appsIphone = {"Apple One","Apple TV+","Apple Music","Apple Arcade","Apple Fitness+","Apple Podcasts","Apple Books"};
foreach(var app in appsIphone) 
{
    iphoneApps.Add(new IphoneAppStore(app));
}

Nokia nokia = new Nokia(
    numero: "18999119999",
    modelo: "C21",
    imei: "34567897654345678",
    memoria: 64
);

nokia.InicializarLoja(nokiaApps);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Iphone iphone = new Iphone(
    numero: "18999119911",
    modelo: "13",
    imei: "765678904347234",
    memoria: 128
);

iphone.InicializarLoja(iphoneApps);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Apple Arcade");
