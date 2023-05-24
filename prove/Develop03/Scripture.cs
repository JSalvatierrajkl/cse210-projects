class Scripture
{
    List<string> _wlist = new List<string>() {"4 ", "And ", "when ", "ye ", "shall ", "receive ", "these ", "things, ", "I ", "would ", "exhort ", "you ", "that ", "ye ", "would ", "ask ", "God, ", "the ", "Eternal ", "Father, ", "in ", "the ", "name ", "of ", "Christ", ", ", "if ", "these ", "things ", "are ", "not ", "true; ", "and ", "if ", "ye ", "shall ", "ask ", "with ", "a ", "sincere ", "heart, ", "with ", "real ", "intent, ", "having ", "faith ", "in ", "Christ, ", "he ", "will ", "manifest ", "the ", "truth ", "of ", "it ", "unto ", "you, ", "by ", "the ", "power ", "of ", "the ", "Holy ", "Ghost.", "5 ", "And ", "by ", "the ", "power ", "of ", "the ", "Holy ", "Ghost ", "ye ", "may ", "know ", "the ", "truth ", "of ", "all ", "things."};
    
    string _random = "";


    
    public Scripture ()
    {
        Random rnd = new Random();
        int randIndex0 = rnd.Next(_wlist.Count);
        _wlist[randIndex0] = "___";
        _random = _wlist[randIndex0];
        int randIndex1 = rnd.Next(_wlist.Count);
        _wlist[randIndex1] = "___";
        _random = _wlist[randIndex1];
        int randIndex2 = rnd.Next(_wlist.Count);
        _wlist[randIndex2] = "___";
        _random = _wlist[randIndex2];
        Console.WriteLine($"{_wlist[0]}{_wlist[1]} {_wlist[2]} {_wlist[3]} {_wlist[4]} {_wlist[5]} {_wlist[6]} {_wlist[7]} {_wlist[8]} {_wlist[9]} {_wlist[10]} {_wlist[11]} {_wlist[12]} {_wlist[13]} {_wlist[14]} {_wlist[15]} {_wlist[16]} {_wlist[17]} {_wlist[18]} {_wlist[19]} {_wlist[20]} {_wlist[21]} {_wlist[22]} {_wlist[23]} {_wlist[24]} {_wlist[25]} {_wlist[26]} {_wlist[27]} {_wlist[28]} {_wlist[29]} {_wlist[30]} {_wlist[31]} {_wlist[32]} {_wlist[33]} {_wlist[34]} {_wlist[35]} {_wlist[36]} {_wlist[37]} {_wlist[38]} {_wlist[39]} {_wlist[40]} {_wlist[41]} {_wlist[42]} {_wlist[43]} {_wlist[44]} {_wlist[45]} {_wlist[46]} {_wlist[47]} {_wlist[48]} {_wlist[49]} {_wlist[50]} {_wlist[51]} {_wlist[52]} {_wlist[53]} {_wlist[54]} {_wlist[55]} {_wlist[56]} {_wlist[57]} {_wlist[58]} {_wlist[59]} {_wlist[60]} {_wlist[61]} {_wlist[62]} {_wlist[63]}");
        Console.WriteLine($"{_wlist[64]} {_wlist[65]} {_wlist[66]} {_wlist[67]} {_wlist[68]} {_wlist[69]} {_wlist[70]} {_wlist[71]} {_wlist[72]} {_wlist[73]} {_wlist[74]} {_wlist[75]} {_wlist[76]} {_wlist[77]} {_wlist[78]} {_wlist[79]} {_wlist[80]}");
        
    }
    
    public string Display()
    {
        return _random;
    }


    
    // GetRenderedText (): Void
    // IsCompletelyHidden(): Void


}