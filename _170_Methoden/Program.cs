
Console.WriteLine("Methoden");
Console.WriteLine("Algorythmen die man aufrufen kann");

void ohneRückgabewert()
{
    Console.WriteLine("ich bin in der Methode ohneRückgabewert()");
}

string mitRueckgabewert()
{
    return "ich bin in der Methode mitRueckgabewert()";
}

void einParameter(string parameter)
{
    Console.WriteLine("ich habe den Parameter " + parameter);
}

int addiere(int zahl1, int zahl2)
{
    return zahl1 + zahl2;
}

// Methoden Aufrufe
ohneRückgabewert();
string str1 = mitRueckgabewert();
Console.WriteLine(mitRueckgabewert());
einParameter("Bratwurst");
int int1 = addiere(1, 2);
Console.WriteLine(addiere(4, 5));