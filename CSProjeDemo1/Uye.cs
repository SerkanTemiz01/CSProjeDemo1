using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class Uye : IUye
    {
        public string Ad { get ; set ; }
        public string Soyad { get; set; }
        public int UyeNo { get; set; }
        public List<Kitap> OduncKitaplar { get; set; }

        public Uye()
        {
            OduncKitaplar = new List<Kitap>();
        }

        public void KitapIadeEt(Kitap kitap)
        {
            if (OduncKitaplar.Contains(kitap))
            {
                kitap.Durum = Durum.OduncAlabilir;
                OduncKitaplar.Remove(kitap);
                Console.WriteLine($"{Ad} {Soyad} isimli üye,'{kitap.Baslik}' ");
            }
            else
            {
                Console.WriteLine("Bu kitap zaten sizde değil");
            }
        }

        public void KitapOduncAl(Kitap kitap)
        {
            if(kitap.Durum==Durum.OduncAlabilir)
            {
                kitap.Durum = Durum.OduncVerildi;
                OduncKitaplar.Add(kitap);
                Console.WriteLine($"{Ad} {Soyad} isimli üye,'{kitap.Baslik}' ");
            }
            else
            {
                Console.WriteLine("Bu kitap ödünç alınamaz");
            }
        }
    }
}
