public class Master : Tissue
{
    public Master (string titleBtr, int valueMaster )
    {
        BtrTitle = titleBtr;
        BtrPoints = valueMaster;
    }
    public override void BtrRecord()
    {
        BtrAdditionPoints += BtrPoints;
    }

    public override void BtrDisplay()
    {
        Console.WriteLine($"{BtrTitle} -$");
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
