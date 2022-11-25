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
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public string CodiceFiscale { get; set; }
        public string Sesso {get; set;}
        public string ComuneResidenza { get; set; }
        public double RedditoAnnuale { get; set; }

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
            Console.WriteLine("\n");
            Console.WriteLine("==================================");
            Console.WriteLine("CALCOLO DELL'IMPOSTA DA VERSARE");
            Console.WriteLine("\n");
            Console.WriteLine("Digita il nome:");
            Nome = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Digita il cognome:");
            Cognome = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Data di nascita (gg/mm/aaaa):");
            DataNascita = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Digita il Codice Fiscale");
            CodiceFiscale = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Sesso: M/F");
            string scelta = Console.ReadLine();
            if (scelta == "M")
            {
                Sesso = "Maschio";
            }
            else if (scelta == "F")
            {
                Sesso = "Femmina";
            }
            else
            {
                if (scelta != "M" | scelta != "F") 
                {
                    Console.WriteLine("Scelta non esatta, digita M o F");
                    Menu();
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Digita il comune di residenza:");
            ComuneResidenza = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Digita il reddito annuale:");
            RedditoAnnuale = double.Parse(Console.ReadLine());
            CalcolaImposta();
        }

        public void CalcolaImposta()
        {
            double imposta = CalcoloReddito(RedditoAnnuale);
            Console.WriteLine("\n");
            Console.WriteLine("================");
            Console.WriteLine("Riepilogo");
            Console.WriteLine("\n");
            Console.WriteLine($"Contribuente: {Nome} {Cognome}");
            Console.WriteLine($"Nato il:{DataNascita.ToString("dd/MM/yyyy")} ({Sesso})");
            Console.WriteLine($"Residente in: {ComuneResidenza}");
            Console.WriteLine($"Codice Fiscale:{CodiceFiscale}");
            Console.WriteLine("\n");
            Console.WriteLine($"Reddito Dichiarato: {RedditoAnnuale} Euro");
            Console.WriteLine("\n");
            Console.WriteLine($"IMPOSTA DA VERSARE: {imposta} Euro");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
        }
    }
}
