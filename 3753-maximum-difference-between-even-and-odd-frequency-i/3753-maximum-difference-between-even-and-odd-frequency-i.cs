public class Solution {
    public int MaxDifference(string s) {
        var count = new int[26];
        foreach(char c in s){
            count[c - 'a']++;
        }
        int maxOdd=0;
        int minEven = s.Length;
        foreach(var i in count){
            if(i == 0) continue;
            if(i % 2 == 1) maxOdd = Math.Max(maxOdd, i);
            else minEven = Math.Min(minEven, i);
        }
        return maxOdd - minEven;
    }
}