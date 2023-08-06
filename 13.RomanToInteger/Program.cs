using _13.RomanToInteger;

var solution = new Solution();
var result = solution.RomanToInt("III");
Console.WriteLine($"Expected 3. Got: {result}");

result = solution.RomanToInt("LVIII");
Console.WriteLine($"Expected 58. Got: {result}");

result = solution.RomanToInt("MCMXCIV");
Console.WriteLine($"Expected 1994. Got: {result}");


result = solution.RomanToIntLeetcode1("III");
Console.WriteLine($"Leetcode solution: Expected 3. Got: {result}");

result = solution.RomanToIntLeetcode1("LVIII");
Console.WriteLine($"Leetcode solution: Expected 58. Got: {result}");

result = solution.RomanToIntLeetcode1("MCMXCIV");
Console.WriteLine($"Leetcode solution: Expected 1994. Got: {result}");