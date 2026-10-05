namespace consoEnergieDataCenter;

class Program
{
    static void Main(string[] args)
    {
        double consommation = 100;          // variables aléatoires
        double objectif = consommation * 2;
        int annees = 0;

        while (consommation < objectif)
        {
            consommation = consommation * 1.08;
            annees++;
        }

        Console.WriteLine($"Il faut {annees} années pour doubler la consommation.");
    }
}