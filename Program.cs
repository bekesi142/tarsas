using System.IO;

List<string> dobasok = new List<string>();
List<string> osvenyek = new List<string>();

StreamReader sr = new StreamReader("dobasok.txt");
while (!sr.EndOfStream)
{
    string[] dob = sr.ReadLine().Split(" ");
	for (int i = 0; i < dob.Length; i++)
	{
		dobasok.Add(dob[i]);
	}
}
sr.Close();

StreamReader sr2 = new StreamReader("osvenyek.txt");
while (!sr2.EndOfStream)
{
    sr2.ReadLine();
	osvenyek.Add(sr2.ReadLine());
    
}
sr2.Close();





Console.WriteLine("2. feladat:"  );
Console.WriteLine("A dobások száma: " + dobasok.Count);
Console.WriteLine("Az ösvények száma:  " + osvenyek.Count);

//Megjegyzés: késés miatt jutottam idáig.