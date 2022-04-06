namespace Builder.Creators;

public class LightInfantaryBuilder : SoldierBuilder
{
    public LightInfantaryBuilder()
    {
        _soldier = new LightInfantrySoldier();
    }
    public override void Gun()
    {
        _soldier?.ChoseGun("Air strike");
    }

    public override void Transport()
    {
        _soldier?.ChoseTransport("Army attack helicopter");
    }

    public override void Focus()
    {
        _soldier?.SetFocus("Air fast response");
    }
}