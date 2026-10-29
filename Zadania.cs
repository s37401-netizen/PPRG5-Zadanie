// Zadanie 1
/*
int[] zlotoWTurach = {5, 12, 0, 8, 15};

for (int i = 0; i < zlotoWTurach.Length; i++)
{
    Console.WriteLine($"Tura {i + 1}: {zlotoWTurach[i]} sztuk złota");
}

int licznik = 0;

foreach (int zloto in zlotoWTurach)
{
    if (zloto >= 10)
    {
        licznik++;
    }
}

Console.WriteLine($"Lącznie: {zlotoWTurach.Sum()}");
Console.WriteLine($"Średnio na turę: {(double)zlotoWTurach.Sum() /zlotoWTurach.Length}");
Console.WriteLine($"Tury z wynikiem co najmniej 10: {licznik}");
Console.Write("Od końca: ");
for (int i = zlotoWTurach.Length - 1; i >= 0; i--)
{
 Console.Write(zlotoWTurach[i] + " ");   
}
*/
// Zadanie 2
/*
List<string> plecak = new List<string>
{
    "Miecz",
    "Mikstura",
    "Pochodnia"
};

foreach (string item in plecak)
{
    Console.WriteLine($"{plecak.IndexOf(item) + 1}. {item}");
}

Console.Write("Znaleziony przedmiot: ");
string nowy = Console.ReadLine()!;

plecak.Add(nowy);
Console.WriteLine($"Dodano: {plecak[(plecak.Count) - 1]}");

if (plecak.Contains("Mikstura"))
{
    Console.WriteLine("Użyto mikstury");
    plecak.Remove("Mikstura");
}
else
{
    Console.WriteLine("Nie masz mikstury");
}

Console.WriteLine($"Plecak ({plecak.Count}/6)");

foreach (string item in plecak)
{
    Console.WriteLine($"{plecak.IndexOf(item) + 1}. {item}");
}
*/
// Zadanie 3
/*
Dictionary<string, int> ceny = new Dictionary<string, int>
{
    { "Mikstura", 15 },
    { "Pochodnia", 5 },
    { "Miecz", 40 }
};

Console.WriteLine(ceny.Count);

foreach (KeyValuePair<string, int> para in ceny)
{
    Console.WriteLine($"{para.Key}: { para.Value}");
}

Console.Write("Podaj nazwę przedmiotu: ");
string nazwa = Console.ReadLine()!;
if (ceny.ContainsKey(nazwa))
{
    Console.WriteLine(ceny[nazwa]);
}
else
{
    Console.WriteLine("Przedmiotu niema");
}

ceny["Mikstura"] = 12;

foreach (KeyValuePair<string, int> para in ceny)
{
    Console.WriteLine($"{para.Key}: { para.Value}");
}
*/
// Zadanie 4
/*
int tury;

while (true)
{
    Console.Write("Wpisz liczbę tur od 1 do 10: ");
    bool liczba = int.TryParse(Console.ReadLine()!, out tury);

    if (liczba == true && 1 <= tury || tury <= 10)
    {
        break; 
    } 
    Console.WriteLine("Niepoprawna liczba tur");
}

int[] zloto = new int[tury];
for (int i = 0; i < tury; i++)
{
    Console.Write($"Ile złota w {i + 1} turze: ");
    int value = int.Parse(Console.ReadLine()!);
    zloto[i] = value;
}

int maxPierwszy = 0;
int maxLicznik = 0;
int wynZero = 0;

for (int i = 0; i < zloto.Length; i++)
{
    if (zloto[i] == zloto.Max())
    {
        maxPierwszy = i + 1;
        break;
    } 
}

for (int i = 0; i < zloto.Length; i++)
{
    if (zloto[i] == zloto.Max())
    {
        maxLicznik++;
    }
}

for (int i = 0; i < zloto.Length; i++)
{
    if (zloto[i] == 0)
    {
        wynZero = i + 1;
        break;
    } 
}

Console.WriteLine($"Suma: {zloto.Sum()}");
Console.WriteLine($"Minimum: {zloto.Min()}");
Console.WriteLine($"Maximum: {zloto.Max()}");
Console.WriteLine($"Pierwszy najlepszy wynik: tura {maxPierwszy}");
Console.WriteLine($"Liczba tur z maksimum: {maxLicznik}");
Console.WriteLine($"Pierwsza tura bez złota: {wynZero}");
*/
//Zadanie 5
/*
List<string> przedmioty = new List<string>
{
    "Miecz",
    "Tarcza",
    "Mikstura",
    "Klucz"
};
foreach (string przedmiot in przedmioty)
{
    Console.WriteLine($"{przedmioty.IndexOf(przedmiot) + 1}. {przedmiot}");
}

bool petla = true;
string usuwanie = "";

while (petla)
{
    string usuwanie = Console.ReadLine()!;
    foreach (string przedmiot in przedmioty)
    {
        if (usuwanie == przedmiot)
        {
            petla = false;
            break;
        }
    }
}

przedmioty.Add(usuwanie);
// Dokończyć
*/
// Zadanie 6
/*
Dictionary<string, int> magazyn = new Dictionary<string, int>
{
    { "Mikstura", 3 },
    { "Pochodnia", 2 },
    { "Klucz", 1 }
};

int zloto = 5;

while (true)
{
    Console.WriteLine("=================");
    Console.WriteLine("|    MENU\t|");
    Console.WriteLine("=================");
    Console.WriteLine("|    SHOP\t|");
    foreach (KeyValuePair<string, int> mag in magazyn)
    {
        Console.WriteLine($"|{mag.Key}: {mag.Value}\t|");
    }
    Console.WriteLine("=================");
    string przedmiot = Console.ReadLine()!;
    if (magazyn.ContainsKey(przedmiot))
    {
        zloto -= magazyn[przedmiot];
        magazyn.Remove(przedmiot);
        }
}
// Dokończyć
*/
// Zadanie 7
/*
List<string> historia = new List<string>();

while (true)
{
    Console.WriteLine("1 - Eksploruj\n2 - Odpocznij\n3 - Znajdź przedmiot\n4 - Pokaż całą historię\n5 - Pokaż ostatnie trzy wpisy\n6 - Policz wybraną akcję\n7 - Wyczyść historię\n8 - Zakończ\n");
    int nrPrzgody = int.Parse(Console.ReadLine()!);

    switch (nrPrzgody)
    {
        case 1:
            historia.Add("Eksploracja");
            break;
        case 2:
            historia.Add("Odpoczynek");
            break;
        case 3:
            historia.Add("Znaleziono przedmiot");
            break;
        case 4:
            foreach (string element in historia)
            {
                Console.WriteLine(element);
            }
            break;
        case 5:
            for (int i = -1; i >= -3; i--)
            {
                Console.WriteLine(historia[i]);
            }

            break;
    }
}
//Dokończyć
*/
//Wdomu
// Zadanie 8
// Zadanie 9 