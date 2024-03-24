using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public interface IUye
    {
        string Ad { get; set; }
        string Soyad { get; set; }
        int UyeNo { get; set; }
        List<Kitap> OduncKitaplar { get; set; }

        void KitapOduncAl(Kitap kitap);
        void KitapIadeEt(Kitap kitap);
    }
}
