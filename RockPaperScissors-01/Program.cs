// ReSharper disable All
var singleGame = File.ReadLines("../../../input.txt");

const string OPPONENT_ROCK = "A";
const string OPPONENT_PAPER = "B";
const string OPPONENT_SCISSORS = "C";

const string RESPONSE_ROCK = "X";
const string RESPONSE_PAPER = "Y";
const string RESPONSE_SCISSORS = "Z";

const int DRAW_POINTS = 3;
const int WIN_POINTS = 6;
const int LOSE_POINTS = 0;

const int ROCK_POINTS = 1;
const int PAPER_POINTS = 2;
const int SCISSOR_POINTS = 3;

const string ALT_X = "LOSE";
const string ALT_Y = "DRAW";
const string ALT_Z = "WIN";

var totalPoints = 0;

foreach (var outcome in singleGame)
{
    var split = outcome.Split(" ");
    var opponentPlayed = split.First();
    var response = split.Last();

    var singleRoundPoints = calculatePoints(opponentPlayed, response);

    totalPoints += singleRoundPoints;
}

Console.WriteLine($"Total points gained is {totalPoints}.");

int calculatePoints(string opponentPlayed, string response)
{
    switch (opponentPlayed)
    {
        case OPPONENT_ROCK:
            switch (response)
            {
                case RESPONSE_ROCK:
                    return DRAW_POINTS + ROCK_POINTS;
                case RESPONSE_PAPER:
                    return WIN_POINTS + PAPER_POINTS;
                case RESPONSE_SCISSORS:
                    return LOSE_POINTS + SCISSOR_POINTS;
            }
            break;
        case OPPONENT_SCISSORS:
            switch (response)
            {
                case RESPONSE_ROCK:
                    return WIN_POINTS + ROCK_POINTS;
                case RESPONSE_PAPER:
                    return LOSE_POINTS + PAPER_POINTS;
                case RESPONSE_SCISSORS:
                    return DRAW_POINTS + SCISSOR_POINTS;
            }
            break;
        case OPPONENT_PAPER:
            switch (response)
            {
                case RESPONSE_ROCK:
                    return LOSE_POINTS + ROCK_POINTS;
                case RESPONSE_PAPER:
                    return DRAW_POINTS + PAPER_POINTS;
                case RESPONSE_SCISSORS:
                    return WIN_POINTS + SCISSOR_POINTS;
            }
            break;
    }
    return 0;
}