using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Biblioteczka
{
    class Biblioteczka : ZapisBinarny
    {
        string nazwa;
        List<Publikacja> publikacje;

        public string Nazwa { get => nazwa; set => nazwa = value; }
        internal List<Publikacja> Publikacje { get => publikacje; set => publikacje = value; }

        public Biblioteczka()
        {
            nazwa = null;
            publikacje = new List<Publikacja>();
        }

        public Biblioteczka(string nazwa)
        {
            this.nazwa = nazwa;
            publikacje = new List<Publikacja>();
        }

        public Biblioteczka(string nazwa, Publikacja publikacja)
           : this(nazwa)
        {
            Dodaj(publikacja);
        }

        public void Wstaw(int indeks, Publikacja publikacja)
        {
            this.publikacje[indeks] = publikacja;
        }

        public void Dodaj(Publikacja c)
        {
            publikacje.Add(c);
        }


        public void Usun(int indeks)
        {
            //publikacje.Remove(indeks);
        }

        public void Zamien(Publikacja stara, Publikacja nowa)
        {
            int index = this.publikacje.IndexOf(stara);
            if (index >= 0)
            {
                this.publikacje[index] = nowa;
            }
        }

        public override string ToString()
        {
            string wyjsce = "";
            wyjsce += Nazwa + Environment.NewLine;
            foreach (var publikacja in publikacje)
            {
                wyjsce += publikacje.ToString() + Environment.NewLine;
            }
            return wyjsce;
        }

        public void ZapiszBin(string nazwa)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream($"{nazwa}.out", FileMode.Create))
            {
                formatter.Serialize(stream, this);
            }
        }
        public object OdczytajBin(string nazwa)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            object biblioteczka;

            using (FileStream stream = new FileStream($"{nazwa}.out", FileMode.Open))
            {
                biblioteczka = formatter.Deserialize(stream);
            }
            return biblioteczka;
        }
    }
}
