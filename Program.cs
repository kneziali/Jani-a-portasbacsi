using System.IO;


Console.WriteLine("Üdvözlöm portásbácsi");
Console.Write("Ember (1) - jármű (2) - Kilép (3) - Keresés (4): ");
int bejovo = int.Parse(Console.ReadLine());

string adatok = "";

File.AppendAllText("belepesek.txt", "Jani bácsi elindította a programot \n \n");
while (bejovo == 1 || bejovo == 2 || bejovo == 4)
{

    if (bejovo == 1)
    {
        Console.Write("Név: ");
        string nev = Console.ReadLine();

        Console.Write("Kor: ");
        int kor = int.Parse(Console.ReadLine());

        Console.Write("Személyazonosító igazolvány szám: ");
        string igazolvany = Console.ReadLine();
        while (igazolvany.Length != 8)
        {
            Console.Write("Adjon meg egy helyes személyazonosító igazolvány számot (pl. 123456AB): ");
            igazolvany = Console.ReadLine();
        }

        Console.Write("Látogatás célja: ");
        string cel = Console.ReadLine();

        DateTime belepes = DateTime.Now;

        adatok = $"================================\n{belepes.ToString("yyyy.MM.dd HH:mm:ss")}\nLátogató: Személy\nNév: {nev}\nKor: {kor}\nSzemélyi igazolvány szám: {igazolvany}\nLátogatás célja: {cel}\n================================\n";
        File.AppendAllText("belepesek.txt", adatok);


    }

    if (bejovo == 2)
    {
        Console.Write("Rendszám (kötőjellel): ");
        string rendszam = Console.ReadLine();
        while (rendszam.Length != 7 && rendszam.Length != 9)
        {
            Console.Write("Adjon meg egy helyes rendszámot (pl. ABC-123 vagy AA-AA-123): ");
            rendszam = Console.ReadLine();
        }
        Console.Write("Márka: ");
        string marka = Console.ReadLine();
        Console.Write("Típus: ");
        string tipus = Console.ReadLine();
        Console.Write("Szín: ");
        string szin = Console.ReadLine();
        Console.Write("Sofőr neve: ");
        string sofor = Console.ReadLine();
        Console.Write("Látogatás célja: ");
        string cel = Console.ReadLine();

        DateTime belepes = DateTime.Now;

        adatok = $"================================\n{belepes.ToString("yyyy.MM.dd HH:mm:ss")}\nLátogató: Jármű\nRendszám: {rendszam}\nMárka: {marka}\nTípus: {tipus}\nSzín: {szin}\nSofőr neve: {sofor}\nLátogatás célja: {cel}\n================================\n";
        File.AppendAllText("belepesek.txt", adatok);

    }

    if (bejovo == 4)
    {
        Console.Write("Keresés Név (1) - Rendszám (2) alapján: ");
        int nev_szam = int.Parse(Console.ReadLine());

        Console.Write("Keressen: ");
        string keresesiErtek = Console.ReadLine();

        Console.WriteLine("\nAdatok a keresés alapján:\n");

        bool talalat = false;

        if (nev_szam == 1)
        {
            //Nev alapjan
            if (File.Exists("belepesek.txt"))
            {
                string[] sorok = File.ReadAllLines("belepesek.txt");
                for (int i = 0; i < sorok.Length; i++)
                {
                    if (sorok[i].Trim() == ($"Név: {keresesiErtek.Trim()}"))
                    {
                        Console.WriteLine($"================================\n{sorok[i - 2]}\n{sorok[i - 1]}\n{sorok[i]}\n{sorok[i + 1]}\n{sorok[i + 2]}\n{sorok[i + 3]}\n================================\n");
                        talalat = true;
                    }
                }
            }
        }
        else if (nev_szam == 2)
        {
            //Rendszam alapjan
            if (File.Exists("belepesek.txt"))
            {
                string[] sorok = File.ReadAllLines("belepesek.txt");
                for (int i = 0; i < sorok.Length; i++)
                {
                    if (sorok[i].Trim() == ($"Rendszám: {keresesiErtek.Trim()}"))
                    {
                        Console.WriteLine($"================================\n{sorok[i - 2]}\n{sorok[i - 1]}\n{sorok[i]}\n{sorok[i + 1]}\n{sorok[i + 2]}\n{sorok[i + 3]}\n{sorok[i + 4]}\n{sorok[i + 5]}\n================================\n");
                        talalat = true;
                    }
                }
            }
        }

        if (talalat == false)
        {
            Console.WriteLine("Nincs találat!\n");
        }
    }

    if (bejovo == 3)
    {
        break;
    }

    Console.Write("Ember (1) - jármű (2) - Kilép (3) - Keresés (4): ");
    bejovo = int.Parse(Console.ReadLine());

}