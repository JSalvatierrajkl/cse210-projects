public class Journal
{
    public string _date;
    public string _prompt;
    public string _response;

    public List<Journal> _entries = new List<Journal>();
    
    public void Display()
    {

        foreach (var i in _entries)
            {
                i.EntryDisplay();
            }
    }
    
    public void EntryDisplay()
    {
       Console.WriteLine($"{_date} ({_prompt}) {_response}");
    }
}