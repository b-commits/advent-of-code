var rucksacks = File.ReadLines("../../../input.txt");

const int ASCII_CAPITAL_A = 65;
const int ASCII_LOWERCASE_A = 97;
const int ALPHABET_COUNT = 26;

var totalPriority = 0;

foreach (var rucksack in rucksacks)
{
    var contents = GetCompartmentContents(rucksack);
    var sharedItem = GetSharedItem(contents.Item1, contents.Item2);
    var priority = GetItemPriority(sharedItem);
    totalPriority += priority;
}

Console.WriteLine($"Total priority of shared items is {totalPriority}.");

(string, string) GetCompartmentContents(string rucksack) 
    => (rucksack[..(rucksack.Length / 2)], rucksack[(rucksack.Length / 2)..]);


char GetSharedItem(string firstCompartment, string secondCompartment)
    => firstCompartment.First(secondCompartment.Contains);

IEnumerable<int> GetItemTypes()
    => Enumerable.Range(ASCII_LOWERCASE_A, ALPHABET_COUNT)
            .Concat(Enumerable.Range(ASCII_CAPITAL_A, ALPHABET_COUNT)).ToList(); 

int GetItemPriority(char item)
    => GetItemTypes().ToList().FindIndex(x=> x == item) + 1;