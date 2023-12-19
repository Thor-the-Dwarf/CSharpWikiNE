namespace _010_GetterSetter;

public class Auto
{
    private string _farbe;
    private int _baujahr;
    private bool _hasDach;
    private string _typ;
    
    // Getter-Methode
    public string GetFarbe()
    {
        return this._farbe;
    }
    
    // Setter-Methode
    public void SetFarbe(string value)
    {
        this._farbe = value;
    }
    
    // Kurzform
    public int Baujahr
    {
        get { return this._baujahr; }
        set { this._baujahr = value; }
    }
    
    // Kürzere Form
    public bool HasDach
    {
        get => this._hasDach;
        set => this._hasDach = value;
    }
    
    // Kürzeste Form
    public string Typ { get; set; }
}