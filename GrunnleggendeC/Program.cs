namespace GrunnleggendeC;

class Program
{
    static void Main(string[] args)
    {
        // Oppgave2
        // Lag en variabel av datatypen integer og tildel den et vilkårlig heltall
        int a = 44;
        // Lag en variabel av datatypen string og tilden en vilkårlig tekst
        string b = "Her har vi et string";
        // Lag en variabel av datatypen double og tilden et vilkårlig tall, både desimal og heltall er gyldig med denne typen
        double c = 3.533;
        // Lag en variabel av datatypen char og tildel den en vilkårlig karakter(bokstav)
        char d = 'ø';
        // Lag et Array av datatypen integer og skriv ut verdiene med en vanlig for-løkke
        int[] arr = [2, 4, 6, 8, 10, 12, 14, 16];
        foreach (int num in arr) { Console.WriteLine(num); }
        ;
        // Lag et Array av datatypen string og skriv ut verdiene med en foreach-løkke
        string[] arr2 = ["Hi", "den", "skal", "jeg", "bare", "prøve"];
        foreach (string ord in arr2) { Console.WriteLine(ord); }
        ;
        // Lag en List av datatypen string og tildel verdier ved hjelp av List sin inne bygde metode "Add()"
        List<string> lists = new List<string> { "Hello World", "Ingen Ny", "Hokus Pokus", "Helt Fint", "Så Flink" };
        // myExampleList.Add("min string");
        lists.Add("En til");
        // Legg til flere strings i listen deres
        lists.Add("Kommer en andre");
        lists.Add("Nå slitter jeg");
        lists.Add("Alt for mye");
        // Skriv ut verdiene i listen ved hjelp av en foreach-løkke
        foreach (string utr in lists) { Console.WriteLine(utr); }
        ;
    }
}
