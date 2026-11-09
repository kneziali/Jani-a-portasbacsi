using System.IO;

bool checkIgazolvany(string igazolvany)
{

    if (igazolvany.Length != 8)
    {
        return false;
    }

    int step = 0;
    foreach (char karakter in igazolvany)
    {

        step += 1;
        if (step <= 6)
        {
            if (char.IsLetter(karakter))
            {
                return false;
            }
        }
        else if (step > 6)
        {
            if (char.IsDigit(karakter))
            {
                return false;
            }
        }


    }

    return true;
}

bool checkRendszam(string rendszam)
{

    if (rendszam.Length != 7 && rendszam.Length != 9)
    {
        return false;
    }

    int step = 0;
    foreach (char karakter in rendszam)
    {
        step += 1;
        if (rendszam.Length == 7)
        {
            //elso branch // ABC-123
            if (step <= 3)
            {
                if (char.IsDigit(karakter))
                {
                    return false;
                }
            }
            else if (step == 4)
            {
                if (karakter != '-')
                {
                    return false;
                }
            }
            else if (step > 4)
            {
                if (char.IsLetter(karakter))
                {
                    return false;
                }
            }

        }
        else if (rendszam.Length == 9)
        {
            //masodik branch //AA-AA-123
            if (step <= 2 || step == 4 || step == 5)
            {
                if (char.IsDigit(karakter))
                {
                    return false;
                }
            }
            else if (step == 3 || step == 6)
            {
                if (karakter != '-')
                {
                    return false;
                }
            }
            else if (step > 6)
            {
                if (char.IsLetter(karakter))
                {
                    return false;
                }
            }
        }

    }

    return true;
}

Console.WriteLine("Üdvözlöm portásbácsi");
Console.Write("Ember (1) - Jármű (2) - Kilép (3) - Keresés (4): ");
int bejovo = int.Parse(Console.ReadLine());

string adatok = "";

File.AppendAllText("belepesek.txt", "Jani bácsi elindította a programot \n \n");
while (bejovo == 1 || bejovo == 2 || bejovo == 4)
{

    if (bejovo == 1)
    {
        Console.Write("Név: ");
        string nev = Console.ReadLine();

        Console.Write("Személyazonosító igazolvány szám: ");
        string igazolvany = Console.ReadLine();
        while (true)
        {
            if (checkIgazolvany(igazolvany))
            {
                break;
            }
            Console.Write("Adjon meg egy helyes személyazonosító igazolvány számot (pl. 123456AB): ");
            igazolvany = Console.ReadLine();

        }

        DateTime belepes = DateTime.Now;

        adatok = $"================================\n{belepes.ToString("yyyy.MM.dd HH:mm:ss")}\nLátogató: Személy\nNév: {nev}\nSzemélyi igazolvány szám: {igazolvany}\n================================\n";
        File.AppendAllText("belepesek.txt", adatok);


    }

    if (bejovo == 2)
    {
        Console.Write("Rendszám (kötőjellel): ");
        string rendszam = Console.ReadLine();
        while (true)
        {
            if (checkRendszam(rendszam))
            {
                break;
            }
            Console.Write("Adjon meg egy helyes rendszámot (pl. ABC-123 vagy AA-AA-123): ");
            rendszam = Console.ReadLine();
        }
        rendszam = rendszam.ToUpper();
        Console.Write("Márka: ");
        string marka = Console.ReadLine();
        Console.Write("Típus: ");
        string tipus = Console.ReadLine();
        Console.Write("Szín: ");
        string szin = Console.ReadLine();

        DateTime belepes = DateTime.Now;

        adatok = $"================================\n{belepes.ToString("yyyy.MM.dd HH:mm:ss")}\nLátogató: Jármű\nRendszám: {rendszam}\nMárka: {marka}\nTípus: {tipus}\nSzín: {szin}\n================================\n";
        File.AppendAllText("belepesek.txt", adatok);

    }

    if (bejovo == 4)
    {
        Console.Write("Keresés Név (1) - Rendszám (2) - Jármű Típus (3) - Jármű Márka (4) alapján: ");
        string nev_szam = Console.ReadLine();
        while (nev_szam != "1" && nev_szam != "2" && nev_szam != "3" && nev_szam != "4")
        {
            Console.Write("Keresés Név (1) - Rendszám (2) - Jármű Típus (3) - Jármű Márka (4) alapján: ");
            nev_szam = Console.ReadLine();
        }

        Console.Write("Keressen: ");
        string keresesiErtek = Console.ReadLine();

        Console.WriteLine("\nAdatok a keresés alapján:\n");

        bool talalat = false;

        if (nev_szam == "1")
        {
            //Nev alapjan
            if (File.Exists("belepesek.txt"))
            {
                string[] sorok = File.ReadAllLines("belepesek.txt");
                for (int i = 0; i < sorok.Length; i++)
                {
                    if (sorok[i].Trim().ToLower() == ($"Név: {keresesiErtek.Trim()}").ToLower())
                    {
                        Console.WriteLine($"================================\n{sorok[i - 2]}\n{sorok[i - 1]}\n{sorok[i]}\n{sorok[i + 1]}\n================================\n");
                        talalat = true;
                    }
                }
            }
        }
        else if (nev_szam == "2")
        {
            //Rendszam alapjan
            if (File.Exists("belepesek.txt"))
            {
                string[] sorok = File.ReadAllLines("belepesek.txt");
                for (int i = 0; i < sorok.Length; i++)
                {
                    if (sorok[i].Trim().ToLower() == ($"Rendszám: {keresesiErtek.Trim()}").ToLower())
                    {
                        Console.WriteLine($"================================\n{sorok[i - 2]}\n{sorok[i - 1]}\n{sorok[i]}\n{sorok[i + 1]}\n{sorok[i + 2]}\n{sorok[i + 3]}\n================================\n");
                        talalat = true;
                    }
                }
            }
        }
        else if (nev_szam == "3")
        {
            //Jarmu Tipus alapjan
            if (File.Exists("belepesek.txt"))
            {
                string[] sorok = File.ReadAllLines("belepesek.txt");
                for (int i = 0; i < sorok.Length; i++)
                {
                    if (sorok[i].Trim().ToLower() == ($"Típus: {keresesiErtek.Trim()}").ToLower())
                    {
                        Console.WriteLine($"================================\n{sorok[i - 4]}\n{sorok[i - 3]}\n{sorok[i - 2]}\n{sorok[i - 1]}\n{sorok[i]}\n{sorok[i + 1]}\n================================\n");
                        talalat = true;
                    }
                }
            }
        }
        else if (nev_szam == "4")
        {
            //Jarmu Marka alapjan
            if (File.Exists("belepesek.txt"))
            {
                string[] sorok = File.ReadAllLines("belepesek.txt");
                for (int i = 0; i < sorok.Length; i++)
                {
                    if (sorok[i].Trim().ToLower() == ($"Márka: {keresesiErtek.Trim()}").ToLower())
                    {
                        Console.WriteLine($"================================\n{sorok[i - 3]}\n{sorok[i - 2]}\n{sorok[i - 1]}\n{sorok[i]}\n{sorok[i + 1]}\n{sorok[i + 2]}\n================================\n");
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

    Console.Write("Ember (1) - Jármű (2) - Kilép (3) - Keresés (4): ");
    bejovo = int.Parse(Console.ReadLine());

}