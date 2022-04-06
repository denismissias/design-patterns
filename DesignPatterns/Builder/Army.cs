using Builder.Creators;

namespace Builder;

public class Army
{
    public void BuildSoldier(SoldierBuilder soldierBuilder)
    {
        soldierBuilder.Gun();
        soldierBuilder.Transport();
        soldierBuilder.Focus();
    }
}