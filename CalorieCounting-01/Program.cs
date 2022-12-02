var singleMealCalorieStrings = File.ReadAllLines("../../../input.txt");

var mostElfCalories = 0;
var singleElfCalories = 0;

foreach (var singleMealCalorieString in singleMealCalorieStrings)
{
    var canParse = int.TryParse(singleMealCalorieString, out var singleMeal);
    
    if (!canParse)
    {
        singleElfCalories = 0;
        continue;
    }
    
    singleElfCalories += singleMeal;

    mostElfCalories = singleElfCalories > mostElfCalories ? 
        singleElfCalories : 
        mostElfCalories;
}

Console.WriteLine($"Max calories carried by a single elf: {mostElfCalories}.");