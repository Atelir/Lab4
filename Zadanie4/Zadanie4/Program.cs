using System;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            var tph = new TPHKontekst();
            tph.Osoby.Add(new Pracownik() { Imie = "Micheal", Nazwisko = "Jackson", DataZatrudnienia = DateTime.Now.AddDays(-15), DataZwolnienia = DateTime.Now });
            tph.Osoby.Add(new Pracownik() { Imie = "Yoko", Nazwisko = "Tarou", DataZatrudnienia = DateTime.Now.AddDays(-300), DataZwolnienia = null});
            tph.Osoby.Add(new Klient() { Imie = "Marilyn", Nazwisko = "Monroe", NrTelefonu = "111-222-333", NrRejestracyjny = "LA010626" });
            tph.Osoby.Add(new Klient() { Imie = "Kamil", Nazwisko = "Stoch", NrTelefonu = "333-222-111", NrRejestracyjny = "PL418563" });
            tph.SaveChanges();

            var tpt = new TPTKontekst();
            tpt.Osoby.Add(new Pracownik() { Imie = "Tetsuya", Nazwisko = "Nomura", DataZatrudnienia = DateTime.Now.AddDays(-1000), DataZwolnienia = DateTime.Now.AddDays(-1)});
            tpt.Osoby.Add(new Pracownik() { Imie = "Adam", Nazwisko = "Malysz", DataZatrudnienia = DateTime.Now.AddDays(-20), DataZwolnienia = null });
            tpt.Osoby.Add(new Klient() { Imie = "Geralt", Nazwisko = "z Rivii", NrTelefonu = "666-999-666", NrRejestracyjny = "PL18052015" });
            tpt.Osoby.Add(new Klient() { Imie = "Gabe", Nazwisko = "Newell", NrTelefonu = "000-888-000", NrRejestracyjny = "USA3111962" });
            tpt.SaveChanges();
        }
    }
}
