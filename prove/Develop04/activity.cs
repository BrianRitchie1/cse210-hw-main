using System;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using System.Net.Mime;

public class Activity
{
    private List<string> _nameListening;
    private List<string> _nameReflection;
    public Activity (List<string> nameListening, List<string>nameReflection)
    {
        _nameListening = nameListening;
        _nameReflection = nameReflection;
    }
    public List<string> listenString()
    {
        return _nameListening;
    }
    public List<string> reflectionString()
    {
        return _nameReflection;
    }
    
    public Random 
    {
        Random random = new Random();

    }
    
}
