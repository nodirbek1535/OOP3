namespace OOP.Classes
{
 public enum Baho
    {
        Alo = 5,
        Yaxshi = 4,
        Orta = 3,
        Yomon = 2
    }

    public class Oquvchi // Sinf nomini bosh harf bilan boshlash
    {
        public Guid Id { get; set; }
        public string Ism { get; set; }
        public string Familya { get; set; }
        public int Sinfi { get; set; }
        public Baho Bahosi { get; set; }

        // To'rt argument qabul qiladigan konstruktor
        public Oquvchi(string ism, string familya, int sinfi, Baho baho)
        {
            Id = Guid.NewGuid();
            Ism = ism;
            Familya = familya;
            Sinfi = sinfi;
            Bahosi = baho;
        }
         public override string ToString()
        {
            return $"{Ism} {Familya}, {Sinfi}-sinf, Baho: {Bahosi}";
        }
    }
}
