// Child class for fun budget
public class Fun : Tissue
{
    public Fun (string titleBtr, int valuesBtr, string fun_description)
    {
        BtrTitle = titleBtr;
        BtrPoints = valuesBtr;
        BtrLikeToDo = fun_description;
    }
    public override void BtrRecord()
    {
    }

    public override void BtrDisplay()
    {
        Console.WriteLine($"{BtrTitle} - {BtrPoints}$");
        Console.WriteLine($"This money goes to the activity of: {BtrLikeToDo}. Don't spend it otherwise");
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



