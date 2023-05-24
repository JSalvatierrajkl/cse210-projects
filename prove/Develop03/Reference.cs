class Reference
{
    string _book;
    int _chapter;
    int _verse1;
    int _verse2;
    string _reference;

    public Reference ()
    {
        _book = "Moroni";
        _chapter = 10;
        _verse1 = 4;
        _verse2 = 5;

    }

    public string GetReference()
    {
        _reference = $"{_book} {_chapter}:{_verse1}-{_verse2}";
        return _reference;
    }
}