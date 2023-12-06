public class Timea : Tissue
{
    public Timea(string titleBtr, int valuesTime)
    {
        BtrTitle = titleBtr;
        BtrHours = valuesTime;
    }
    public override void BtrRecord()
    {
        BtrBool = true;
    }

    public override void BtrDisplay()
    {
        Console.WriteLine($"{BtrTitle} - [{(BtrBool ? "Complete" : " ")}]");    
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