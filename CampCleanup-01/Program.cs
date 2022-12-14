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
    
    if (firstOfSecond >= firstOfFirst &&
        secondOfSecond <= secondOfFirst 
        ||
        firstOfFirst >= firstOfSecond &&
        secondOfFirst <= secondOfSecond)
    {
        overlapCount++;
    }
}

Console.WriteLine($"Number of full overlaps is: {overlapCount}.");