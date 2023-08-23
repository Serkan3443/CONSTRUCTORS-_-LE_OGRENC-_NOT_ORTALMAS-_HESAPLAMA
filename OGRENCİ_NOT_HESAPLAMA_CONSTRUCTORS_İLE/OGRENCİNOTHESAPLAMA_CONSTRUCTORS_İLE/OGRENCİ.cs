using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGRENCİNOTHESAPLAMA_CONSTRUCTORS_İLE
{
    public class OGRENCİ
    {
        //SABİT ALANLAR
        const decimal _VIZECARPAN1 = 0.4M;
        const decimal _VIZECARPAN2 = 0.4M;
        const decimal _FİNAL = 0.6M;

        //HAREKETLİ ALANLAR
        decimal _vize1;
        decimal _vize2;
        decimal _final;
        decimal _ortalama;
        string _durum;


        //ÖZELLİK
        public string Adi { get; set; }
        public string Soyadi { get; set; }

        public OGRENCİ(string adi, string soyadi, decimal vize1, decimal vize2, decimal final)
        {
            Adi = adi;
            Soyadi = soyadi;
            _vize1 = vize1;
            _vize2= vize2;
            _final = final;
        }
        public void OrtalamaHesapla()
        {
            _ortalama = (_VIZECARPAN1 * _vize1) + (_VIZECARPAN2 * _vize2) + (_FİNAL * _final);
            _durum = "Kaldı";
        }
        public string Getir()
        {
            string sonuc = $"AD ve SOYAD:{Adi}{Soyadi}";
            sonuc += $"\nNot Ortalaması:{_ortalama.ToString("N1")}";
            sonuc += $"\nDurumu:\"{_durum}\"";
            return sonuc;

        }
    }
}




