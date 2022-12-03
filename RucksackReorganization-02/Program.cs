var rucksacks = File.ReadLines("../../../input.txt");

const int ASCII_CAPITAL_A = 65;
const int ASCII_LOWERCASE_A = 97;
const int ALPHABET_COUNT = 26;
const int ELVES_PER_GROUP = 3;

var totalPriority = 0;
var groupRucksacks = new List<string>();

foreach (var rucksack in rucksacks)
{
    groupRucksacks.Add(rucksack);

    if (groupRucksacks.Count == ELVES_PER_GROUP)
    {
        var groupBadge = GetGroupBadge(groupRucksacks);
        var priority = GetItemPriority(groupBadge);
        totalPriority += priority;
        groupRucksacks = new List<string>();
    }
}

Console.WriteLine($"Total priority of group badges {totalPriority}.");

char GetGroupBadge(List<string> groupRucksacks)
{
    return groupRucksacks
        .SelectMany(x => x.ToCharArray())
        .FirstOrDefault(x => groupRucksacks.All(y => y.Contains(x)));
}

IEnumerable<int> GetItemTypes()
    => Enumerable.Range(ASCII_LOWERCASE_A, ALPHABET_COUNT)
        .Concat(Enumerable.Range(ASCII_CAPITAL_A, ALPHABET_COUNT)).ToList();

int GetItemPriority(char? item)
    => GetItemTypes().ToList().FindIndex(x=> x == item) + 1;