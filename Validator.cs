using System;
using System.Collections.Generic;
using System.Linq;

namespace GenPOTW {
  public class Validator {
    public static List < Player > AntiCheatCheck(List < Player > playerStats) {
      List < Player > validPlayers = new List < Player > ();
      
      Dictionary < string, double > fieldMeans = new Dictionary < string, double > ();
      Dictionary < string, double > fieldDeviations = new Dictionary < string, double > ();

      foreach(var property in typeof (Player).GetProperties()) {
        if (property.PropertyType == typeof (int)) {
          string fieldName = property.Name;
          int[] fieldValues = playerStats.Select(p => (int) property.GetValue(p)).ToArray();
          double mean = fieldValues.Average();
          double deviation = CalculateStandardDeviation(fieldValues);

          fieldMeans.Add(fieldName, mean);
          fieldDeviations.Add(fieldName, deviation);
        }
      }
      
      double zScoreThreshold = 3.0;

      foreach(Player player in playerStats) {
        bool isOutlier = false;

        foreach(var property in typeof (Player).GetProperties()) {
          if (property.PropertyType == typeof (int)) {
            string fieldName = property.Name;
            int fieldValue = (int) property.GetValue(player);
            double mean = fieldMeans[fieldName];
            double deviation = fieldDeviations[fieldName];
            double zScore = (fieldValue - mean) / deviation;
            
            if (Math.Abs(zScore) > zScoreThreshold) {
              Console.WriteLine("Potential outlier detected: " + player.getName() + " - Field: " + fieldName + " - Value: " + fieldValue);
              isOutlier = true;
              break;
            }
          }
        }

        if (!isOutlier) {
          validPlayers.Add(player);
        }
      }

      return validPlayers;
    }

    static double CalculateStandardDeviation(int[] values) {
      double mean = values.Average();
      double sumOfSquaredDifferences = values.Sum(v => Math.Pow(v - mean, 2));
      double variance = sumOfSquaredDifferences / values.Length;
      double standardDeviation = Math.Sqrt(variance);
      return standardDeviation;
    }
  }
}