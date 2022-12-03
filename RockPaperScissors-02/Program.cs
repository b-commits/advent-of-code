var singleGame = File.ReadLines("../../../input.txt");

const string OPPONENT_ROCK = "A";
const string OPPONENT_PAPER = "B";
const string OPPONENT_SCISSORS = "C";

const string LOSE = "X";
const string DRAW = "Y";
const string WIN = "Z";

const int DRAW_POINTS = 3;
const int WIN_POINTS = 6;
const int LOSE_POINTS = 0;

const int ROCK_POINTS = 1;
const int PAPER_POINTS = 2;
const int SCISSOR_POINTS = 3;

var totalPoints = 0;

foreach (var outcome in singleGame)
{
    var split = outcome.Split(" ");
    var opponentPlayed = split.First();
    var responseShouldBe = split.Last();

    var singleRoundPoints = CalculatePoints(opponentPlayed, responseShouldBe);

    totalPoints += singleRoundPoints;
}

Console.WriteLine($"{totalPoints} total points if according to plan.");

int CalculatePoints(string opponentPlayed, string responseShouldBe)
{
    switch (opponentPlayed)
    {
        case OPPONENT_ROCK:
            switch (responseShouldBe)
            {
                case LOSE:
                    return SCISSOR_POINTS + LOSE_POINTS;
                case DRAW:
                    return ROCK_POINTS + DRAW_POINTS;
                case WIN:
                    return PAPER_POINTS + WIN_POINTS;
            }
            break;
        case OPPONENT_SCISSORS:
            switch (responseShouldBe)
            {
                case LOSE:
                    return PAPER_POINTS + LOSE_POINTS;
                case DRAW:
                    return SCISSOR_POINTS + DRAW_POINTS;
                case WIN:
                    return ROCK_POINTS + WIN_POINTS;
            }
            break;
        case OPPONENT_PAPER:
            switch (responseShouldBe)
            {
                case LOSE:
                    return ROCK_POINTS + LOSE_POINTS;
                case DRAW:
                    return PAPER_POINTS + DRAW_POINTS;
                case WIN:
                    return SCISSOR_POINTS + WIN_POINTS;
            }
            break;
    }
    return 0;
}

var transformedIntoObjects
    = singleGame.Select(x => new { A = x.Length, B = "C" });

var onlyOneChar 
    = singleGame.Select(x => x.Split(" ")[0]);

var countOfA 
    = singleGame.Select(x => x.Split(" ")[0] == "A").Count();

var concat 
    = singleGame.Aggregate((one, two) => one + two);


IEnumerable<int> list = new List<int> { 1, 2, 3, 3, 3, 2, 5, 3 };


var grouped= list.GroupBy(x => x);

foreach (var grouping in grouped)
{
    foreach (var i in grouping)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine(" ");
}

