// Parent class for all other goals
public abstract class Tissue
{
    public int Robbery {get; set;}
    public int MoneyTotal {get; set;}
    public string BtrTitle { get; set; }
    public int BtrPoints { get; set; }
    public bool BtrBool { get; set; }
    public int BtrMasterValue {get; set;}

    public int BtrAdditionPoints {get; set; }

    public abstract void BtrRecord();
    public abstract void BtrDisplay();
    public abstract string BtrToString();
    public abstract void BtrFromString(string data);
}