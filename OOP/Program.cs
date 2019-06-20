using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 1-Ders Sınıf Tasarımı
            Console.WriteLine("1-Ders Sınıf Tasarımı");
            Ders1Ogrenci ogr1 = new Ders1Ogrenci();
            ogr1.Ad = "emre";
            ogr1.yas = 18;
            ogr1.Yazdir();
            #endregion

            Console.WriteLine("-----------------------");


            #region 2-Ders Referans, This Operatörü, Namespace
            Console.WriteLine("2-Ders Referans, This Operatörü, Namespace");
            Ders2Ogrenci ogr2 = new Ders2Ogrenci();
            ogr2.VeriGir(18, 4);
            #endregion

            Console.WriteLine("-----------------------");


            #region 3-Ders Metoddların Aşırı Yüklenmesi
            Console.WriteLine("3-Ders Metodların Aşırı Yüklenmesi");
            Ders3Ogrenci ogr3 = new Ders3Ogrenci();
            ogr3.VeriGir(20);
            ogr3.VeriGir(18, 4);

            int intsonuc = Ders3MathExaples.UstAl(2, 5);
            double doublesonuc = Ders3MathExaples.UstAl(2.4, 5);
            Console.WriteLine("2' üzeri 5 : " + intsonuc.ToString());
            Console.WriteLine("2.4' üzeri 5 : " + doublesonuc.ToString());
            #endregion

            Console.WriteLine("-----------------------");


            #region 4-Ders Erişim Berlileyiciler
            Console.WriteLine("4-Ders Erişim Belirleyiciler");
            Ders4ErisimBelirleyiciler Eb = new Ders4ErisimBelirleyiciler();
            Eb.publicVariables1 = 1;
            Eb.internalVariables3 = 3;
            Eb.protectedInternalVariables5 = 5;
            Console.WriteLine(" " + Eb.publicVariables1 + " " + Eb.internalVariables3 + " " + Eb.protectedInternalVariables5);
            #endregion

            Console.WriteLine("-----------------------");


            #region 5-Ders Constructors (Yapıcı Metodlar)
            Console.WriteLine("5-Ders Constructors Yapıcı Metodlar");
            Ders5Ucret maas = new Ders5Ucret(2);
            decimal AlinacakUcret = maas.UcretiHesapla();
            Console.WriteLine(AlinacakUcret);
            #endregion

            Console.WriteLine("-----------------------");

            #region 6-Ders Static Metodlar
            Console.WriteLine("6-Ders Static Metodlar");
            Ders6StaticMetod.motor = 20;
            Console.WriteLine("Static Metoda Direk Erişim " + Ders6StaticMetod.motor);
            int ValueForm = Ders6StaticMetod.Otobüs();
            Console.WriteLine("Metod Dönüşü " + ValueForm);
            Ders6StaticMetod st = new Ders6StaticMetod();
            st.Otomobil();
            #endregion

            Console.WriteLine("-----------------------");

            #region 7-Ders Ref Out Referans
            Console.WriteLine("7-Ders Ref Out Anahtar Kelimeler");
            int[] array = { 0, 15, 25, 40, 88 };
            int index = 0;
            int enBuyuk = Ders7RefOut.Ders7RefoutEnBuyugunuBul(array, ref index);
            Console.WriteLine("En Büyük Sayi : " + enBuyuk + " , " + " İndex Numarası " + index);
            #endregion

            Console.WriteLine("-----------------------");

            #region Ders8Encapsulation
            Console.WriteLine("8-Ders Encapsulation");
            Ders8Encapsulation Encapsulation = new Ders8Encapsulation();
            Console.WriteLine("Boyut değişkenin Get Metodu İle Oku " + Encapsulation.Boyut);
            Encapsulation.Boyut = 20;
            Console.WriteLine("Kare'nin Alanı : " + Encapsulation.Alan);
            #endregion

            Console.WriteLine("-----------------------");

            #region 1-Exaples Sıralama Algoritması
            Console.WriteLine("Sıralama Algoritması");
            string[,] a = new string[3, 3];
            int X = 3;
            int T = 3;
            int O = 3;
            Random rastgele = new Random();
            int controller = 0;
            List<ListItem> listeElemani = new List<ListItem>();
            listeElemani.Add(new ListItem("X", X));
            listeElemani.Add(new ListItem("X", T));
            listeElemani.Add(new ListItem("X", O));
            listeElemani.Add(new ListItem("T", X));
            listeElemani.Add(new ListItem("T", T));
            listeElemani.Add(new ListItem("T", O));
            listeElemani.Add(new ListItem("O", X));
            listeElemani.Add(new ListItem("O", T));
            listeElemani.Add(new ListItem("O", O));
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    controller = rastgele.Next(listeElemani.Count);
                    a[i, j] = (listeElemani[controller].name);
                    listeElemani.RemoveAt(controller);
                }
            }
            SortingAlgorithm.ArrayWrite(a);
            #endregion

            Console.WriteLine("-----------------------");

            #region Ders9Inharitance
            Console.WriteLine("Inharitance - Miras Alma");
            Ders9Exaples2Kare kare = new Ders9Exaples2Kare();
            kare.X = 10;
            kare.Y = 20;
            kare.AlaniYaz();
            Ders9Exaples2Dikdortgen dortgen = new Ders9Exaples2Dikdortgen();
            dortgen.X = 10;
            dortgen.Y = 30;
            dortgen.AlaniYaz();
            Console.WriteLine("----");
            Ders9Exaples2Kare kareOne = new Ders9Exaples2Kare();
            Ders9Exaples2Kare kareTwo = new Ders9Exaples2Kare(22, 33);
            #endregion

            Console.WriteLine("-----------------------");

            #region 2-Exaples Rastsal Sayi 6
            Console.WriteLine("Rastgele Sayı Üretme 6 Adet" +
                "");
            Random rastgeleDeger = new Random();
            for (int i = 0; i < 6; i++)
            {
                int sayi = rastgele.Next(1, 50);
                Console.WriteLine(sayi.ToString());
            }
            #endregion

            Console.WriteLine("-----------------------");

            #region Ders10UpcastDownCast
            Console.WriteLine("10-Ders Upcast & DownCast");
            Ders10FotografMakinesi d10SFotoMakina1 = new Ders10FotografMakinesi();
            Ders10DslFotografMakinası d10DslrFotoMakina1 = new Ders10DslFotografMakinası();

            d10SFotoMakina1.FotografCek();
            d10DslrFotoMakina1.FotografCek();
            d10DslrFotoMakina1.UzunPozlamaFotografCek();

            //Upcasting
            //Upcasting "Ders10DslFotografMakinası" -Sınıfı- Normal "Ders10FotografMakinesi" Üzerinden -Türeyen- Bir sınıf Buda Demek oluyor ki "Ders10DslFotografMakinası" doğal olarak bir "Ders10FotografMakinesi"'dır.
            //Burada bir sınırlama karşımıza çıkmaktadır. "Ders10DslFotografMakinası" normal bir  "Ders10FotografMakinesi" atadığımız için, bu nesne sadece "Ders10FotografMakinesi" yapabildiği işlemleri yapacaktır.
            Ders10FotografMakinesi d10Kullanilan1 = d10DslrFotoMakina1;
            d10Kullanilan1.FotografCek();
            //İkinci Kullanım  
            //Ders10FotografMakinesi d10Kullanilan2 = new Ders10DslFotografMakinası();
            //d10Kullanilan2.FotografCek();


            //DownCast
            //Ders10DslFotografMakinası d10Kullanilan2 = d10Kullanilan1; Hata Alırız
            //Çünkü Base Class tipindeki bir değişkeni kendisini türeten bir yapıya nasıl atanır bilemeyecektir.
            //Bizim bu değişkenin hangi alt class'tan olduğunu belirtmemiz gerekiyor.
            Ders10DslFotografMakinası d10Kullanilan2 = (Ders10DslFotografMakinası)d10Kullanilan1;
            d10Kullanilan2.UzunPozlamaFotografCek();

            //Özet
            //Base'den Child'a doğru gidilen sınıf yapısında Base olan sınıflar Child olan sınıfların ne iş yaptığını bilemez.
            //Base sınıfları özel tarzda bir değişkene atadığımız zaman buna DownCasting denir.
            //Tersi duruma, yani child'dan Base Sınıfa doğru çıkılan durumlarda upcasting denir.


            #endregion

            Console.WriteLine("-----------------------");
            Console.WriteLine("-----------------------");
            Console.WriteLine("-----------------------");
            Console.WriteLine("-----------------------");
            Console.WriteLine("-----------------------");
            Console.ReadKey();
        }
    }


    #region 1-Ders Sınıf Tasarımı
    //1- Ders Sınıf Tasarımı
    //Ogrenci ogr1 = referanstır. ve Hafızaya çıkartılırsa Nesne Olur.
    //New Ogrenci()  = hafızaya cıkartırılır. Nesne Oluşuturulur. Instancesi Alınır.
    //Nesneler Referansız Kullanılamazlar.
    class Ders1Ogrenci
    {
        public int yas;
        public string Ad;
        public void Yazdir()
        {
            Console.WriteLine("{0} 'nin yaşi {1} dir", Ad, yas);
        }
    }
    #endregion

    #region 2-Ders Referans, This Operatörü, Namespace
    //Namespace = Uzay Alanı İsmidir. Kod Gruplama Süreçlerine Yardımcı olur.
    //Namespace = Aynı İsimlerin Farklı Ekipler Tarafından Kullanabilmesi için Geliştirilmiştir.
    //This = Nesnenin Direk Referansına yada Alanlarına Erişmemize Sağlar
    class Ders2Ogrenci
    {
        public int yas;
        public int sinif;
        public void VeriGir(int newYas, int newSinif)
        {
            this.yas = newYas;
            this.sinif = newSinif;
            Console.WriteLine("Yaş " + yas + " - " + "Sınıf " + sinif);
        }
    }
    #endregion

    #region 3-Ders Metodların Aşırı Yüklenmesi
    //Aynı ismi farklı Parametreler kombinasyonları kullanıldığı sürece tekrardan tanımlanabilir.
    //Bu işleme metotların aşırı yüklenmesi adı verilir.
    //Muhakkak Girdi Parametleri Farklı Olmak Zorundadır.
    class Ders3Ogrenci
    {
        public int yas;
        public int sinif;
        public void VeriGir(int newYas, int newSinif)
        {
            this.yas = newYas;
            this.sinif = newSinif;
        }
        public void VeriGir(int newYas)
        {
            Random rnd = new Random();
            this.sinif = rnd.Next();
            this.yas = newYas;
        }
    }

    class Ders3MathExaples
    {
        public static int UstAl(int taban, int us)
        {
            int sonuc = 1;
            for (int i = 0; i < us; i++)
            {
                sonuc *= taban;
            }
            return sonuc;
        }

        public static double UstAl(double taban, int us)
        {
            double sonuc = 1;
            for (int i = 0; i < us; i++)
            {
                sonuc *= taban;
            }
            return sonuc;
        }
    }
    #endregion

    #region 4-Ders Erişim Berlileyiciler
    //Public             : Her Yerden Erişilebilinir.
    //Private            : Sadece Tanımlandığı Scope'den Erişebilinir.
    //Internal           : Sadece Bulunduğu Projeden Erişebilinir.
    //Protected          : Sadece Tanımladığı Sınıftan Yada o Sınıfı Miras Alan Sınıflardan Erişebilinir.
    //Protected Internal : Tanımlandığı Sınıftan yada Miras Alnınan Sınıflardan Erişebilinir. Aynı Projede Olma Şartı Yokur.
    class Ders4ErisimBelirleyiciler
    {
        public int publicVariables1;
        private int privateVarialbes2;
        internal int internalVariables3;
        protected int protectedVariables4;
        protected internal int protectedInternalVariables5;
    }
    #endregion

    #region 5-Ders Constructors (Yapıcı Metodlar)
    //Nesneler Sınıfların Canlandırılmış Halledirdir.
    //Bir sınıfı nesne şeklinde instance edip bu nesne aracılığı ile kullanırız.
    //Bir sınıftan nesne oluşturulduğunda nesneyi hazırlayan yordamlar oluşur. Bunlara Yapıcı(Constructors) adı verilmektedir.
    //Constructors dışarıdan veri alabilir. Ancak direk değer döndürmez
    //Bir sınıftan nesne oluşturduğumuzda yapılması gereken işlemler bu yordamlar yani Constructors (Yapılandırıcılar) ile gerçekleşmektedir.
    //Constructors'ler (Yapılandırıcılar) nesneleri oluşturmak için new operatörü ile birlikte tetiklenmektedir.
    //Dışarıdan erişilebilinmesi için Public olarak tanımlanması gerekmektedir.
    //Bir sınıftan instance oluşturması engellemek için private olarakda kullanılabilinmektedir.

    public class Ders5Ucret
    {
        public decimal mesai;
        public Ders5Ucret(byte newUcretGroupID)
        {
            if (newUcretGroupID == 1)
            {
                mesai = 50;
            }
            if (newUcretGroupID == 2)
            {
                mesai = 100;
            }
        }
        public decimal UcretiHesapla()
        {
            decimal ucret = 1600;
            byte fazlaCalisilianSaat = 15;
            return ((fazlaCalisilianSaat * mesai) + ucret);
        }
    }
    #endregion

    #region 6-Ders Static Metodlar
    //Static Metodlar ait oldukları sınıftan bir nesne oluşturulmadan kullanılabilirler.
    //Console.Writeline Static bir metod'dur.
    //Statik bir üyeye erişebilmek için ilgili class için bir instance almadan ulaşabileceğimizi, hatta instance aldıktan sonra bu üyelere ulaşamadığımızı anımsayabiliriz.
    //İçinde sadece statik üye olan bir class var ise bu class’tan nesne oluşturamayacağımız anlamına gelmemektedir.
    //Statik tanımlanmayan değişkenlere erileşemez.
    //Statik değişkene erişebilinir.
    //Static değişkenlere global değişkenler diyebiliriz. “static” bir değişkeni tüm üyeler kullanabilir.
    //Yani değeri her yerde aynıdır. Değişken kullanılmadan önce ilk değer ataması yapılır.
    //Eğer ilk değer ataması yapılmazsa nümerik değerler 0, nesne referansları null, bool değişkenler ise false değeri alırlar. 
    //Static bir metodun this referansı olamaz. “static” bir metot yalnızca kendi sınıfı tarafından tanımlanan static değişkenlere erişebilir.
    //Bir sınıfa ait olan özelliklere ilk değerleri atmak için kullanılır.
    //Static sınıflar nesne oluşturamaz ve yalnızca static üyeler barındırabilirler.
    class Ders6StaticMetod
    {
        //Static olarak tanımlanan değişken
        public static int motor = 1000;
        public int benzin = 20;

        //Static olarak tanımlanan Metod
        public static int Otobüs()
        {
            //int newbenzin = benzin; //Statik Olmayan Değişkene Erişilemez
            return motor / 2;
        }

        public void Otomobil()
        {
            Console.WriteLine("Sınıf İçersinde Otomobil Metodu " + motor);
        }
    }
    #endregion

    #region 7-Ders Ref Out Referans
    class Ders7RefOut
    {
        #region Değerler Referans Olmayan Tipli Örneği
        //Altaki İfade de Static DefDegistir Metodu Referans Bazlı Aldığı İçin Değişkenlerin Köklerine Erişim Sağlayamaz ve Bu Yüzden İçerik Değişmez
        static void DefDegistir(int a, int b)
        {
            int temp = b; ;
            b = a;
            a = temp;
        }
        static void DefMain()
        {
            int a = 10;
            int b = 20;
            Ders7RefOut.DefDegistir(a, b);  // İfade Bunun Gibidir===> Ders7RefOut.DefDegistir(10,20);
            Console.WriteLine("{0} - {1}", a, b);
        }
        #endregion
        //Ref ve Out Anahtar Kelimeler sayesinde Parametlerin Değerleri Değiştirilebilinmektedir.
        #region Ref Örneği
        //Burada Metod'da  Parametlerinde ve Method Çağrılırken Ref ile Referansları verilerek direk Kullanılır
        //İlk Değer Atanmamış Değişkenler Referans Olarak Verilemezler
        static void RefDegistir(ref int a, ref int b)
        {
            int temp = b; ;
            b = a;
            a = temp;
        }
        static void RefMain()
        {
            int a = 10;
            int b = 20;
            Ders7RefOut.RefDegistir(ref a, ref b);
            Console.WriteLine("{0} - {1}", a, b);
        }
        #endregion

        #region Out Örneği
        //Burada Metod'da  Parametlerinde ve Method Çağrılırken Out ile  Referansları verilerek direk Kullanılır
        //Ref Anahtar kelimesi yerine Out Kullanıldığında Değişkene Değer Atamaya Gerek Kalmaz
        static void OutDegistir(out int a, out int b)
        {
            a = 20;
            b = 10;
            int temp = b;
            b = a;
            a = temp;
        }
        static void OutMain()
        {
            int a;
            int b;
            Ders7RefOut.OutDegistir(out a, out b);
            Console.WriteLine("{0} - {1}", a, b);
        }
        #endregion

        #region RefOut Exaples Two
        public static int Ders7RefoutEnBuyugunuBul(int[] array, ref int index)
        {
            int enBuyuk = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (true)
                {
                    if (enBuyuk < array[i])
                    {
                        enBuyuk = array[i];
                        index = i;
                    }
                }
            }
            return enBuyuk;
        }
        #endregion
    }
    #endregion

    #region 8-Ders Encapsulation & Properties & Getter,Setter
    //Ürünlerin İç Dizaynının Kullanıcılar ve Yazılımcılar'dan Saklanma işlemine İçerik Gizleme Yada Kapsülleme(Encapsulation) adı verilir.
    #region Not1Properties
    //Get ve Set'ler Properties Adı Veriler.
    //Properties'lerin(Getter Setter) Amaçları, Sınıftaki private ve protected elemanlara değer atamank veya değerleri okumak için get ve set metotları kullanılır.
    //Get veriyi okumamıza yarar
    //set veriyi değiştirmemize yarar
    class Ders8Encapsulation
    {
        private int yas = 15;
        public int Yas
        {
            get
            {
                return yas;
            }
            set
            {
                yas = value;
            }
        }

        private int boyut;
        private int numara;
        public int Boyut
        {
            get
            {
                return boyut;
            }
            set
            {
                Console.WriteLine("Set Metodu Aktif Oldu");
                if (value < 0)
                {
                    Console.WriteLine("-------Boyut 0'dan Küçük Olamaz");
                    boyut = 10;
                }
                else
                {
                    boyut = value;
                }
                Console.WriteLine("Boyut : " + boyut);
            }
        }

        public int Alan
        {
            get
            {
                return boyut * boyut;
            }
        }
    }
    #endregion

    #endregion

    #region 1-Exaples Sıralama Algoritması
    public class SortingAlgorithm
    {
        public static void ArrayWrite(string[,] dizi)
        {
            Console.WriteLine("Rectangular Dizi içindeki veriler:");
            for (int satir = 0; satir < dizi.GetLength(0); satir++)
            {
                for (int sutun = 0; sutun < dizi.GetLength(1); sutun++)
                {
                    Console.Write("{0} ", dizi[satir, sutun]);
                }
                Console.WriteLine();
            }
        }
    }
    public class ListItem : IComparable<ListItem>
    {
        public string name;
        public int keyValues;

        public ListItem(string newName, int newKeyValues)
        {
            name = newName;
            keyValues = newKeyValues;
        }

        public int CompareTo(ListItem other)
        {
            if (other == null)
            {
                return 1;
            }

            return keyValues - other.keyValues;
        }
    }
    #endregion

    #region  9-Ders Inheritance & Miras-Kalıtım
    class Ders9Exaples1InheritanceDemirbas
    {
        protected int demirbasNo;
        protected string zimmetli;
        protected string bina;
        protected int odaNo;
    }
    class Ders9Exaples1InheritanceKitap : Ders9Exaples1InheritanceDemirbas
    {
        private string ISBN;
        private DateTime basimTarihi;
    }
    class Ders9Exaples1InheritanceBilgisayar : Ders9Exaples1InheritanceDemirbas
    {
        private DateTime AlinmaTarihi;
        private int ramMiktari;
        private string islemci;
    }
    class Ders9Exaples1InheritanceProjeksiyon : Ders9Exaples1InheritanceDemirbas
    {
        private string marka;
        private string cozunurluk;
    }

    class Ders9Exaples2Sekil
    {
        private int x;
        private int y;
        private int alan;
        private int cevre;
        public int Cevre
        {
            get
            {
                return cevre;
            }
            set
            {
                cevre = value;
            }
        }
        public int Alan
        {
            get
            {
                return alan;
            }
            set
            {
                alan = value;
            }
        }
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public Ders9Exaples2Sekil()
        {
            Console.WriteLine("Şekil() Çağrıldı");
        }

        public Ders9Exaples2Sekil(int newX, int newY)
        {
            X = newX;
            Y = newY;
            Console.WriteLine("Şekil" + " - " + X + " - " + Y + " Çağrıldı");
        }

        public void AlaniYaz()
        {
            Console.WriteLine("Koordinatlar " + x + " - " + y + " olan şeklin alanı... : " + Alan);
        }
    }
    class Ders9Exaples2Kare : Ders9Exaples2Sekil
    {
        private int boyut;
        public int Boyut
        {
            get
            {
                return boyut;
            }
            set
            {
                boyut = value;
            }
        }

        public Ders9Exaples2Kare()
        {
            Console.WriteLine("Kare() Çağrıldı");
        }

        public Ders9Exaples2Kare(int newPX, int newPY) : base(newPX, newPY)
        {
            Console.WriteLine("Kare" + " - " + newPX + " - " + newPY + " Çağrıldı");
        }

        public int AlanHesapla()
        {
            return boyut * boyut;
        }
    }

    class Ders9Exaples2Dikdortgen : Ders9Exaples2Sekil
    {
        private int genislik;
        private int yukseklik;
        public int Genislik
        {
            get
            {
                return genislik;
            }
            set
            {
                genislik = value;
            }
        }
        public int Yukseklik
        {
            get
            {
                return yukseklik;
            }
            set
            {
                yukseklik = value;
            }
        }
    }

    #endregion

    #region 10-Ders Upcast DownCast & Dönüşümler
    public class Ders10FotografMakinesi
    {
        public void FotografCek()
        {
            Console.WriteLine("Standart Makina Fotoğraf'ı Çekildi");
        }
    }

    public class Ders10DslFotografMakinası : Ders10FotografMakinesi
    {
        public void FotografCek()
        {
            Console.WriteLine("Fotoğraf Çekildi");
        }

        public void UzunPozlamaFotografCek()
        {
            Console.WriteLine("Uzun Pozlama Fotoğraf Çekildi");
        }
    }
    #endregion

}
