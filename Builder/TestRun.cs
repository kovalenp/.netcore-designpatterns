using Builder.Character;
using Class = Builder.Character.Character.ClassType;

namespace Builder
{
    public class TestRun
    {
        public static void Main(string[] args)
        {
            var charBuilder = new CharacterBuilder();

           charBuilder.Build("Henry")
                .As(Class.Mage)
                .WithAge(21)
                .Hp(100)
                .Str(3)
                .Agi(12)
                .Int(26)
                .Gold(9000);

            var henry = charBuilder.Create();
            
        }
    }
}
