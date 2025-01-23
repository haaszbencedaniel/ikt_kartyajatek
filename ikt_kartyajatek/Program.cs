using System;

Random random = new Random();

List<int> jatekos_kartyak = new List<int>();

List<int> asztal_kartyak = new List<int>();

void kartyahuzas(List<int> asd)
{
    int huzas = random.Next(1,11);

    int eldontes = random.Next(0,4);

    switch (huzas)
    {
        case 1: asd.Add(1); break;
        case 2: asd.Add(2); break;
        case 3: asd.Add(3); break;
        case 4: asd.Add(4); break;
        case 5: asd.Add(5); break;
        case 6: asd.Add(6); break;
        case 7: asd.Add(7); break;
        case 8: asd.Add(8); break;
        case 9: asd.Add(9); break;
        case 10: asd.Add(10); break;
    }
}

List<string> Kiiras(List<int> asd)
{
    List<string> ideiglenes = new List<string>();

    int eldontes = random.Next(0, 4);

    for (int i = 0; i < asd.Count; i++)
    {
        switch (asd[i])
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
            case 10:
                if (eldontes == 0)
                {
                    ideiglenes.Add(".------.\r\n|10--. |\r\n| :||: |\r\n| |__| |\r\n| '--10|\r\n`------'");
                }
                else if (eldontes == 1)
                {
                    ideiglenes.Add(".------.\r\n|Q.--. |\r\n| :/\\: |\r\n| :\\/: |\r\n| '--'Q|\r\n`------'");
                }
                else if (eldontes == 2)
                {
                    ideiglenes.Add(".------.\r\n|K.--. |\r\n| :/\\: |\r\n| (__) |\r\n| '--'K|\r\n`------'");
                }
                else
                {
                    ideiglenes.Add(".------.\r\n|J.--. |\r\n| :||: |\r\n| |__| |\r\n| '--'J|\r\n`------'");
                }
                break;
        }
    }
    return ideiglenes;
}