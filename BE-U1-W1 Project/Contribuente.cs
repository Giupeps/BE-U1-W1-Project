using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BE_U1_W1_Project
{
    internal class Contribuente
    {
        private string Nome { get; set; }
        private string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        private string CodiceFiscale { get; set; }
        private string Sesso {get; set;}
        private string ComuneResidenza { get; set; }
        private double RedditoAnnuale { get; set; }

        public Contribuente() { }
        public Contribuente(string nome, string cognome, DateTime dataNascita, string codiceFiscale, string sesso, string comuneResidenza, double redditoAnnuale)
        {
            Nome = nome;
            Cognome = cognome;
            DataNascita = dataNascita;
            CodiceFiscale = codiceFiscale;
            Sesso = sesso;
            ComuneResidenza = comuneResidenza;
            RedditoAnnuale = redditoAnnuale;
        }

        public double CalcoloReddito(double RedditoAnnuale)
        {
            if (RedditoAnnuale <= 15000)
            {
                return RedditoAnnuale * 0.23;
            }
            else if (RedditoAnnuale > 15000 && RedditoAnnuale <= 28000) 
            {
                return 3450 + ((RedditoAnnuale - 15000) * 0.27);
            }
            else if (RedditoAnnuale > 28000 && RedditoAnnuale <= 55000)
            {
                return 6960 + ((RedditoAnnuale - 28000) * 0.38);
            }
            else if (RedditoAnnuale > 55000 && RedditoAnnuale <= 75000)
            {
                return 17220 + ((RedditoAnnuale - 55000) * 0.41);
            }
            else if (RedditoAnnuale > 75000)
            {
                return 25420 + ((RedditoAnnuale - 75000) * 0.43);
            }
            else
            {
                return 0.00;
            }
            
        }

        public void Menu()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("CALCOLO DELL'IMPOSTA DA VERSARE");
            Console.WriteLine("Digita il nome:");
            Nome = Console.ReadLine();
            Console.WriteLine("Digita il cognome:");
            Cognome = Console.ReadLine();
            Console.WriteLine("Data di nascita (giorno/mese/anno):");
            DataNascita = DateTime.Parse(Console.ReadLine());
            

        }

    }
}
