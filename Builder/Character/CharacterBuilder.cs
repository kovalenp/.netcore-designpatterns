using Builder.Character.Infrastructure;

namespace Builder.Character
{
    public class CharacterBuilder : ICharacterBuilderClassType, ICharacterBuilderAge, ICharacterBuilderStats
    {
        private Character _character;
        public CharacterBuilder Build(string name)
        {
            _character = new Character(name);
            return this;
        }
        public ICharacterBuilderAge As(Character.ClassType classType)
        {
            _character.Class = classType;
            return this;
        }
        public ICharacterBuilderStats WithAge(int age)
        {
            _character.Age = age;
            return this;
        }
        public ICharacterBuilderStats Str(int strength)
        {
            _character.Strength = strength;
            return this;
        }
        public ICharacterBuilderStats Agi(int agility)
        {
            _character.Agility = agility;
            return this;
        }
        public ICharacterBuilderStats Int(int intelligence)
        {
            _character.Intelligence = intelligence;
            return this;
        }
        public ICharacterBuilderStats Hp(int hp)
        {
            _character.Hp = hp;
            _character.MaxHp = hp;
            return this;
        }
        public ICharacterBuilderStats Gold(int gold)
        {
            _character.Gold = gold;
            return this;
        }
        public Character Create()
        {
            return _character;
        }
    }
}
