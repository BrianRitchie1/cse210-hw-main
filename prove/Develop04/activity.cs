using System;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using System.Net.Mime;

public class Activity
{
    private List<string> _nameListening;
    private List<string> _nameReflectionBefore;
    public Activity (List<string> listening_prompts, List<string>reflection_prompts_before)
    {
        _nameListening = listening_prompts;
        _nameReflectionBefore = reflection_prompts_before;
    }
    public List<string> listenString()
    {
        return _nameListening;
    }
    public List<string> reflectionString()
    {
        return _nameReflectionBefore;
    }
    
    public Random 
    {
        Random random = new Random();

    }
    
}
