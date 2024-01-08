using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siniflar
{
    public class barinak 
    {
        public static List<barinak> barinaklar = new List<barinak>();
        

        public int barinakID {  get; set; }
        public string barinakad {  get; set; }
        public string barinakadres { get; set; }
        public int barinakbuyukluk {  get; set; }
        public static void barinakEkle(string barinakadi ,string barinakadres, int barinakbuyukluk, int barinakID)
        {
            barinak yenibarinak = new barinak();
            yenibarinak.barinakID = barinakID;
            yenibarinak.barinakad = barinakadi;
            yenibarinak.barinakadres = barinakadres;
            yenibarinak.barinakbuyukluk = barinakbuyukluk;
            barinaklar.Add(yenibarinak);
        }
         

    }
}
