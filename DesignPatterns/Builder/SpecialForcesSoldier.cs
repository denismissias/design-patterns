namespace Builder;

public class SpecialForcesSoldier : Soldier
{
    public override void ChoseGun(string? gun)
    {
        Gun = gun;
    }

    public override void ChoseTransport(string? transport)
    {
        Transport = transport;
    }

    public override void SetFocus(string? focus)
    {
        Focus = focus;
    }
}