
// Klasse im globalen Namespace
class GlobalClass
{
    public void SayHello()
    {
        Console.WriteLine("Hallo aus dem globalen Namespace!");
    }
}

namespace MeinNamespace
{
    // Klasse im darunterliegenden Namspace
    class DrunterKlasse
    {
        GlobalClass habeZugriff;
    }
}

/* 
     Globale Namespaces: 
         Der globale Namespace ist der Stamm aller Namespaces, 
         kein expliziter Name erforderlich.
 
    GlobalClass ist im globalen Namespace definiert, da sie außerhalb eines 
    deklarierten Namespaces steht. Innerhalb des MeinNamespace-Namespaces 
    können wir direkt auf GlobalClass zugreifen, ohne einen Namespace-Präfix 
    zu benötigen. Der globale Namespace ermöglicht es uns, auf GlobalClass 
    zuzugreifen, obwohl sie sich nicht innerhalb des MeinNamespace-Namespaces befindet.
*/