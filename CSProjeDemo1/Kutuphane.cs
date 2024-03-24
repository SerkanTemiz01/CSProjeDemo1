using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class Kutuphane
    {
       
        public List<Kitap> Kitaplar {  get; set; }
        public List<Uye> Uyeler {  get; set; }

        public Kutuphane()
        {
            Kitaplar = new List<Kitap> ();
            Uyeler = new List<Uye>();
        }

        public void KitapDurumGuncelle(Kitap kitap,Durum durum)
        {
            kitap.Durum=durum;
        }
        public void UyeEkle(Uye uye)
        {
            Uyeler.Add(uye);
            Console.WriteLine($"{uye.Ad} {uye.Soyad} isimli üye kütüphaneye eklendi");
        }
        public void KitapEkle(Kitap kitap)
        {
            Kitaplar.Add(kitap);
            Console.WriteLine($"{kitap.Baslik} isimli kitap kütüphaneye eklendi");
        }
        public List<Kitap> MevcutKitaplarıListele()
        {
            return Kitaplar;
        }
        public List<Kitap> OduncAlinanKitaplariListele()
        {
            return Kitaplar.Where(x => x.Durum == Durum.OduncVerildi).ToList();
        }
        public List<Uye> UyeleriListele()
        {
            return Uyeler;
        }
    }
}
