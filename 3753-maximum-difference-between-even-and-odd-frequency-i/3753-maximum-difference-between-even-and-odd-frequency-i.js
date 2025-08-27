/**
 * @param {string} s
 * @return {number}
 */
var maxDifference = function(s) {
    var count = Array(26).fill(0);
    var minEven = Infinity;
    var maxOdd = 0;
    for(const c of s) count[c.charCodeAt(0) - 'a'.charCodeAt(0)]++;
    for(var i of count){
        if(i === 0 ) continue;
        if( i % 2 === 1 ) maxOdd = Math.max(maxOdd, i);
        else minEven = Math.min(minEven, i);
    }
    return maxOdd - minEven;
};