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