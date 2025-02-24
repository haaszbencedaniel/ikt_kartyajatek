﻿using System;

Random random = new Random();

List<int> jatekos_kartyak = new List<int>();

List<int> asztal_kartyak = new List<int>();

Console.WriteLine("__________.__                 __        ____.              __    \r\n\\______   \\  | _____    ____ |  | __   |    |____    ____ |  | __\r\n |    |  _/  | \\__  \\ _/ ___\\|  |/ /   |    \\__  \\ _/ ___\\|  |/ /\r\n |    |   \\  |__/ __ \\\\  \\___|    </\\__|    |/ __ \\\\  \\___|    < \r\n |______  /____(____  /\\___  >__|_ \\________(____  /\\___  >__|_ \\\r\n        \\/          \\/     \\/     \\/             \\/     \\/     \\/");

KartyaHuzas(asztal_kartyak);

KartyaHuzas(jatekos_kartyak);

KartyaHuzas(jatekos_kartyak);

Console.WriteLine("Az asztal lapjai: ");

Console.Write(string.Join("\r\n", Kiiras(asztal_kartyak)));

Console.WriteLine();

Console.WriteLine("A lapjaid: ");

Console.Write(string.Join("\r\n", Kiiras(jatekos_kartyak)));

jatekMenet();

void KartyaHuzas(List<int> kartyak)
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

int KartyaErtekek(List<int> kartyak)
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
            KartyaHuzas(jatekos_kartyak);
            FrissitKonzol(false); 
            if (KartyaErtekek(jatekos_kartyak) > 21)
            {
                jatekFut = false;
                break;
            }
        }
        else if (bekeres == "stand")
        {
            while (KartyaErtekek(asztal_kartyak) < 17)
            {
                KartyaHuzas(asztal_kartyak);
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
    int jatekosErtek = KartyaErtekek(jatekos_kartyak);
    int asztalErtek = KartyaErtekek(asztal_kartyak);

    Console.WriteLine("\r\n");

    if (jatekosErtek > 21)
    {
        Console.WriteLine("A játékos túllépte a 21-et!\r\n");
        Console.WriteLine("____   ____                       __          __    __     |_| .__   \r\n\\   \\ /   /____   _______________/  |_  _____/  |__/  |_  ____ |  |  \r\n \\   Y   // __ \\ /  ___/\\___   /\\   __\\/ __ \\   __\\   __\\/ __ \\|  |  \r\n  \\     /\\  ___/ \\___ \\  /    /  |  | \\  ___/|  |  |  | \\  ___/|  |__\r\n   \\___/  \\___  >____  >/_____ \\ |__|  \\___  >__|  |__|  \\___  >____/\r\n              \\/     \\/       \\/           \\/                \\/      ");
    }
    else if (asztalErtek > 21)
    {
        Console.WriteLine("Az asztal túllépte a 21-et!\r\n");
        Console.WriteLine("                            __     |_| .__   \r\n  ____ ___.__. ____________/  |_  ____ |  |  \r\n /    <   |  |/ __ \\_  __ \\   __\\/ __ \\|  |  \r\n|   |  \\___  \\  ___/|  | \\/|  | \\  ___/|  |__\r\n|___|  / ____|\\___  >__|   |__|  \\___  >____/\r\n     \\/\\/         \\/                 \\/      ");
    }
    else if (jatekosErtek > asztalErtek)
    {
        Console.WriteLine("                            __     |_| .__   \r\n  ____ ___.__. ____________/  |_  ____ |  |  \r\n /    <   |  |/ __ \\_  __ \\   __\\/ __ \\|  |  \r\n|   |  \\___  \\  ___/|  | \\/|  | \\  ___/|  |__\r\n|___|  / ____|\\___  >__|   |__|  \\___  >____/\r\n     \\/\\/         \\/                 \\/      ");
    }
    else if (jatekosErtek < asztalErtek)
    {
        Console.WriteLine("____   ____                       __          __    __     |_| .__   \r\n\\   \\ /   /____   _______________/  |_  _____/  |__/  |_  ____ |  |  \r\n \\   Y   // __ \\ /  ___/\\___   /\\   __\\/ __ \\   __\\   __\\/ __ \\|  |  \r\n  \\     /\\  ___/ \\___ \\  /    /  |  | \\  ___/|  |  |  | \\  ___/|  |__\r\n   \\___/  \\___  >____  >/_____ \\ |__|  \\___  >__|  |__|  \\___  >____/\r\n              \\/     \\/       \\/           \\/                \\/      ");
    }
    else
    {
        Console.WriteLine("________    ()()         __          __  .__                 \r\n\\______ \\   ____   _____/  |_  _____/  |_|  |   ____   ____  \r\n |    |  \\ /  _ \\ /    \\   __\\/ __ \\   __\\  | _/ __ \\ /    \\ \r\n |    `   (  <_> )   |  \\  | \\  ___/|  | |  |_\\  ___/|   |  \\\r\n/_______  /\\____/|___|  /__|  \\___  >__| |____/\\___  >___|  /\r\n        \\/            \\/          \\/               \\/     \\/ ");
    }
}


