using System;

Random random = new Random();

List<int> jatekos_kartyak = new List<int>();

List<int> asztal_kartyak = new List<int>();

Console.WriteLine("__________.__                 __        ____.              __    \r\n\\______   \\  | _____    ____ |  | __   |    |____    ____ |  | __\r\n |    |  _/  | \\__  \\ _/ ___\\|  |/ /   |    \\__  \\ _/ ___\\|  |/ /\r\n |    |   \\  |__/ __ \\\\  \\___|    </\\__|    |/ __ \\\\  \\___|    < \r\n |______  /____(____  /\\___  >__|_ \\________(____  /\\___  >__|_ \\\r\n        \\/          \\/     \\/     \\/             \\/     \\/     \\/");

kartyahuzas(asztal_kartyak);

kartyahuzas(jatekos_kartyak);

kartyahuzas(jatekos_kartyak);

Console.WriteLine("Az asztal lapjai: ");

Console.Write(string.Join("\r\n", Kiiras(asztal_kartyak)));

Console.WriteLine();

Console.WriteLine("A lapjaid: ");

Console.Write(string.Join("\r\n", Kiiras(jatekos_kartyak)));

jatekMenet();

void kartyahuzas(List<int> kartyak)
{
    int huzas = random.Next(1, 11);
    kartyak.Add(huzas);
}

List<string> Kiiras(List<int> kartyak)
{
    List<string> ideiglenes = new List<string>();
    foreach (int kartya in kartyak)
    {
        switch (kartya)
        {
            case 1: ideiglenes.Add(".------.\r\n|1.--. |\r\n| :/\\: |\r\n| (__) |\r\n| '--'1|\r\n`------'"); break;
            case 2: ideiglenes.Add(".------.\r\n|2.--. |\r\n| (\\/) |\r\n| :\\/: |\r\n| '--'2|\r\n`------'"); break;
            case 3: ideiglenes.Add(".------.\r\n|3.--. |\r\n| :(): |\r\n| ()() |\r\n| '--'3|\r\n`------'"); break;
            case 4: ideiglenes.Add(".------.\r\n|4.--. |\r\n| :/\\: |\r\n| :\\/: |\r\n| '--'4|\r\n`------'"); break;
            case 5: ideiglenes.Add(".------.\r\n|5.--. |\r\n| :/\\: |\r\n| (__) |\r\n| '--'5|\r\n`------'"); break;
            case 6: ideiglenes.Add(".------.\r\n|6.--. |\r\n| (\\/) |\r\n| :\\/: |\r\n| '--'6|\r\n`------'"); break;
            case 7: ideiglenes.Add(".------.\r\n|7.--. |\r\n| :(): |\r\n| ()() |\r\n| '--'7|\r\n`------'"); break;
            case 8: ideiglenes.Add(".------.\r\n|8.--. |\r\n| :/\\: |\r\n| :\\/: |\r\n| '--'8|\r\n`------'"); break;
            case 9: ideiglenes.Add(".------.\r\n|9.--. |\r\n| :/\\: |\r\n| (__) |\r\n| '--'9|\r\n`------'"); break;
            case 10: ideiglenes.Add(".------.\r\n|K.--. |\r\n| :/\\: |\r\n| (__) |\r\n| '--'K|\r\n`------'"); break;
        }
    }
    return ideiglenes;
}

int kartyaErtekek(List<int> kartyak)
{
    int ertek = 0;
    foreach (int kartya in kartyak)
    {
        ertek += kartya;
    }
    return ertek;
}

void jatekMenet()
{
    string bekeres;
    bool jatekFut = true;

    while (jatekFut)
    {
        Console.WriteLine("\r\n");
        Console.Write("Hit or Stand: ");
        bekeres = Console.ReadLine()!.ToLower();

        if (bekeres == "hit")
        {
            kartyahuzas(jatekos_kartyak);
            FrissitKonzol(false); 
            if (kartyaErtekek(jatekos_kartyak) > 21)
            {
                jatekFut = false;
                break;
            }
        }
        else if (bekeres == "stand")
        {
            while (kartyaErtekek(asztal_kartyak) < 17)
            {
                kartyahuzas(asztal_kartyak);
            }
            FrissitKonzol(true);
            jatekFut = false;
        }
    }

    KiErtekel();
}

void FrissitKonzol(bool asztaltIsMutat)
{
    Console.Clear();
    if (asztaltIsMutat)
    {
        Console.WriteLine("Az asztal lapjai: ");
        Console.Write(string.Join("\r\n", Kiiras(asztal_kartyak)));
        Console.WriteLine();
    }
    Console.WriteLine("A lapjaid: ");
    Console.Write(string.Join("\r\n", Kiiras(jatekos_kartyak)));
}

void KiErtekel()
{
    int jatekosErtek = kartyaErtekek(jatekos_kartyak);
    int asztalErtek = kartyaErtekek(asztal_kartyak);

    Console.WriteLine("\r\n");

    if (jatekosErtek > 21)
    {
        Console.WriteLine("A játékos túllépte a 21-et!\r\n");
        Console.WriteLine(".____                        \r\n|    |    ____  ______ ____  \r\n|    |   /  _ \\/  ___// __ \\ \r\n|    |__(  <_> )___ \\\\  ___/ \r\n|_______ \\____/____  >\\___  >\r\n        \\/         \\/     \\/");
    }
    else if (asztalErtek > 21)
    {
        Console.WriteLine("Az asztal túllépte a 21-et!\r\n");
        Console.WriteLine(" __      __.__        \r\n/  \\    /  \\__| ____  \r\n\\   \\/\\/   /  |/    \\ \r\n \\        /|  |   |  \\\r\n  \\__/\\  / |__|___|  /\r\n       \\/          \\/ ");
    }
    else if (jatekosErtek > asztalErtek)
    {
        Console.WriteLine(" __      __.__        \r\n/  \\    /  \\__| ____  \r\n\\   \\/\\/   /  |/    \\ \r\n \\        /|  |   |  \\\r\n  \\__/\\  / |__|___|  /\r\n       \\/          \\/ ");
    }
    else if (jatekosErtek < asztalErtek)
    {
        Console.WriteLine(".____                        \r\n|    |    ____  ______ ____  \r\n|    |   /  _ \\/  ___// __ \\ \r\n|    |__(  <_> )___ \\\\  ___/ \r\n|_______ \\____/____  >\\___  >\r\n        \\/         \\/     \\/");
    }
    else
    {
        Console.WriteLine("________ __________    _____  __      __ \r\n\\______ \\\\______   \\  /  _  \\/  \\    /  \\\r\n |    |  \\|       _/ /  /_\\  \\   \\/\\/   /\r\n |    `   \\    |   \\/    |    \\        / \r\n/_______  /____|_  /\\____|__  /\\__/\\  /  \r\n        \\/       \\/         \\/      \\/   ");
    }
}


