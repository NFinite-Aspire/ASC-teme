//titlu
Console.WriteLine("==Conversie de baze==");

//baza initiala
Console.Write("alege baza din care vrei sa convertesti (2, 8, 10, 16): ");
int bazainitiala = int.Parse(Console.ReadLine());

//baza finala
Console.Write("alege baza in care vrei sa convertesti (2, 8, 10, 16): ");
int bazafinala = int.Parse(Console.ReadLine());

//numarul de convertit
Console.Write("introdu numarul pe care vrei sa-l convertesti: ");
string numar = Console.ReadLine();

//rezultatul conversiei
int value = Convert.ToInt32(numar, bazainitiala);
string rezultat = Convert.ToString(value, bazafinala).ToUpper();
Console.WriteLine("rezultatul este:");
Console.WriteLine(rezultat);