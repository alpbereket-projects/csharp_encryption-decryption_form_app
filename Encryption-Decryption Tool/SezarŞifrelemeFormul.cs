using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption_Decryption
{
    public class SezarSifrele
    {
        
        private byte anahtar_sayi;
        
        private string kullanici_yazi;
        
        private string sifre_yazi; 

       
        public SezarSifrele(byte anahtar_sayi, string sifre_yazi)
        {
            this.anahtar_sayi = anahtar_sayi;
            this.kullanici_yazi = sifre_yazi;
        }

        // ASCII tablosu kullanarak şifreleme yaptığım için, Türkçe karakterleri kontrol etmek adına bool fonksiyon yazıyorum
        private bool TurkceKarakterKontrol(char karakter)
        {
            if (karakter == 'ç' || karakter == 'Ç' || karakter == 'ğ' || karakter == 'Ğ' || karakter == 'ı' || karakter == 'İ' || karakter == 'ö' || karakter == 'Ö' || karakter == 'ş' || karakter == 'Ş' || karakter == 'ü' || karakter == 'Ü')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // "Sifrele" metodunu kullanarak yazının şifrelenmiş halini gönderiyorum
        public string Sifrele()
        {
            
            sifre_yazi = "";

            for (int i = 0, s = kullanici_yazi.Length; i < s; i++)
            {
                // Eğer karakterler harf ise ve Türkçe karakter değilse Sezar şifreleme formülü uygulanıyor
                if (char.IsLetter(kullanici_yazi[i]) && !TurkceKarakterKontrol(kullanici_yazi[i]))
                {
                    
                    int formul;

                    // Karakter büyük harfse bu formülü uygula
                    if (char.IsUpper(kullanici_yazi[i]))
                    {
                        formul = ((kullanici_yazi[i] - 65) + anahtar_sayi) % 26;
                        sifre_yazi += (char)(formul + 65);
                    }
                    // Karakter küçük harfse bu formülü uygula
                    else
                    {
                        formul = ((kullanici_yazi[i] - 97) + anahtar_sayi) % 26;
                        sifre_yazi += (char)(formul + 97);
                    }
                }
                // Eğer karakterler harf değilse ve Türkçe ise, olduğu gibi sifre_yazi değişkenine aktarılıyor
                else
                {
                    sifre_yazi += kullanici_yazi[i];
                }
            }

            
            return sifre_yazi;
        }

        
        public string SifreCoz()
        {
            
            sifre_yazi = "";

            for (int i = 0, s = kullanici_yazi.Length; i < s; i++)
            {
                // Eğer karakterler harf ise ve Türkçe karakter değilse Sezar şifreleme formülü uygulanıyor
                if (char.IsLetter(kullanici_yazi[i]) && !TurkceKarakterKontrol(kullanici_yazi[i]))
                {
                    
                    int formul;

                    // Karakter büyük harfse bu formülü uygula
                    if (char.IsUpper(kullanici_yazi[i]))
                    {
                        formul = ((kullanici_yazi[i] - 65) - anahtar_sayi) % 26;
                        if (formul < 0)
                        {
                            formul += 26;
                        }

                        sifre_yazi += (char)(formul + 65);
                    }
                    // Karakter küçük harfse bu formülü uygula
                    else
                    {
                        formul = ((kullanici_yazi[i] - 97) - anahtar_sayi) % 26;
                        if (formul < 0)
                        {
                            formul += 26;
                        }
                            
                        sifre_yazi += (char)(formul + 97);
                    }
                }
                
                else
                {
                    sifre_yazi += kullanici_yazi[i];
                }
            }

            
            return sifre_yazi;
        }
    }
}