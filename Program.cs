using System;
using System.Collections.Generic;
namespace genericlist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);
            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");
            Console.WriteLine(sayiListesi.Count);
            Console.WriteLine(renkListesi.Count);
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));
            if(sayiListesi.Contains(10)){
            Console.WriteLine("10 lise içinde bulundu");}
            renkListesi.Sort();
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));
            string[] hayvanlar={"Kedi","Köpek","Kuş"};
            List<string> hayvanListesi=new List<string>(hayvanlar);
            hayvanListesi.Clear();
        List<Kullanıcılar> kullanıcıListesi=new List<Kullanıcılar>();
        Kullanıcılar kullanıcı1=new Kullanıcılar();
        kullanıcı1.Isim=("Ayşe");
        kullanıcı1.Soyisim=("Yılmaz");
        kullanıcı1.Yas=26;
        Kullanıcılar kullanıcı2=new Kullanıcılar();
         kullanıcı2.Isim="Özcan";
        kullanıcı2.Soyisim="Çalışkan";
        kullanıcı2.Yas=26;
        kullanıcıListesi.Add(kullanıcı1);
        kullanıcıListesi.Add(kullanıcı2);
        List<Kullanıcılar> yeniListe=new List<Kullanıcılar>();
        yeniListe.Add(new Kullanıcılar(){
        Isim="Deniz",
        Soyisim="Arda",
        Yas=24  
        });
        foreach(Kullanıcılar kullanıcı in kullanıcıListesi){
            Console.WriteLine("Kullanıcı Adı:"+kullanıcı.Isim);
            Console.WriteLine("Kullanıcı Soyadı:"+kullanıcı.Soyisim);
            Console.WriteLine("Kullanıcı Yaşı:"+kullanıcı.Yas);
            
        }
        
        
        
        
        
        }
        public class Kullanıcılar{
            string isim;
             string soyisim;
             int yas;

            public string Isim { get => isim; set => isim = value; }
            public string Soyisim { get => soyisim; set => soyisim = value; }
            public int Yas { get => yas; set => yas = value; }
        }
    }
}
        
        
        
        
        
        
