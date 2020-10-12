//
// furthestPoints L
//
// Returns the pair of points with the greatest distance
// 
// Examples: 
//          furthestPoints [(1.0,0.0);(-5.0,0.0)] -> ((1.0,0.0),(-5.0,0.0))
//          furthestPoints [(1.0,0.0);(-5.0,0.0);(3.0,2.5)] -> 
//                         ((-5.0,0.0),(3.0,2.5))
//          furthestPoints [(2.0,0.0);(1.0,1.0);(-0.3,0.5);(0.2,-1.6)] -> 
//                         ((1.0,1.0),(0.2,-1.6))
//          furthestPoints [(2.0,1.5);(3.0,-1.0);(4.0,0.5);(3.0,1.0)] -> 
//                         ((2.0,1.5),(3.0,-1.0))
//

int main()
{
    List originalList = [(2.0,1.5),(3.0,-1.0),(4.0,0.5),(3.0,1.0)];

    double currentLongestDist = -999;
    tuple currentFurthestTuples;

    tuple furthestPoints()
    {
        for (auto firstTuple : originalList)
        {
            for (auto secondTuple : originalList)
            {
                int xDifference = firstTuple.first - secondTuple.first;
                int yDifference = firstTuple.second - secondTuple.second;
                double currentDist = PythagoreanFunction(xDifference, yDifference);
                                //^Also known as distanceFromOrigin in function 18
                if (currentDist > currentLongestDist)
                {
                    currentLongestDist = currentDist;
                    currentFurthestTuples = (firstTuple, secondTuple);
                }
            }
        }
        //Should now have the furthest tuples in currentFurthestTuples.
        return currentFurthestTuples;
    }
}