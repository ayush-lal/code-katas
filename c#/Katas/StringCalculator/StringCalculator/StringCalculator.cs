namespace StringCalculatorMethods
{
    public class StringCalculator
    {
        private readonly char[] _defaultDelimiters = new[] {',', '\n'};
        
        public int Add(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            var integers = GetIntegersFromInput(input);
            var negativeIntegers = new List<int>();

            var sum = integers.Sum(s => ParseIntegers(s, negativeIntegers));

            if (negativeIntegers.Any())
            {
                throw new Exception($"negative values not allowed: {string.Join(" ", negativeIntegers)}");
            }

            return sum;
            // return integers.Sum(ParseIntegers);
        }

        private static int ParseIntegers(string input, List<int> negativeIntegers)
        {
            var integer = int.Parse(input);

            if (integer < 0)
            {
                negativeIntegers.Add(integer);
                // throw new Exception($"negatives not allowed: {integer}");
            }
            
            return integer;
        }

        private IEnumerable<string> GetIntegersFromInput(string input)
        {
            var delimiters = new List<char>(_defaultDelimiters);
                
            if (IsDelimiterDefined(input))
            {
                 input = GetSpecificDelimiter(input, delimiters);
            }
            
            return input.Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries);
        }

        private static bool IsDelimiterDefined(string input)
        {
            return input.StartsWith("//");
        }

        private static string GetSpecificDelimiter(string input, List<char> delimiters)
        {
            input = input.Replace("//", "");
            delimiters.Add(input[0]);
            return input;
        }
    }
}