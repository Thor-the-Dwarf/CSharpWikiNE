
Interfaces in C# sind Verträge oder Blaupausen für Klassen. Sie definieren eine Gruppe von 
öffentlichen Methoden und Eigenschaften, die von jeder Klasse, die das Interface implementiert, bereitgestellt werden müssen.

Ein Interface:
- Definiert einen Vertrag, den implementierende Klassen einhalten müssen.
- Kann Methoden, Eigenschaften, Indexer und Ereignisse enthalten, aber keine Felder (Variablen).
- Erlaubt keine Implementierungsdetails. Alle Methoden und Eigenschaften sind per Definition abstrakt, auch wenn das Schlüsselwort 'abstract' nicht explizit verwendet wird.
- Kann von einer beliebigen Anzahl von Klassen implementiert werden, wodurch Mehrfachvererbung in Form von Polymorphismus ermöglicht wird.
- Dient der Trennung der Definition einer Funktionalität von ihrer Implementierung, was die Wartbarkeit und Erweiterbarkeit des Codes fördert.
