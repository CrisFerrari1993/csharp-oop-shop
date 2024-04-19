using System.Runtime.CompilerServices;

namespace csharp_oop_shop
{
    public class Prodotto 
    {
        //per creare numero random
        Random randi = new Random();

        private int _codice { get; }
        private string _nome { get; set; }
        private string _descrizione { get; set; }
        private double _prezzo { get; set; }
        private double _iva {  get; set; }

        // Costruttore
        public Prodotto(string nomeProdotto, string descrizioneProdotto, double prezzoProdotto, int ivaProdotto)
        {
            this._nome = nomeProdotto;
            this._codice = randi.Next(1, 10000);
            this._descrizione = descrizioneProdotto;
            this._prezzo = prezzoProdotto;
            this._iva = ivaProdotto;
        }

        public string nomeEsteso()
        {
            return $"{getCodice()}{this._nome}";
        }
        
        public string getCodice()
        {
            return this._codice.ToString().PadLeft(8, '0');
        }

        public string prezzoConIva()
        {
            return $"{(this._prezzo * (this._iva / 100)) + this._prezzo}";
        }

        public string GetPrezzo()
        {
            return $"{this._prezzo}";
        }


        

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Prodotto nokiaLumia = new Prodotto("Lumia 820", "Il nuovo smartphone di fascia medio-alta con Windows Phone 8.1", 499.87 , 22);
            Prodotto iphone = new Prodotto("Iphone15", "Il nuovo Iphone, più potente di sempre", 1024.00, 22);
            Prodotto tv = new Prodotto("SamsungTv 72\" ", "La nuova smart Tv samsung offre un immagine 4k a 120Hz per un immagine fluida e nitida grazie allo schermo OLED", 2599.99, 22);


            Console.WriteLine(iphone.nomeEsteso());
            Console.WriteLine(iphone.prezzoConIva());
            Console.WriteLine(iphone.GetPrezzo());

        }
    }
}
