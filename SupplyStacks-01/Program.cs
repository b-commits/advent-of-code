var lines = File.ReadLines("../../../input.txt");

var stacks = GetInitialStacks(lines);

foreach (var stack in stacks)
{
    stack.RemoveAll(c => c == 32);
    stack.Reverse();
}

foreach (var line in lines)
{
    if (!line.StartsWith('m')) continue;

    var numPop = int.Parse(line.Split(" ")[1]);
    var columnPop = int.Parse(line.Split(" ")[3]);
    var columnPush = int.Parse(line.Split(" ").Last());

    for (var i = 0; i < numPop; i++)
    {
        var lastElement = stacks[columnPop].Last();
        stacks[columnPop].RemoveAt(stacks[columnPop].Count-1);
        stacks[columnPush].Add(lastElement);
    }
}

foreach (var stack in stacks.Where(stack => stack.Count > 0))
{
    Console.Write(stack.Last());
}


List<List<char>> GetInitialStacks(IEnumerable<string> inputLines)
{
    var columns = Enumerable.Range(1, 10).Select(_ => new List<char>()).ToList();

    foreach (var line in inputLines.Select((value, idx) => new { idx, value }))
    {
        if (line.value[0] != '[')
        {
            return columns;
        }

        var y = 0;
        
        for (var i = 1; i <= 33; i += 4)
        {
            y++;
            columns[y].Add(line.value[i]);
        }
    }
    return columns;
}

