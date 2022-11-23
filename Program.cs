internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("lütfen bir sayı giriniz");
        //birden başlayarak konsoldan girilen sayıların ortalaması(While)
        int x=Convert.ToInt32(Console.ReadLine());
        int sayac=1;
        int toplam=0;
       while (sayac<=x)
       {
        toplam+=sayac;

        sayac++;


       }
       Console.WriteLine(toplam/x);

       char character='a';
       while (character<'z')
       {
        Console.WriteLine(character);
        character++;
        
       }

       //Foreach
       string [] araba={"bmv","ford","toyota","nissan"};
       foreach (var item in araba)
       {
        Console.WriteLine(item);
        
       }
    }

}