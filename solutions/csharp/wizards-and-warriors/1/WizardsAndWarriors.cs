abstract class Character
{
    protected Character(string characterType)
    {
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public override string ToString()
    {
        return "Character is a " + this.GetType().Name;
    }
}

class Warrior : Character
{
    public Warrior() : base("TODO")
    {
    }
    public override string ToString()
    {
        return "Character is a Warrior";
    }
    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable())
            return 10;
        else
            return 6;
    }
}

class Wizard : Character
{
    private bool PreparedSpell = false;
    public Wizard() : base("TODO")
    {
    }
    public override string ToString()
    {
        return "Character is a Wizard";
    }
    public override int DamagePoints(Character target)
    {
        if (PreparedSpell)
        {
            PreparedSpell = false;
            return 12;
        }
        else
            return 3;
    }

    public void PrepareSpell()
    {
        PreparedSpell = true;
    }
    public override bool Vulnerable()
    {
        return !PreparedSpell;
    }
}
