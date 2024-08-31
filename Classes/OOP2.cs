namespace OOP2.Classes
{
    class Tartiblash
    {
        public Guid ID;
        public string Familya;
        public string Ism;
        public int Yosh;
        public double Vazn;
        public Tartiblash(string familya,string ism,int yosh,double vazn)
        {
            ID=Guid.NewGuid();
            Familya=familya;
            Ism=ism;
            Yosh=yosh;
            Vazn=vazn;
        }
        public override string ToString()
        {
            return $"{ID}  {Familya} {Ism}  {Yosh}   {Vazn} kg";
        }
        public void yengilvaznlilarnisaralash(List<Tartiblash> royxat )
        {   bool topildi=false;
            Console.WriteLine("yengil vazndagi bokschilar:");
            foreach (var yengiltartib in royxat)
            {
                
                if (yengiltartib.Vazn<50)
                {
                    Console.WriteLine(yengiltartib);
                    topildi=true;
                }
            }
                if(!topildi)
                {
                    Console.WriteLine("bunday vazndagi bokschilar topilmadi");
                }
        }
        public void ortavaznlilarnisaralash(List<Tartiblash> royxat )
        {    bool topildi=false;
             Console.WriteLine("orta vazndagi bokschilar:");
            foreach (var ortatartib in royxat)
            {
                
                if (ortatartib.Vazn<76 && ortatartib.Vazn>50 )
                {
                    Console.WriteLine(ortatartib);
                    topildi=true;
                }
            }
                if(!topildi)
                {
                    Console.WriteLine("bunday vazndagi bokschilar topilmadi");
                }
        }
        public void ogirvaznlilarnisaralash(List<Tartiblash> royxat )
        {    bool topildi=false;
             Console.WriteLine("ogir vazndagi bokschilar:");
            foreach (var ogirtartib in royxat)
            {
                
                if (ogirtartib.Vazn>76)
                {
                    Console.WriteLine(ogirtartib);
                    topildi=true;
                }
            }
                if(!topildi)
                {
                    Console.WriteLine("bunday vazndagi bokschilar topilmadi");
                }
        }
    }
}

// 3.Vazifa

// Bokschilar ro’yhati berilgan: bokschining Id, familiyasi, ismi, yoshi va vazni.
// Yengil(50 kg gacha), O’rta(50 dan 76kg gacha) va og’ir(90 kg va undan og’irlar) vaznli boxchilarni saralab chiqarib beruvchi dastur tuzilsin.
// Ma’lumotlar bazasi sifatida list yoki arraydan foydalanishingiz mumkin.

