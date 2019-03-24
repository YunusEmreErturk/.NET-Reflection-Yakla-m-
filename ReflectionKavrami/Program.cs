using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

//@Author Yunus Emre Erturk ===> yemrerturk@gmail.com / www.muhendiserturk.com

//Assembly kavramı=> .NET ortamında yazılan programlar derlenirken
//programa ait olan tüm elemanlar, metotlar, sınıflar, değişkenler metadata dediğimiz bilgiler ile birlikte
//derlenmektedir. Kaynak kodların ve metadata bilgilerinin bulunduğu .NET birimini assembly olarak
//adlandırabiliriz. Yani aslında derlenmiş her birim assembly adını alır. Bunlar exe ve dll dosyalarıdır.

//Çalışan programımız içinde bir assembly olabileceği gibi birden fazla assembly de olabilir.
//Programımızda birden fazla assembly olması demek programımızın ilişkide olduğu bir ya da daha fazla dll dosyası mevcut demektir.
//System isim alanındaki AppDomain sınıfı çoklu assembly işlemleriyle ilgilenirken, 
//System.Reflection isim alanındaki Assembly sınıfı ise tek bir assembly ile ilgili işlemler yapılmasını sağlar. 

//Şimdi bu iki sınıfın çeşitli özelliklerini inceleyelim:


//AppDomain sınıfının static CurrentDomain özelliği o an üzerinde çalışılan assembly grubunu bir AppDomain nesnesi olarak döndürür.
//AppDomain sınıfının static olmayan GetAssemblies() metodu, ilgili AppDomain nesnesindeki bütün assemblyleri bir Assembly dizisi olarak tutar.
//Assembly sınıfının static olmayan Location özelliği ilgili assemblynin sabit diskteki yolunu string olarak verir.
//Yaptığım örnek 1 gösterilecek.


//Reflection sınıfı(yansıma) program çalışma esnasında assembly içindeki yani programın tamamının içindeki 
//oluşturulmuş olan class, method gibi tüm türler hakkında bilgi almamızı sağlayan sınıftır. 


//Reflection .NET'in çok güçlü bir özelliğidir.Yaptığı iş ile hangi türü sorgulamak istiyorsa bu türe ait 
//olan metadata bilgileri çekilir, tüm bu işlem sürecinde System.Reflection kütüphanesini kullanır 
//ve bu üzerinde çalışılan türü System.Type nesnesi ile temsil eder.
//Type sınıfı aslında soyut bir sınıftır MemberInfo sınıfından türemiştir ve bir çok metota sahiptir. 
//Tür üyeleri hakkında bilgi edinilebilir, tür üyeleri çağırılabilir, Assembly'den tür yüklenebilir, nesne oluşturulabilir.




namespace ReflectionKavrami
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            //AppDomain ad = AppDomain.CurrentDomain;
            //Assembly[] assembly = ad.GetAssemblies();
            //Console.WriteLine("Toplam assembly sayısı: " + assembly.Length);
            //for (int i = 0; i < assembly.Length; i++)
            //{
            //    Console.WriteLine("Assembly yeri: " + assembly[i].Location);
            //}




            //AppDomain ad = AppDomain.CurrentDomain;
            //Assembly[] assembly = ad.GetAssemblies();
            //for (int i = 0; i < assembly.Length; i++)
            //{
            //    Console.WriteLine("Assembly: " + assembly[i].Location);
            //    Console.WriteLine("Tür sayısı: " + assembly[i].GetTypes().Length);
            //    Console.WriteLine("*******");
            //}

            //Ornek 3 Sınıflar içersindeki methotların bilgilerini Reflection altındaki MethodInfo ile gosterme
            //Type t = typeof(Array);
            //Type t = typeof(List<>);
            //Type t = typeof(Math);
            //MethodInfo[] mInfo = t.GetMethods();

            //int counter = 0;

            //foreach (MethodInfo item in mInfo)
            //{
            //    Console.WriteLine("Metodun adı : " + item.Name);
            //    Console.WriteLine("Return type : " + item.ReturnType);

            //    if (item.IsStatic)
            //    {
            //        Console.WriteLine("Bu metot statik");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Bu metot statik değil");
            //    }

            //    Console.WriteLine();
            //    counter++;
            //}
            //Console.WriteLine("Toplam " + counter + " adet metodu var..");



            //Ornek 4 Sınıflar altındaki tüm bileşenlerin bilgilerini Reflection altındaki MemberInfo ile gosterme.
            //Type t = typeof(List<>);
            //MemberInfo[] mInfo = t.GetMembers();

            //int counter = 0;

            //foreach (MemberInfo item in mInfo)
            //{
            //    Console.WriteLine("Member Adı : " + item.Name);
            //    Console.WriteLine("Member Tipi : " + item.MemberType);
            //    Console.WriteLine(item.DeclaringType); // Beraber ogrenelim

            //    Console.WriteLine();
            //    counter++;
            //}
            //Console.WriteLine("Toplam " + counter + " adet Member'i var..");


            //----------------------------------------------------------------------------
            //ParameterInfo Sınıfı : Bir metottaki parametreleri görebiliriz.
            //ConstructorInfo Sınıfı : Bir türün yapıcı metotları hakkında bilgi verir.
            //PropertyInfo Sınıfı : Bir türün özellikleri hakkında bilgi verir.
            //FieldInfo Sınıfı : Bir türün değişkenleri hakkında bilgi verir.
            //EventInfo Sınıfı : Bir türün olayları hakkında bilgi verir.
            //----------------------------------------------------------------------------

            //ornek 5 Kendi olusturdugum deneme sınıfı içersindeki constructor bilgileri
            //Type t = typeof(deneme);
            //ConstructorInfo[] cInfo = t.GetConstructors();

            //int counter = 0;

            //foreach (ConstructorInfo item in cInfo)
            //{
            //    Console.WriteLine("MemberType : " + item.MemberType);
            //    Console.WriteLine("Attributes : " + item.Attributes);

            //    Console.WriteLine();
            //    counter++;
            //}
            //Console.WriteLine("Toplam " + counter + " adet Constructor var..");

            //Ornek 6 kendi olusturudugum deneme sınıfı icindeki field incelemeleri
            //Type t = typeof(deneme);
            //FieldInfo[] fInfo = t.GetFields();

            //int counter = 0;

            //foreach (FieldInfo item in fInfo)
            //{
            //    Console.WriteLine("Tur adi : " + item.MemberType);
            //    Console.WriteLine("Degisken adi : " + item.Name);
            //    Console.WriteLine("Private mi ? : " + item.IsPrivate);
            //    Console.WriteLine("Public mi ? :" + item.IsPublic);
            //    Console.WriteLine("Static mi ? :" + item.IsStatic);

            //    Console.WriteLine();
            //    counter++;
            //}
            //Console.WriteLine("Toplam " + counter + " adet degiskeni var..");

            //Ornek 7 kendi olusturdugum deneme sinifi icerisindeki property bilgileri
            Type t = typeof(Array);
            PropertyInfo[] mInfo = t.GetProperties();

            int counter = 0;

            foreach (PropertyInfo item in mInfo)
            {
                Console.WriteLine("Property tipi :" + item.PropertyType);
                Console.WriteLine("Property adi :" + item.Name);

                Console.WriteLine();
                counter++;
            }
            Console.WriteLine("Toplam " + counter + " adet Property var..");


            Console.ReadKey();
        }
    }
    public class deneme
    {
        public int c=3;
        public int d;
        public double e;
        

        public deneme()
        {
            int c = 3;
            int d;
            double e;

        }

        public deneme(int a)
        {

        }
    }
}
//COK ONEMLI NOT !

 /* Özellikle geniş çaplı projelerde örneğin sizin yapmış olduğunuz
    bir asıl uygulama olmuş olsun.Ve bu uygulama geliştirime açık bir uygulama olmuş olsun.Bu uygulamayı
    geliştirebilmek için de herkese fırsat verdiğinizi düşünün.Farklı farklı kişiler uygulamanız için eklentiler
    geliştirebilirler, ki biz bunlara plugin diyoruz.Bu plugin için oluşturulan dll yapısını
    görüntülemek, hangi metotlar kullanılmış görmek,
    hangi değişkenler var görmek vs vs gibi işlemler için işte Reflection oldukça önemlidir.*/