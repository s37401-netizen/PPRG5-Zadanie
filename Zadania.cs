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
Dictionary<string, int> magazyn = new Dictionary<string, int>
{
    { "Mikstura", 3 },
    { "Pochodnia", 2 },
    { "Klucz", 1 }
};

bool dziala = true;
while (dziala)
{
    Console.WriteLine("\n=== MAGAZYN ===");
    Console.WriteLine("1 - Pokaż magazyn");
    Console.WriteLine("2 - Przyjmij dostawę");
    Console.WriteLine("3 - Wydaj przedmiot");
    Console.WriteLine("4 - Usuń pustą pozycję");
    Console.WriteLine("5 - Zakończ");
    Console.Write("Wybierz opcję: ");
    string opcja = Console.ReadLine()!;

    switch (opcja)
    {
        case "1":
            if (magazyn.Count == 0)
            {
                Console.WriteLine("Magazyn jest całkowicie pusty.");
            }
            else
            {
                Console.WriteLine("Stan magazynu:");
                foreach (KeyValuePair<string, int> pozycja in magazyn)
                {
                    Console.WriteLine($"- {pozycja.Key}: {pozycja.Value} szt.");
                }
            }
            break;

        case "2":
            Console.Write("Podaj nazwę przedmiotu do dostawy: ");
            string nazwaDostawy = Console.ReadLine()!;
            Console.Write("Podaj ilość (liczba dodatnia): ");
            int iloscDostawy;
            if (int.TryParse(Console.ReadLine()!, out iloscDostawy) && iloscDostawy > 0)
            {
                if (magazyn.ContainsKey(nazwaDostawy))
                {
                    magazyn[nazwaDostawy] += iloscDostawy;
                }
                else
                {
                    magazyn.Add(nazwaDostawy, iloscDostawy);
                }
                Console.WriteLine($"Przyjęto dostawę: {nazwaDostawy} (+{iloscDostawy}). Aktualny stan: {magazyn[nazwaDostawy]}");
            }
            else
            {
                Console.WriteLine("Odrzucono: ilość musi być dodatnią liczbą całkowitą!");
            }
            break;

        case "3":
            Console.Write("Podaj nazwę przedmiotu do wydania: ");
            string nazwaWydania = Console.ReadLine()!;
            if (!magazyn.ContainsKey(nazwaWydania))
            {
                Console.WriteLine("Odrzucono: Brak takiego przedmiotu w magazynie.");
                break;
            }

            Console.Write($"Podaj ilość do wydania (dostępne {magazyn[nazwaWydania]}): ");
            int iloscWydania;
            if (int.TryParse(Console.ReadLine()!, out iloscWydania) && iloscWydania > 0)
            {
                if (magazyn[nazwaWydania] >= iloscWydania)
                {
                    magazyn[nazwaWydania] -= iloscWydania;
                    Console.WriteLine($"Wydano {iloscWydania} szt. {nazwaWydania}. Pozostało: {magazyn[nazwaWydania]}");
                }
                else
                {
                    Console.WriteLine("Odrzucono: Niewystarczająca liczba sztuk w magazynie.");
                }
            }
            else
            {
                Console.WriteLine("Odrzucono: ilość musi być dodatnią liczbą całkowitą.");
            }
            break;

        case "4":
            Console.Write("Podaj nazwę pozycji do usunięcia: ");
            string nazwaUsuwana = Console.ReadLine()!;
            if (!magazyn.ContainsKey(nazwaUsuwana))
            {
                Console.WriteLine("Odrzucono: Taka pozycja nie istnieje w magazynie.");
            }
            else if (magazyn[nazwaUsuwana] == 0)
            {
                magazyn.Remove(nazwaUsuwana);
                Console.WriteLine($"Pozycja '{nazwaUsuwana}' została usunięta z magazynu.");
            }
            else
            {
                Console.WriteLine($"Odrzucono: Nie można usunąć pozycji ze stanem większym niż 0 (stan: {magazyn[nazwaUsuwana]}).");
            }
            break;

        case "5":
            dziala = false;
            Console.WriteLine("Koniec pracy magazynu.");
            break;

        default:
            Console.WriteLine("Błędna opcja, wybierz 1-5.");
            break;
    }
}
// Dokończyć

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
