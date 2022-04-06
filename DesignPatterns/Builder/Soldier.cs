namespace Builder;

public abstract class Soldier
{
    public string? Gun { get; protected set; }
    public string? Transport { get; protected set; }
    public string? Focus { get; protected set; }

    public abstract void ChoseGun(string? gun);
    public abstract void ChoseTransport(string? transport);
    public abstract void SetFocus(string? focus);
}