public class Rent : Tissue
{
    public Rent (int totalMoney, int afterRentstring, string titleBtr, int valuesBtr)
    {
        
        BtrTitle = titleBtr;
        BtrPoints = valuesBtr;
        MoneyTotal = totalMoney;
        Robbery = afterRentstring;

    }
    public override void TsRecord()
    {
        BtrAdditionPoints += BtrPoints;
    }

    public override void TsDisplay()
    {
        Console.WriteLine($"{BtrTitle} - {BtrPoints}$");
    }

    public override string TsToString()
    {
        return $"{GetType().Name},{BtrTitle},{BtrPoints},{BtrBool}";
    }

    public override void TsFromString(string data)
    {
        string[] parts = data.Split(',');
        BtrTitle = parts[1];
        BtrPoints = int.Parse(parts[2]);
        BtrBool = bool.Parse(parts[3]);
    }
}




