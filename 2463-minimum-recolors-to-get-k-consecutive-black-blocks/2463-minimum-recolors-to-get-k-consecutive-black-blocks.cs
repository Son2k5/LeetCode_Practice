public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        int n = blocks.Length;
        int minValue = k;
        for(int i = 0; i <= n - k; i++){
            int whiteCount = 0;
            for(int  j = i; j < i + k;j++){
                if(blocks[j] == 'W') whiteCount++;
            }
            minValue = Math.Min(minValue, whiteCount);
        }
        return minValue;
    }
    
}