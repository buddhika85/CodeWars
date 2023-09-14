using CodeChallenges;

namespace ConsoleTester;

using static System.Console;
public class OverTheRoadLogicTest
{
    public void Test()
    {
        WriteLine($"{OverTheRoadLogic.OverTheRoad(1, 3) == 6}");
        WriteLine($"{OverTheRoadLogic.OverTheRoad(3, 3) == 4}");
        WriteLine($"{OverTheRoadLogic.OverTheRoad(2, 3) == 5}");
        WriteLine($"{OverTheRoadLogic.OverTheRoad(3, 5) == 8}");
        WriteLine($"{OverTheRoadLogic.OverTheRoad(7, 11) == 16}");
    }
}