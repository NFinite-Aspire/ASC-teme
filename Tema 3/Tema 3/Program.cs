Ex1(47);
Ex2(-27, 8);
Ex3("213", 16);
Ex4("10110.101", 2);
Ex5(34.625, 4);
Ex6("011011", 2);
Ex7(-27, 32, 6);
Ex8("011011", 2);
Ex9(55.875);
Ex10("132.2", 4);
Ex11("0.201", 3);

static void Ex1(int numar)
{
    string binar = "";
    int temp = numar;
    while (temp > 0)
    {
        binar = (temp % 2) + binar;
        temp /= 2;
    }
    if (binar == "") binar = "0";
    Console.WriteLine($"Ex1: {numar} din baza 10 in baza 2  = {binar}");
}

static void Ex2(int numar, int biti)
{
    int magnitudine = Math.Abs(numar);
    string binar = "";
    for (int i = 0; i < biti - 1; i++)
    {
        binar = (magnitudine % 2) + binar;
        magnitudine /= 2;
    }
    binar = (numar < 0 ? "1" : "0") + binar;
    Console.WriteLine($"Ex2: {numar} din baza 10 in baza 2 magnitudine cu semn = {binar}");
}

static void Ex3(string numar, int baza_sursa)
{
    int rezultat = 0;
    for (int i = 0; i < numar.Length; i++)
    {
        int cifra = (numar[i] >= '0' && numar[i] <= '9') ? numar[i] - '0' : numar[i] - 'A' + 10;
        rezultat = rezultat * baza_sursa + cifra;
    }
    Console.WriteLine($"Ex3: {numar} din baza 16 in baza 10 = {rezultat}");
}

static void Ex4(string numar, int baza_sursa)
{
    string[] parti = numar.Split('.');
    string int_part = parti[0];
    string frac_part = parti.Length > 1 ? parti[1] : "";
    double rezultat = 0;

    for (int i = 0; i < int_part.Length; i++)
        rezultat += (int_part[i] - '0') * Math.Pow(baza_sursa, int_part.Length - 1 - i);

    for (int i = 0; i < frac_part.Length; i++)
        rezultat += (frac_part[i] - '0') * Math.Pow(baza_sursa, -(i + 1));

    Console.WriteLine($"Ex4: {numar} din baza 2 in baza 10 = {rezultat}");
}

static void Ex5(double numar, int baza_destinatie)
{
    long int_part = (long)numar;
    double frac_part = numar - int_part;

    string rezultat_int = "";
    long temp = int_part;
    while (temp > 0)
    {
        rezultat_int = (temp % baza_destinatie) + rezultat_int;
        temp /= baza_destinatie;
    }
    if (rezultat_int == "") rezultat_int = "0";

    string rezultat_frac = "";
    for (int i = 0; i < 10; i++)
    {
        frac_part *= baza_destinatie;
        int cifra = (int)frac_part;
        rezultat_frac += cifra;
        frac_part -= cifra;
    }
    rezultat_frac = rezultat_frac.TrimEnd('0');

    Console.WriteLine($"Ex5: {numar} din baza 10 in baza 4 = {rezultat_int}.{rezultat_frac}");
}

static void Ex6(string numar, int baza_sursa)
{
    int rezultat = 0;
    for (int i = 0; i < numar.Length; i++)
        rezultat = rezultat * baza_sursa + (numar[i] - '0');

    Console.WriteLine($"Ex6: {numar} din baza 2 in baza 10 = {rezultat}");
}

static void Ex7(int numar, int k, int biti)
{
    int biasat = numar + k;
    string binar = "";
    for (int i = 0; i < biti; i++)
    {
        binar = (biasat % 2) + binar;
        biasat /= 2;
    }
    Console.WriteLine($"Ex7: {numar} în binar exces 32 = {binar}");
}

static void Ex8(string numar, int baza_sursa)
{
    int decimal_val = 0;
    for (int i = 0; i < numar.Length; i++)
        decimal_val = decimal_val * baza_sursa + (numar[i] - '0');

    string hex = "";
    int temp = decimal_val;
    while (temp > 0)
    {
        int cifra = temp % 16;
        hex = (cifra < 10 ? (char)('0' + cifra) : (char)('A' + cifra - 10)) + hex;
        temp /= 16;
    }
    if (hex == "") hex = "0";

    Console.WriteLine($"Ex8: {numar} din baza 2 in baza 16 = {hex}");
}

static void Ex9(double numar)
{
    long int_part = (long)numar;
    double frac_part = numar - int_part;

    string binar_int = "";
    long temp = int_part;
    while (temp > 0)
    {
        binar_int = (temp % 2) + binar_int;
        temp /= 2;
    }
    if (binar_int == "") binar_int = "0";

    string binar_frac = "";
    for (int i = 0; i < 10; i++)
    {
        frac_part *= 2;
        int cifra = (int)frac_part;
        binar_frac += cifra;
        frac_part -= cifra;
    }
    binar_frac = binar_frac.TrimEnd('0');

    Console.WriteLine($"Ex9: {numar} din baza 10 in binar fara semn = {binar_int}.{binar_frac}");
}

static void Ex10(string numar, int baza_sursa)
{
    string[] parti = numar.Split('.');
    string int_part = parti[0];
    string frac_part = parti.Length > 1 ? parti[1] : "";

    double decimal_val = 0;
    for (int i = 0; i < int_part.Length; i++)
        decimal_val += (int_part[int_part.Length - 1 - i] - '0') * Math.Pow(baza_sursa, i);
    for (int i = 0; i < frac_part.Length; i++)
        decimal_val += (frac_part[i] - '0') * Math.Pow(baza_sursa, -(i + 1));

    long int_part16 = (long)decimal_val;
    double frac_part16 = decimal_val - int_part16;

    string hex_int = "";
    long temp = int_part16;
    while (temp > 0)
    {
        long cifra = temp % 16;
        hex_int = (cifra < 10 ? (char)('0' + cifra) : (char)('A' + cifra - 10)) + hex_int;
        temp /= 16;
    }
    if (hex_int == "") hex_int = "0";

    string hex_frac = "";
    for (int i = 0; i < 10; i++)
    {
        frac_part16 *= 16;
        int cifra = (int)frac_part16;
        hex_frac += cifra < 10 ? (char)('0' + cifra) : (char)('A' + cifra - 10);
        frac_part16 -= cifra;
    }
    hex_frac = hex_frac.TrimEnd('0');

    Console.WriteLine($"Ex10: {numar} din baza 4 in baza 16 = {hex_int}.{hex_frac}");
}

static void Ex11(string numar, int baza_sursa)
{
    string frac_part = numar.Split('.')[1];
    double rezultat = 0;
    for (int i = 0; i < frac_part.Length; i++)
        rezultat += (frac_part[i] - '0') * Math.Pow(baza_sursa, -(i + 1));

    Console.WriteLine($"Ex11: {numar} din baza 3 in baza 10 = {rezultat}");
}