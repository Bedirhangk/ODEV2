using System.Collections;
using System.Diagnostics;
using System.Reflection;

namespace ODEV2;

class Program
{
    static void Main(string[] args)
    {
        // soru1();
        
        //soru2();

        soru3();
    }

    private static void soru1()
    {
        Console.WriteLine("--------------------Soru 1-----------------------");
        
        int sayac=0,tmp;
        ArrayList tek =new ArrayList();
        ArrayList çift =new ArrayList();
        while(sayac<20)
        {
            try
            {
                Console.Write("Pozitif bir Sayı girin: ");
                tmp=int.Parse(Console.ReadLine());
                Console.WriteLine();
                if(tmp<=0)
                {
                    Console.WriteLine("GİRDİĞİNİZ SAYI POZİTİF DEĞİL LÜTFEN POZİTİF BİR SAYI GİRİNİZ");
                }
                else
                {
                    sayac++;
                    if(tmp%2==0)
                        çift.Add(tmp);
                    else
                        tek.Add(tmp);
                } 

            }
            catch (System.Exception)
            {
                Console.WriteLine("Lütfen Sadece Sayı Girin");
            }
        }

        tek.Sort();
        çift.Sort();

        Console.WriteLine("Tek Sayılar:");
        foreach (var a in tek)
        {
            Console.WriteLine(a);
        }

        Console.WriteLine();

        Console.WriteLine("çift Sayılar:");
        foreach (var a in çift)
        {
            Console.WriteLine(a);
        }

        Console.WriteLine();

        tmp=0;
        Console.WriteLine("---------------Tek Sayılar-----------------");
        Console.WriteLine("Tek Sayıların Adeti: "+ tek.Count);
        foreach (int item in tek)
        {
            tmp+=item;
        }
        Console.WriteLine("Tek Sayıların Ortalaması: "+ tmp/tek.Count);

        tmp=0;
        Console.WriteLine("---------------Çift Sayılar-----------------");
        Console.WriteLine("Çift Sayıların Adeti: "+ çift.Count);
        foreach (int item in çift)
        {
            tmp+=item;
        }
        Console.WriteLine("Çift Sayıların Ortalaması: "+ tmp/çift.Count);
        
        
    }

    private static void soru2()
    {
        int sayac=0,tmp;
        List<int> sayilar = new List<int>();
        int [] büyüks = new int [3];
        int [] küçüks = new int [3];
        while(sayac<20)
        {
            try
            {
                Console.Write("Bir Sayı girin: ");
                tmp=int.Parse(Console.ReadLine());
                Console.WriteLine();
                sayilar.Add(tmp);
                sayac++;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Lütfen Sadece Sayı Girin");
            }
        }

        sayilar.Sort();
        for (int i = 0; i < 3; i++)
            küçüks[i]=sayilar[i];
        
        int syc=0;
        for(int i = sayilar.Count;i>sayilar.Count-3;i--)
        {
            büyüks[syc]=sayilar[i-1];
            syc++;
        }

        int tmpk=0,tmpb=0;
        foreach (var item in küçüks)
        {
            tmpk+=item;
        }
        foreach (var item in büyüks)
        {
            tmpb+=item;
        }
        Console.WriteLine("Küçüklerin ORT: "+tmpk/küçüks.Count());
        Console.WriteLine("Büyüklerin ORT:"+tmpb/büyüks.Count());
        Console.WriteLine("Ort toplamları: "+((tmpk/küçüks.Count())+(tmpb/büyüks.Count())));


    }

    private static void soru3()
    {
        Console.WriteLine("-------------------soru 3----------------------");

        string? cümle;
        int sayac=0;
        Console.Write("Bir Cümle Girin: ");
        cümle=Console.ReadLine();
        
        cümle.ToLower();
        List<char> sesli=new List<char>();

        for (int i = 0; i < cümle.Length; i++)
        {
            if(cümle[i]=='a'||cümle[i]=='e'||cümle[i]=='ı'||cümle[i]=='i'||cümle[i]=='o'||cümle[i]=='ö'||cümle[i]=='u'||cümle[i]=='ü')
            {
                sesli.Add(cümle[i]);
                sayac++;
            }
        }

        Console.WriteLine();

        Console.WriteLine("Toplam {0} adet sesli harf bulunuyor bunlar; ",sayac);

        Console.WriteLine();
        
        foreach (var item in sesli)
        {
            Console.WriteLine(item);
            Console.WriteLine();
        }
    }
}
