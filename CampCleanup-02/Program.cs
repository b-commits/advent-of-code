var lines = File.ReadAllLines("../../../input.txt");

var overlapCount = 0;

foreach (var line in lines)
{
    var first = line.Split(",")[0].Split("-");
    var second = line.Split(",")[1].Split("-");

    var firstOfSecond = int.Parse(second.First());
    var firstOfFirst = int.Parse(first.First());

    var secondOfSecond = int.Parse(second.Last());
    var secondOfFirst = int.Parse(first.Last());
    
    if ((firstOfFirst >= firstOfSecond && firstOfFirst <= secondOfSecond) ||
        (secondOfFirst <= secondOfSecond && secondOfFirst >= firstOfSecond) 
        ||
        (secondOfSecond >= firstOfFirst && secondOfSecond <= secondOfFirst) || 
        (firstOfSecond >= firstOfFirst && firstOfSecond <= secondOfFirst))
    {
        overlapCount++;
    }
}

Console.WriteLine($"Number of partial overlaps is: {overlapCount}.");