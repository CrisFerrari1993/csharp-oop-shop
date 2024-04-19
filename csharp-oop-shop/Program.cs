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
        public Prodotto(string nomeProdotto, string descrizioneProdotto, double prezzoProdotto, double ivaProdotto)
        {
            this._nome = nomeProdotto;
            this._codice = randi.Next(1, 10000);
            this._descrizione = descrizioneProdotto;
            this._prezzo = prezzoProdotto;
            this._iva = ivaProdotto;
        }
        
        //Per mostrare il codice concatenato al nome
        public string nomeEsteso()
        {
            return $"{getCodice()}{this._nome}";
        }
        //Per mostrare il codice con il PadLeft per il bonus
        public string getCodice()
        {
            return this._codice.ToString().PadLeft(8, '0');
        }
        //Ritrona il prezzo sommato all'iva
        public string prezzoConIva()
        {
            return $"{(this._prezzo * (this._iva / 100)) + this._prezzo}";
        }

        public string GetName()
        {
            return $"{this._nome}";
        }
        public void SetName(string name)
        {
           this._nome =  name;
        }
        public string GetPrezzo()
        {
            return $"{this._prezzo}";
        }
        public void SetPrezzo(double prezzo)
        {
            this._prezzo = prezzo;
        }
        public string GetDescrizione()
        {
            return $"{this._descrizione}";
        }
        public void SetDescrizione(string desc)
        {
            this._descrizione = desc;
        }
        public string GetIva()
        {
            return $"{(this._prezzo / 100 * (this._iva)).ToString()}" ;
        }
        public void SetIva(double iva)
        {
            this._iva = iva;
        }




    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Prodotto nokiaLumia = new Prodotto("Lumia 820", "Il nuovo smartphone di fascia medio-alta con Windows Phone 8.1", 300 , 22.00);
            

            
            

            Console.WriteLine(nokiaLumia.GetName());
            Console.WriteLine(nokiaLumia.prezzoConIva());
            Console.WriteLine(nokiaLumia.GetDescrizione());
            Console.WriteLine(nokiaLumia.GetIva());
            Console.WriteLine(nokiaLumia.GetPrezzo());

        }
    }
}
