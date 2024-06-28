// See https://aka.ms/new-console-template for more information

//Degiskenler();


using Business.Concrete;
using Entities.Concrete;

SelamVer("Adem");
SelamVer("Ayten");
SelamVer();
int sonuc = Topla(6,58);

string[] ogrenciler = new string[3];
ogrenciler[0] = "Adem";
ogrenciler[1] = "Ayten";
ogrenciler[2] = "jonas";
//ogrenciler[3] = "Ekrem";// IndexOutOfRangeException: 

ogrenciler = new string[4];
ogrenciler[3] = "Ilker"; 
//[,,,Ilker] gelir yukardaki ogrencilerin sahip oldugu isimler garbage C siler baglanti kopar

for (int i = 0; i< ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = new[] { "Ankara", "Istanbul", "Izmir" };
string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakir" };

sehirler2 = sehirler1; //sehirler2 nin refernasi esittir sehirler1 in referansi
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);

Console.WriteLine("----");

Person person = new Person();
person.FirstName = "Adem";
person.LastName = "Kok";
person.DateOfBirthYear = 1990;
person.NationalIdentity = 123;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person);


foreach(string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

List<string> yeniSehirler1 = new List<string> {"Ankara 1", "Istanbul 1", "Izmir 1"};
yeniSehirler1.Add("Adana 1");
foreach(string sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}

int sayi1 = 10;
int sayi2 = 20;
sayi2 = sayi1;
sayi1 = 30;
Console.WriteLine(sayi2);



Console.ReadLine();


static void SelamVer(string isim = "Jonas")
{
    Console.WriteLine("Merhaba " + isim);
}

static int Topla(int sayi1=5, int sayi2=10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam : " + sonuc);
    return sonuc;
}





