namespace Builder.Creators;

public class SpecialForcesBuilder : SoldierBuilder
{
    public SpecialForcesBuilder()
    {
        _soldier = new SpecialForcesSoldier();
    }
    
    public override void Gun()
    {
        _soldier?.ChoseGun("Rifle");
    }

    public override void Transport()
    {
        _soldier?.ChoseTransport("Special operations car");
    }

    public override void Focus()
    {
        _soldier?.SetFocus("Ground Combat");
    }
}