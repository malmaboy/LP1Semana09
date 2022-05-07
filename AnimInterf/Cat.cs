namespace AnimInterf
{
    public class Cat : Animal, IMammal
    {
        public int NumberOfNipples { get; }

        public Cat(int numberOfNipples)
        {
            NumberOfNipples = numberOfNipples;
        }

        public override string Sound()
        {
            return "Miau!";
        }
    }
}