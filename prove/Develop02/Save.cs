using System;
using System.IO;
public class Filemanager
{
    string gcFilePath = Environment.CurrentDirectory;
    public void GcSave (string gcFileName, string gcFilePath){
        File.WriteAllText(gcFileName, gcFilePath);
        Console.WriteLine("file successfully save."); 
    }
    
    
}  