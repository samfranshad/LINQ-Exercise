namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var crochetStitches = new List<string>() { "single", "half double", "double", "slip", "increase", "decrease" };

            var orderedStitches = crochetStitches.OrderBy(stitch => stitch.Length);

            foreach (var stitch in orderedStitches)
            {
                Console.WriteLine(stitch);
            }
        }
    }
}
