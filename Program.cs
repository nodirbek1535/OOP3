using OOP.Classes;
using OOP1.Classes;
using OOP2.Classes;
using System.Collections.Generic;
// // O'quvchilar ro'yxati yaratish
// List<OOP.Classes.Oquvchi> oquvchilar = new List<OOP.Classes.Oquvchi>
//     {
//     new OOP.Classes.Oquvchi("Ali", "Valiyev", 10, OOP.Classes.Baho.Alo),
//     new OOP.Classes.Oquvchi("Aziza", "Karimova", 9, OOP.Classes.Baho.Yaxshi),
//     new OOP.Classes.Oquvchi("Bekzod", "Ismoilov", 11, OOP.Classes.Baho.Orta),
//     new OOP.Classes.Oquvchi("Dilnoza", "Rasulova", 9, OOP.Classes.Baho.Alo),
//     new OOP.Classes.Oquvchi("Jasur", "Abdullayev", 10, OOP.Classes.Baho.Yomon)
//     };
List<Oquvchi> oquvchilar = new List<Oquvchi>();
Console.WriteLine("salom oquvchillarni royxatini shakllanntiramiz nechta oquvchi kiritasiz:");
int soni=int.Parse(Console.ReadLine());
for(int i=0;i<soni;i++)
{
    Console.WriteLine((i+1)+"-oquvchini ismini kiriting:");
    string ism=Console.ReadLine();
    Console.WriteLine((i+1)+"-oquvchini familyasini kiriting:");
    string familya=Console.ReadLine();
    Console.WriteLine((i+1)+"-oquvchini sinfini kiriting:");
    int sinf=int.Parse(Console.ReadLine());
    Console.WriteLine((i+1)+"-oquvchini bahoni kiriting (5=A'lo, 4=Yaxshi, 3=O'rta, 2=Yomon): ");
    Baho baho=(Baho)Enum.Parse(typeof(Baho), Console.ReadLine(), true);
    Oquvchi yangiOquvchi = new Oquvchi(ism, familya, sinf, baho);
    oquvchilar.Add(yangiOquvchi);
    Console.WriteLine("O'quvchi qo'shildi: " + yangiOquvchi);
}
Console.WriteLine("Keling oquvchilarni bahosi booyicha qidiramiz");
Console.WriteLine("Bahoni kiriting (5=A'lo, 4=Yaxshi, 3=O'rta, 2=Yomon): ");
int bahoKirit = int.Parse(Console.ReadLine());
OOP.Classes.Baho kiritilganBaho = (OOP.Classes.Baho)bahoKirit;
List<OOP.Classes.Oquvchi> mosOquvchilar = oquvchilar.FindAll(o => o.Bahosi == kiritilganBaho);
if(mosOquvchilar.Count==0)
{
    Console.WriteLine("bunday oquvchilar mavjud emas");
}
else
{
Console.WriteLine("Topilgan o'quvchilar");
foreach (OOP.Classes.Oquvchi oquvchi in mosOquvchilar)
{
    Console.WriteLine(oquvchi.Ism + " " + oquvchi.Id);
}
}



Console.WriteLine("Avtomobillar tanlovi");
List<Avtomobillar> avtomobilar=new List<Avtomobillar>();
Console.WriteLine("Salom avtomobillarning royxatini shakllantirish nechta avtomobil kiritasiz:");
int soni2=int.Parse(Console.ReadLine());
for(int i=0;i<soni2;i++)
{
    Console.WriteLine("Markasini kiritinf Masalan(Mersedes Benz): ");
    string markasi=Console.ReadLine();
    Console.WriteLine("Nomini rusumini kiriting: ");
    string nomi=Console.ReadLine();
    Console.WriteLine("narxini kiriting");
    int narxi=int.Parse(Console.ReadLine());
    Avtomobillar yangiavtomobil=new Avtomobillar(markasi,nomi,narxi);
    avtomobilar.Add(yangiavtomobil);
    Console.WriteLine("avtomobil qoshildi: "+yangiavtomobil);
}
Console.WriteLine("keling avtomobillarni saralaymiz, pastnarxni kiriting:");
int pastnarx=int.Parse(Console.ReadLine());
Console.WriteLine("yuqorinarxni kiriting:");
int yuqorinarx=int.Parse(Console.ReadLine());
Avtomobillar avtomobilObj = new Avtomobillar("", "", 0); // Bo'sh obyekt yaratish
avtomobilObj.avtomobillarnitanlash(pastnarx, yuqorinarx, avtomobilar);



Console.WriteLine("Boks musobaqasi");
List<Tartiblash> royxat=new List<Tartiblash>();
Console.WriteLine("necha nafar bokschi mavjud");
int bokschilarsoni=int.Parse(Console.ReadLine());
for(int i=0;i<bokschilarsoni;i++)
{
    Console.WriteLine((i+1)+"-bokschining familyasini kiriting:");
    string familya=Console.ReadLine();
    Console.WriteLine((i+1)+"-bokschining ismini kiriting:");
    string ism=Console.ReadLine();
    Console.WriteLine((i+1)+"-bokschining yoshini kiriting:");
    int yosh=int.Parse(Console.ReadLine());
    Console.WriteLine((i+1)+"-bokschining  vaznini kiriting:");
    double vazn=double.Parse(Console.ReadLine());
    Tartiblash yangiroyxat=new Tartiblash(familya,ism,yosh,vazn);
    royxat.Add(yangiroyxat);
    Console.WriteLine("bokschi qoshildi");
}
Console.WriteLine("siz qaysi vazndagi bokschilarni saralamoqchisiz(yengil,orta,ogir yoki barchasi (tartib bilan))");
string royxatturi=Console.ReadLine();
Tartiblash tartiblashobj=new Tartiblash("","",0,0);
List<Tartiblash> bokschilar=new List<Tartiblash>();
if(royxatturi=="yengil")
{
    tartiblashobj.yengilvaznlilarnisaralash(royxat);
}
else if(royxatturi=="orta")
{
    tartiblashobj.ortavaznlilarnisaralash(royxat);
}
else if(royxatturi=="ogir")
{
     tartiblashobj.ogirvaznlilarnisaralash(royxat);
}
else if(royxatturi=="barchasi")
{
     tartiblashobj.yengilvaznlilarnisaralash(royxat);
     tartiblashobj.ortavaznlilarnisaralash(royxat);
     tartiblashobj.ogirvaznlilarnisaralash(royxat);
}
