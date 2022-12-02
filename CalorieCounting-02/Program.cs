var singleMealCalorieStrings = File.ReadAllLines("../../../input.txt");

var singleElfCalories = 0;

var elfCalories = new List<int>();

foreach (var singleMealCalorieString in singleMealCalorieStrings)
{
    var canParse = int.TryParse(singleMealCalorieString, out var singleMeal);
    
    if (!canParse)
    {
        elfCalories.Add(singleElfCalories);
        singleElfCalories = 0;
        continue;
    }
    
    singleElfCalories += singleMeal;
}

var totalTopThree = elfCalories.OrderByDescending(x => x).Take(3).Sum();
    
Console.WriteLine("The sum of calories carried by the three elves that carry " +
                  $"most calories: {totalTopThree}.");