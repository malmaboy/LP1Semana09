namespace AnimInterf
{
    public class Dog : Animal, IMammal
    {
        public int NumberOfNipples { get; }

        public Dog(int numberOfNipples)
        {
            NumberOfNipples = numberOfNipples;
        }

        public override string Sound()
        {
            return "Woof!";
        }
    }
}