// Child class for food budget
public class Food : Tissue
{
    public Food (string titleBtr, string fiberBtr, string protienBtr, string sweetBtr, int valuesBtr)
    {
        BtrTitle = titleBtr;
        BtrPoints = valuesBtr;
        BtrFiber = fiberBtr;
        BtrProtien = protienBtr;
        BtrSweet = sweetBtr;
    }
    public override void BtrRecord()
    {
    }

    public override void BtrDisplay()
    {
        Console.WriteLine($"{BtrTitle} - {BtrPoints}$");
        Console.WriteLine($"With this money, you'll be getting {BtrFiber} for your gut health");
        Console.WriteLine($"{BtrProtien} for healthy muscle growth and support");
        Console.WriteLine($"And {BtrSweet} for your sanity");
        Console.WriteLine(" ");
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