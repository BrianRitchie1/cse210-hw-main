// child class for rent budget
public class Rent : Tissue
{
    public Rent (string titleBtr, int valuesBtr)
    {
        
        BtrTitle = titleBtr;
        BtrPoints = valuesBtr;
       

    }
    public override void BtrRecord()
    {
    }

    public override void BtrDisplay()
    {
        Console.WriteLine($"{BtrTitle} - {BtrPoints}$");
    }

    public override string BtrToString()
    {
        return $"{GetType().Name},{BtrTitle},{BtrPoints},{BtrBool}";
    }

    public override void BtrFromString(string data)
    {
        string[] parts = data.Split(',');
        BtrTitle = parts[1];
        BtrPoints = int.Parse(parts[2]);
        BtrBool = bool.Parse(parts[3]);
    }
}




