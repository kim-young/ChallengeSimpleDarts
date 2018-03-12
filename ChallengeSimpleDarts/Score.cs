using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace ChallengeSimpleDarts
{
    public class Score
    {
        public static void CalculateScore(Player player, Dart dart)
        {
            int score = 0;

            if (dart.OuterBand) score = dart.Point * 2;
            else if (dart.InnerBand) score = dart.Point * 3;
            else score = dart.Point;

            if (dart.InnerBand && dart.Point == 0) score += 50;
            else if(dart.Point == 0) score += 25;

            player.Score += score;  
        }
    }
}