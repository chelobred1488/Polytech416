namespace Lesson4;

public class Matn
{
    private string txt;

    public string Txt
    {
        get => txt;
        set
        {
            txt = value;
        }
    }

    public int Len
    {
        get
        {
            return txt.Length;
        }
    }

    public string[] Kalima
    {
        get
        {
            return txt.Split(' ');
        }
    }
}