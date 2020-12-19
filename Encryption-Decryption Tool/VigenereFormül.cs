using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption_Decryption
{
    class VigenereSifrele
    {
       
        private string anahtar_kelime;
        
        private int anahtar_kelime_length;
        
        private int anahtar_kelime_sayac;
       
        private string kullanici_yazi;
        
        private string sifre_yazi;

        
        public VigenereSifrele(string anahtar_kelime, string sifre_yazi)
        {
            this.anahtar_kelime = anahtar_kelime;
            this.kullanici_yazi = sifre_yazi;
            this.anahtar_kelime_length = anahtar_kelime.Length;
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

       
        public bool AlfabetikKontrol()
        {
            bool sonuc = true;

            for (int i = 0, s = anahtar_kelime_length; i < s; i++)
            {
                if (char.IsLetter(anahtar_kelime[i]) && !TurkceKarakterKontrol(anahtar_kelime[i]))
                {
                    continue;
                }
                else
                {
                    sonuc = false;
                    break;
                }
            }

            return sonuc;
        }

        
        public string Sifrele()
        {
            // Metod her çalıştırıldığında sifre_yazi değişkenini boş hale getiriyorum
            sifre_yazi = "";
            anahtar_kelime_sayac = 0;

            for (int i = 0, s = kullanici_yazi.Length; i < s; i++)
            {
               
                if (char.IsLetter(kullanici_yazi[i]) && !TurkceKarakterKontrol(kullanici_yazi[i]))
                {
                  
                    int formul;

                    // büyük harfse bu formülü uygula
                    if (char.IsUpper(kullanici_yazi[i]))
                    {
                        formul = ((kullanici_yazi[i] - 65) + (char.ToUpper(anahtar_kelime[anahtar_kelime_sayac % anahtar_kelime_length]) - 65)) % 26;
                        sifre_yazi += (char)(formul + 65);
                        anahtar_kelime_sayac++;
                    }
                    // küçük harfse bu formülü uygula
                    else
                    {
                        formul = ((kullanici_yazi[i] - 97) + (char.ToLower(anahtar_kelime[anahtar_kelime_sayac % anahtar_kelime_length]) - 97)) % 26;
                        sifre_yazi += (char)(formul + 97);
                        anahtar_kelime_sayac++;
                    }
                }
               
                else
                {
                    sifre_yazi += kullanici_yazi[i];
                }
            }

            
            return sifre_yazi;
        }

      
        public string CozmeUygula()
        {
           // boş hale getirir
            sifre_yazi = "";
            anahtar_kelime_sayac = 0;

            for (int i = 0, s = kullanici_yazi.Length; i < s; i++)
            {
                
                if (char.IsLetter(kullanici_yazi[i]) && !TurkceKarakterKontrol(kullanici_yazi[i]))
                {
                    int formul;

                    // büyük harfse bu formülü uygula
                    if (char.IsUpper(kullanici_yazi[i]))
                    {
                        formul = ((kullanici_yazi[i] - 65) - (char.ToUpper(anahtar_kelime[anahtar_kelime_sayac % anahtar_kelime_length]) - 65)) % 26;
                        if (formul < 0)
                        {
                            formul += 26;
                        }

                        sifre_yazi += (char)(formul + 65);
                        anahtar_kelime_sayac++;
                    }
                    // küçük harfse bu formülü uygula
                    else
                    {
                        formul = ((kullanici_yazi[i] - 97) - (char.ToLower(anahtar_kelime[anahtar_kelime_sayac % anahtar_kelime_length]) - 97)) % 26;
                        if (formul < 0)
                        {
                            formul += 26;
                        }

                        sifre_yazi += (char)(formul + 97);
                        anahtar_kelime_sayac++;
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
