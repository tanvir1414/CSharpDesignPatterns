namespace CSharpDesignPatterns.com._25builder
{
    public class Driver
    {
        private string name;
        public int Age { get; set; }

        public Driver(string name, int age)
        {
            this.name = name;
            this.Age = age;
        }
        public override string ToString()
        {
            return this.name + "(" +this.Age + ")";
        }
    }
}