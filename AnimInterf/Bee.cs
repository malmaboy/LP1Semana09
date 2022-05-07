namespace AnimInterf
{
    public class Bee : Animal, ICanFly
    {
        public int NumberOfWings { get; }

        public Bee(int numberOfWings)
        {
            NumberOfWings = numberOfWings;
        }

        public override string Sound()
        {
            return "bzzz! bzzz!";
        }
    }
}