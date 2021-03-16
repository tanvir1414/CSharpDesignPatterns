namespace CSharpDesignPatterns.com._25builder
{
    public class Location
    {
        string zipCode;

        public Location(string zipCode)
        {
            this.zipCode = zipCode;
        }

        public override string ToString()
        {
            return this.zipCode;
        }

    }
}