namespace DailyPlanner;

public class Zadanie
{
    public string Nazwa { get; set; }
    public string Kategoria { get; set; }
    public bool CzyUkonczone { get; set; }

    public Zadanie(string nazwa, string kategoria)
    {
        Nazwa = nazwa;
        Kategoria = kategoria;
        CzyUkonczone = false;

    }
}