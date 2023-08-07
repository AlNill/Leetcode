
using _14.LongestCommonPrefix;

Solution s = new Solution();
Console.WriteLine($"Expected 'fl', but was: {s.LongestCommonPrefix(new string[] { "flower", "flow", "flight" })}");
Console.WriteLine($"Expected 'fl', but was: {s.LongestCommonPrefix(new string[] { "dog", "racecar", "car" })}");

Console.WriteLine($"Expected 'fl', but was: {s.LongestCommonPrefixSolution(new string[] { "flower", "flow", "flight" })}");
Console.WriteLine($"Expected 'fl', but was: {s.LongestCommonPrefixSolution(new string[] { "dog", "racecar", "car" })}");
