/* 

Console.WriteLine(x);
    x--;
}
Console.WriteLine("Geben sie ihr Alter ein und finden sie heruas in welche Altersgruppe sie gehören.");
Console.Write("Alter eingeben: ");
byte alter = Convert.ToByte(Console.ReadLine());

if (alter < 9)
{
    Console.WriteLine("Du bist ein Kleinkind");
}
else if (alter <= 12)
{
    Console.WriteLine("Du bist ein Kind");
}
else if (alter <= 17)
{
    Console.WriteLine("Du bist ein Teenager");
}
else if (alter <= 64)
{
    Console.WriteLine("Du bist ein Erwachsener");
}
else
{
    Console.WriteLine("Du bist ein Senior");
}

 
Console.Write("Geben sie ihr Alter ein: ");
int alter = Convert.ToInt32(Console.ReadLine());

bool berechtigt = alter >= 18;

if (berechtigt)
{
    Console.WriteLine("Sie sind volljährig und dürfen rein.");
}
else
{
    Console.WriteLine("Sie sind minderjährig und dürfen nicht rein.");
}


Console.Write("Geben sie eine Zahl ein: ");
int zahl = Convert.ToInt32(Console.ReadLine());

if (zahl % 3 == 0 && zahl % 5 == 0)
{
    Console.WriteLine("FIZZBUZZ");
}
else if (zahl % 3 == 0)
{
    Console.WriteLine("FIZZ");
}
else if (zahl % 5 == 0)
{
    Console.WriteLine("BUZZ");
}
else
{
    Console.WriteLine(zahl);
}


Console.Write("Welchen Wochentag wollen sie haben: ");

int wahl = Convert.ToInt32(Console.ReadLine());

switch (wahl)
{
    case 1:
        Console.WriteLine("Der 1. Tag ist Montag.");
        break;
    case 2:
        Console.WriteLine("Der 2. Tag ist Dienstag.");
        break;
    case 3:
        Console.WriteLine("Der 3. Tag ist Mittwoch.");
        break;
    case 4:
        Console.WriteLine("Der 4. Tag ist Donnerstag.");
        break;
    case 5:
        Console.WriteLine("Der 5. Tag ist Freitag.");
        break;
    case 6:
        Console.WriteLine("Der 6. Tag ist Samstag.");
        break;
    case 7:
        Console.WriteLine("Der 7. Tag ist Sonntag.");
        break;
    default:
        Console.WriteLine("Eine Woche hat nicht so viele Tage.");
        break;
}


Console.Write("Erste Zahl eingeben: ");
int zahl1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Zweite Zahl eingeben: ");
int zahl2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.Write("Welchen Operator wollen sie verwenden (+, -, *, /): ");

char operatoren = Convert.ToChar(Console.ReadLine());

switch (operatoren)
{
    case '+':
        Console.WriteLine("Das Ergebniss ist: " + (zahl1 + zahl2));
        break;

    case '-': 
        Console.WriteLine("Das Ergebniss ist: " + (zahl1 - zahl2));
        break; 

    case '*':
        Console.WriteLine("Das Ergebniss ist: " + (zahl1 * zahl2));
        break;

    case '/':
        Console.WriteLine("Das Ergebniss ist: " + (zahl1 / zahl2) + " Rest: " + (zahl1 % zahl2));
        break;
         
    default:
        Console.WriteLine("Fehlermeldung");
        break;

}

int x = 5;
while (x > 0)
{


//oder


for (int i = 0; i <= 5; i++)
{
    Console.WriteLine(i);
}



Console.Write("Bis zu welcher Zahl soll gezählt und Herausgefunden werden ob die zahlen dazwischen durch 2 teilbar sind? : ");

int zahl = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int i = 0;

do { if (i == 0)
     {
        Console.WriteLine(i);
     }
     else if (i % 2 == 0)
     {
        Console.WriteLine(i + " ist durch 2 teilbar");
     }
     else
         Console.WriteLine(i);
     i++;
} while (i <= zahl); 


Console.Write("Name oder Text eingeben : ");

String text = Console.ReadLine();

Console.WriteLine("Anzahl von Zeichen im Test: " + text.Length);

int i = 0;

for (int j = 1; j <= text.Length; j++)
{
    Console.WriteLine(i + " + " + j + " = " + (i+j));
    i += j;
}
Console.WriteLine("Summe ist: " + i);



string? name = Console.ReadLine();
name ??= string.Empty;
name = name.ToLower().Trim();
string reversedName = string.Empty;

foreach (char c in name.Reverse())
{
    reversedName+= c;
}
Console.WriteLine("{0} ist {1} Palindrom", name, name == reversedName ? "ein" : "kein");
 



*/

double ergebnis = 0;
bool mitErgebnis = false;

while (true)
{
    Console.Write("");

    double zahl1;

    if (mitErgebnis)
    {
        Console.Write("Weiter?: ");
        string? antwort = Console.ReadLine();
        if (antwort?.ToLower() == "ja")
        {
            zahl1 = ergebnis;
            Console.WriteLine("\n");
            Console.WriteLine(ergebnis);
        }
        else
        {
            break;
        }
        
    }
    else
    {
        zahl1 = Convert.ToDouble(Console.ReadLine());
    }

    Console.Write("");

    char operatoren = Convert.ToChar(Console.ReadLine());

    Console.Write("");

    double zahl2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine();

    if (mitErgebnis)
    {
        zahl1 = ergebnis;
    }

    switch (operatoren)
    {
        case '+':
            ergebnis = zahl1 + zahl2;
            Console.WriteLine((zahl1 + zahl2));
            Console.WriteLine("\n");
            break;

        case '-':
            ergebnis = zahl1 - zahl2;
            Console.WriteLine((zahl1 - zahl2));
            Console.WriteLine("\n");
            break;

        case '*':
            ergebnis = zahl1 * zahl2;
            Console.WriteLine((zahl1 * zahl2));
            Console.WriteLine("\n");
            break;

        case '/':g
            ergebnis = (zahl1 / zahl2) + (zahl1 % zahl2);
            Console.WriteLine((zahl1 / zahl2) + " Rest: " + (zahl1 % zahl2));
            Console.WriteLine("\n");
            break;
        default:

            Console.WriteLine("Fehlermeldung");
            break;
    }
    mitErgebnis = true;
    continue;

}


   




/*
Console.Write("Geben sie eine Zahl ein: ");
int zahl = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= zahl; i++)
{

    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine(i + " : FIZZBUZZ");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine(i + " : FIZZ");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine(i + " : BUZZ");
    }
    else
    {
        Console.WriteLine(i);
    }

}*/
