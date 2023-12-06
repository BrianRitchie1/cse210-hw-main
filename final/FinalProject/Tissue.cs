// Parent class for budgets n stuff
public abstract class Tissue
{
    public string BtrLikeToDo {get; set; }
    public int BtrHours {get;set;}
    public string BtrTitle { get; set; }
    public int BtrPoints { get; set; }
    public bool BtrBool { get; set; }
    public int BtrMasterValue {get; set;}
    public string BtrFiber {get;set;}
    public string BtrProtien {get;set;}
    public string BtrSweet {get; set;}

    

    public abstract void BtrRecord();
    public abstract void BtrDisplay();
    public abstract string BtrToString();
    public abstract void BtrFromString(string data);
}