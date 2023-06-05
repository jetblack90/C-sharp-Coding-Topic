namespace _35._ToString_Method
{
    public class Fruits
    {
        protected string name;

        public Fruits(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"You got {name}.";
        }
    }
    public class Apple : Fruits
    {
        public Apple() : base("an Apple")
        {
        }
    }
    public class Banana : Fruits
    {
        public Banana() : base("a Banana")
        {
        }
    }
}
