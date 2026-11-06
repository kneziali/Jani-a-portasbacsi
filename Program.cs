using System.IO;


Console.WriteLine("Üdvözlöm portásbácsi");
Console.Write("Ember (1) - jármű (2) vagy Kilép(3): ");
int bejovo = int.Parse(Console.ReadLine());

DateTime belepes = DateTime.Now;

string adatok = "";

File.AppendAllText("belepesek.txt", "Jani bácsi megérkezett \n \n");
while (bejovo == 1 || bejovo == 2)
{

    if (bejovo == 1)
    {
        Console.Write("Név: ");
        string nev = Console.ReadLine();

        Console.Write("Kor: ");
        string kor = Console.ReadLine();

        Console.Write("Személyi igazolvány szám: ");
        string igazolvany = Console.ReadLine();

        Console.Write("Látogatás célja: ");
        string cel = Console.ReadLine();

          
        
      adatok = $"{belepes.ToString("yyyy.MM.dd HH:mm:ss")}\nLátogató: Személy \nNév: {nev}\nKor:{kor}\nSzemélyi igazolvány szám: {igazolvany} \nLátogatás célja: {cel}\n================================ \n";
      File.AppendAllText("belepesek.txt", adatok);


    }

    if (bejovo == 2)
    {
        Console.Write("Rendszám: ");
        string rendszam = Console.ReadLine();
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


       adatok = $"{belepes.ToString("yyyy.MM.dd HH:mm:ss")} \nLátogató: Jármű \nRendszám: {rendszam}\nMárka:{marka}\nTípus: {tipus} \nSzín: {szin}   \nSofőr neve: {sofor}\nLátogatás célja: {cel}\n================================ \n";
       File.AppendAllText("belepesek.txt", adatok);

    }

    if (bejovo == 3)
    {
        break;
    }

    Console.Write("Ember (1) - jármű (2) vagy Kilép(3): ");
    bejovo = int.Parse(Console.ReadLine());

}

