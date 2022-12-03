var rucksacks = File.ReadLines("../../../input.txt");

const int ASCII_CAPITAL_A = 65;
const int ASCII_LOWERCASE_A = 97;
const int ALPHABET_COUNT = 26;
const int ELVES_PER_GROUP = 3;

var totalPriority = 0;
var threeRucksacks = new List<string>();

foreach (var rucksack in rucksacks)
{
    threeRucksacks.Add(rucksack);

    if (threeRucksacks.Count == ELVES_PER_GROUP)
    {
        var groupBadge = GetGroupBadge(threeRucksacks);
        var priority = GetItemPriority(groupBadge);
        totalPriority += priority;
        threeRucksacks = new List<string>();
    }
}

Console.WriteLine($"Total priority of group badges {totalPriority}.");

char? GetGroupBadge(List<string> groupRucksacks)
{
    foreach (var items in groupRucksacks.Select(groupRucksack => groupRucksack.ToCharArray()))
    {
        foreach (var item in items)
        {
            var foundBadge = groupRucksacks.All(rucksack => rucksack.Contains(item));
            if (foundBadge) return item;
        }
    }
    return null;
}

IEnumerable<int> GetItemTypes()
    => Enumerable.Range(ASCII_LOWERCASE_A, ALPHABET_COUNT)
        .Concat(Enumerable.Range(ASCII_CAPITAL_A, ALPHABET_COUNT)).ToList();

int GetItemPriority(char? item)
    => GetItemTypes().ToList().FindIndex(x=> x == item) + 1;