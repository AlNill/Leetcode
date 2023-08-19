using _67.AddBinary;

var s = new Solution();
var result = s.AddBinary("11", "1");
Console.WriteLine($"Expected 100, Got: {result}");

result = s.AddBinary("1010", "1011");
Console.WriteLine($"Expected 10101, Got: {result}");

result = s.AddBinary("101111", "10");
Console.WriteLine($"Expected 110001, Got: {result}");


result = s.AddBinaryNew("11", "1");
Console.WriteLine($"New Expected 100, Got: {result}");

result = s.AddBinaryNew("1010", "1011");
Console.WriteLine($"New Expected 10101, Got: {result}");

result = s.AddBinaryNew("101111", "10");
Console.WriteLine($"New Expected 110001, Got: {result}");