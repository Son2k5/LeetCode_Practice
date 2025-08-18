/**
 * @param {number[]} flowerbed
 * @param {number} n
 * @return {boolean}
 */
var canPlaceFlowers = function(flowerbed, n) {
     let count = flowerbed.length;
     for(let i = 0; i < count; i++ ){
        let left = i === 0 || flowerbed[i-1] === 0
        let right = i === count -1 || flowerbed[i+1] === 0;

        if(left && right && flowerbed[i] === 0){
            flowerbed[i] = 1;
            n--;
        } 
     }
     return n <= 0;
};