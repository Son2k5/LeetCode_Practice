public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int nums = flowerbed.Length;
        for(int i = 0; i < nums; i++){
            bool left = i == 0 || flowerbed[i -1] == 0;
            bool right = i == nums-1  ||  flowerbed[i+1] == 0;

            if(right && left && flowerbed[i] == 0){
                flowerbed[i] = 1;
                n--;
            }
        }    
        return n <= 0;     
    }
}