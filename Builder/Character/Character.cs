namespace Builder.Character
{
    public class Character
    {
        public enum ClassType
        {
            Fighter,
            Mage,
            Cleric,
            Rouge
        };

        public string Name;
        public ClassType Class;
        public int Age;
        public int Strength;
        public int Agility;
        public int Intelligence;
        public int Gold;
        public int Hp;
        public int MaxHp;

        public bool IsAlive => Hp > 0;

        public Character()
        {
        }

        public Character(string name)
        {
            Name = name;
        }

        public Character(string name, ClassType classType, int age, int hp, int strength, int agility, int intelligence,
            int gold)
        {
            Name = name;
            Class = classType;
            Age = age;
            MaxHp = hp;
            Hp = hp;
            Strength = strength;
            Agility = agility;
            Intelligence = intelligence;
            Gold = gold;
        }
    }
}