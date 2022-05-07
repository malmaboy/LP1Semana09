namespace AnimInterf
{
    public class Bat : Animal, ICanFly, IMammal
    {
        public int NumberOfWings { get; }
        public int NumberOfNipples { get; }

        public Bat(int numberOfWings, int numberOfNipples)
        {
            NumberOfWings = numberOfWings;
            NumberOfNipples = numberOfNipples;
        }

        public override string Sound()
        {
            return "Squiq! Squiq!";
        }
    }
}