var lines = File.ReadLines("../../../input.txt");


var stacks = GetInitialStacks(lines);

foreach (var stack in stacks)
{
    stack.RemoveAll(c => c == 32);
}


foreach (var stack in stacks)
{
    stack.RemoveAll(c => c == 32);
}


List<List<char>> GetInitialStacks(IEnumerable<string> inputLines)
{
    var columns = new List<List<char>>();
    
    foreach (var line in inputLines.Select((value, idx) => new { idx, value }))
    {
        if (line.value[0] != '[')
        {
            return columns;
        }

        columns.Add(new List<char>());
        
        for (var i = 1; i <= 29; i += 4)
        {
            columns[line.idx].Add(line.value[i]);
        }
    }
    return columns;
}

