using _70.ClimbingStairs;

var s = new Solution();
Console.WriteLine(s.ClimbStairs(4));


var result = s.ClimbStairs(1);
Console.WriteLine($"{result}. Expected: 1");

result = s.ClimbStairs(2);
Console.WriteLine($"{result}. Expected: 2");

result = s.ClimbStairs(3);
Console.WriteLine($"{result}. Expected: 3");

result = s.ClimbStairs(4);
Console.WriteLine($"{result}. Expected: 5");

result = s.ClimbStairs(5);
Console.WriteLine($"{result}. Expected: 8");