namespace asv.Actions;

class Task
{
    public long Id;
    public string? Name;
    public string? Status
    {
        get { return Name; }
        set { Name = value; }
    }
}