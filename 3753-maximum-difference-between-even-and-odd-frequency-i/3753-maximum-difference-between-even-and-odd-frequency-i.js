/**
 * @param {string} s
 * @return {number}
 */
var maxDifference = function(s) {
    var count = {};
    var minEven = s.length;
    var maxOdd = 0;
    for(const c of s) count[c] = (count[c] || 0) + 1;
    for(var i of Object.values(count)){
        if(i == 0) continue;
        if( i % 2 == 1 ) maxOdd = Math.max(maxOdd, i);
        else minEven = Math.min(minEven, i);
    }
    return maxOdd - minEven;
};