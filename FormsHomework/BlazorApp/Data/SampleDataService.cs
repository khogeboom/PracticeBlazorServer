namespace BlazorApp.Data
{
    public class SampleDataService : ISampleDataService
    {
        public List<string> GetMilkshakeTypes()
        {
            return new List<string>
            {
                "Chocolate",
                "Vanille",
                "Peanut Butter",
                "Strawberry"
            };

        }

        public List<string> GetMilkshakeSizes()
        {
            return new List<string>
            {
                "Small",
                "Medium",
                "Large",
                "Extra Large"
            };

        }
    }
}
