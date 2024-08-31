using System.Data;

namespace OOP1.Classes
{
    public class Avtomobillar
    {
       
        public string Markasi{get ; set ;}
        public string Nomi{get ; set ;}
        public int Narxi{get ; set ;}
            
        public Avtomobillar(string markasi,string nomi,int narxi)
        {
            Markasi=markasi;
            Nomi=nomi;
            Narxi=narxi;
        }
        public override string ToString()
        {
            return $"{Markasi} {Nomi}, {Narxi}";
        }
        public void avtomobillarnitanlash(int pastnarx,int yuqorinarx,List<Avtomobillar> avtomobilar)
        {
            foreach (var avtomobil in avtomobilar)
            {
                bool topildi=false;
                if (avtomobil.Narxi >= pastnarx && avtomobil.Narxi <= yuqorinarx)
                {
                    Console.WriteLine(avtomobil);
                    topildi=true;
                }
                if(!topildi)
                {
                    Console.WriteLine("hech qanday avtomobil topilmadi");
                }
            }
        }
    }
}

// Bir necha xil yengil avtomobillar nomi, markalari va ularning narxlari berilgan. 
// Foydalanuvchi 2 ta narx kiritadi. Keyin ulardan narxi shu oraliqdagi narxli avtomobil haqidagi ma’lumotlarni chop etuvchi dastur tuzing.
// Ma’lumotlar bazasi sifatida list yoki arraydan foydalanishingiz mumkin.
