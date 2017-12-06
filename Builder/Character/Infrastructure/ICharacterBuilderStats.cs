namespace Builder.Character.Infrastructure
{
    public interface ICharacterBuilderStats
    {
        ICharacterBuilderStats Hp(int hp);
        ICharacterBuilderStats Str(int strength);
        ICharacterBuilderStats Agi(int agility);
        ICharacterBuilderStats Int(int intelligence);
        ICharacterBuilderStats Gold(int gold);
    }
}