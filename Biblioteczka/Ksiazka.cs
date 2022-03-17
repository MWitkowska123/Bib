using System;

namespace Biblioteczka
{
    class Ksiazka : Publikacja
    {
        string tytul;
        EnumDziedzina dziedzina;

        private string Tytul
        {
            get => tytul;
            set
            {
                if (value.Length < 1 || !char.IsUpper(value[0]))
                {
                    throw new FormatTytuleException();
                }
                tytul = value;
            }
        }

        public EnumDziedzina Dziedzina { get => dziedzina; set => dziedzina = value; }

        public Ksiazka() : base()
        {

        }

        public Ksiazka(DateTime dataWydania, decimal cenaPodstawowa, string tytul, EnumDziedzina dziedzina) : base(dataWydania, cenaPodstawowa)
        {
            if (dziedzina == EnumDziedzina.ekonomia)
            {
                Sygnatura = Sygnatura + "-E";
            }
            else if (dziedzina == EnumDziedzina.informatyka)
            {
                Sygnatura = Sygnatura + "-I";
            }
            else
            {
                Sygnatura = Sygnatura + "-Z";
            }

            this.tytul = tytul;
            this.dziedzina = dziedzina;
        }



        public override decimal ObliczCene()
        {
            if (dziedzina == EnumDziedzina.ekonomia)
            {
                return base.ObliczCene() + 50;
            }
            else if (dziedzina == EnumDziedzina.informatyka)
            {
                return base.ObliczCene() + 100;
            }
            else
            {
                return base.ObliczCene() + 20;
            }
        }



        public override string ToString()
        {
            string wyjsce = Sygnatura + ", " + ObliczCene().ToString("C") + ", " + DataWydania.ToString("dd-MMM-yyyy") + ", \"" + tytul + "\", " + dziedzina;
            return wyjsce;
        }
    }
}
