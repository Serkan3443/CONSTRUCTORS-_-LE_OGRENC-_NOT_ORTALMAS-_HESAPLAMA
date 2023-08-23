namespace OGRENCİNOTHESAPLAMA_CONSTRUCTORS_İLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BİR ÖĞRENCİNİN VİZE1, VİZE2, FİNAL SINAVLARININ ORTALAMASINA GÖRE DURUMUNU SÖYLEYEN KOD
            OGRENCİ ogrenci = new OGRENCİ("Serkan", "Kabadayıoğulları",50,40,30 );
            ogrenci.OrtalamaHesapla();
            Console.WriteLine(ogrenci.Getir());

        }
    }
}