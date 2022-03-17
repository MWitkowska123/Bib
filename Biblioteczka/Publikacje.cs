using System;

namespace Biblioteczka
{
    class Publikacja
    {
        static int indeks;
        static decimal cenaDodatkowa;
        string sygnatura;
        DateTime dataWydania;
        decimal cenaPodstawowa;

        public int Indeks { get => indeks; set => indeks = value; }
        public decimal CenaDodatkowa { get => cenaDodatkowa; set => cenaDodatkowa = value; }
        public DateTime DataWydania { get => dataWydania; set => dataWydania = value; }
        public string Sygnatura { get => sygnatura; set => sygnatura = value; }
        public decimal CenaPodstawowa { get => cenaPodstawowa; set => cenaPodstawowa = value; }


        static Publikacja()
        {
            indeks = 1;
            cenaDodatkowa = 1.5M;
        }

        public Publikacja()
        {
            if (indeks < 10)
            {
                sygnatura = $"SYG-0000{indeks++}";
            }
            else if (indeks < 100)
            {
                sygnatura = $"SYG-000{indeks++}";
            }
            else if (indeks < 1000)
            {
                sygnatura = $"SYG-00{indeks++}";
            }
            else if (indeks < 10000)
            {
                sygnatura = $"SYG-0{indeks++}";
            }
            else
            {
                sygnatura = $"SYG-{indeks++}";
            }
        }

        public Publikacja(DateTime dataWydania, decimal cenaPodstawowa) : this()
        {
            this.dataWydania = dataWydania;
            this.cenaPodstawowa = cenaPodstawowa;
        }

        public virtual decimal ObliczCene()
        {
            int liczba = DateTime.Now.Year - dataWydania.Year;
            return cenaPodstawowa + cenaDodatkowa * liczba;
        }

        public override string ToString()
        {
            string wyjsce = sygnatura + ", " + ObliczCene().ToString("c") + ", " + dataWydania.ToString("dd-MMM-yyyy");
            return wyjsce;
        }

        internal Publikacja Clone()
        {
            throw new NotImplementedException();
        }
    }
}
