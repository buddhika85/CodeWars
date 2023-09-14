namespace CodeChallenges
{
    // https://www.codewars.com/kata/5f0ed36164f2bc00283aed07/train/csharp
    public class OverTheRoadLogic
    {
        /*
        Evens increase on the right; odds decrease on the left. House numbers start at 1 and increase without gaps.
            1|   |6
            3|   |4
            5|   |2
              you

        Given your house number address and length of street n, give the house number on the opposite side of the street.

        1, 3 Length --> 6
        3, 3 Length --> 4
        2, 3 Length --> 5
        3, 5 Length --> 8  // above street cannot determine this, because the length needs to be 5          
         */
        public static long OverTheRoad(long address, long n)
        {
            var currentLeftAddress = 1;
            var currentRightAddress = 2 * n;

            while (true)
            {
                if (currentLeftAddress == address)
                    return currentRightAddress;
                if (currentRightAddress == address)
                    return currentLeftAddress;
                currentLeftAddress += 2;
                currentRightAddress -= 2;
            }
        }
    }
}
