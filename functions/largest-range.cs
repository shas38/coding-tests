using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    // var result = RemoveDuplicates(new int[]{1,5,6,3,9,85,63,4});
    // var result = RemoveDuplicates(new int[]{1, 11, 3, 0, 15, 5, 2, 4, 10, 7, 12, 6});
        var result = RemoveDuplicates(new int[]{1,5,6,3,9,85,86,63,4});
    Console.WriteLine($"min: {result[0]}; max: {result[1]}");
  }


  public static int[] RemoveDuplicates(int[] nums){
    var bestRange = new int[2];
    var longestRange = 0;
    var numsHashMap = nums.ToDictionary(x => x, x => true);
    foreach (var num in nums){
      if(numsHashMap[num]){
        var currentLongest = 1;
        var left = num-1;
        var right = num+1;
        while(numsHashMap.ContainsKey(left)){
          currentLongest++;
          left--;
        }
        while(numsHashMap.ContainsKey(right)){
          currentLongest++;
          right++;
        }
        if(currentLongest > longestRange){
          longestRange = currentLongest;
          bestRange[0] = left + 1;
          bestRange[1] = right - 1;
        }

      }
    }
    return bestRange;
  }
}