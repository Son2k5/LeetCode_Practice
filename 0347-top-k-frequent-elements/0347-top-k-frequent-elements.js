/**
 * @param {number[]} nums
 * @param {number} k
 * @return {number[]}
 */
var topKFrequent = function (nums, k) {
    const freqMap = new Map();
    for (let num of nums) {
        freqMap.set(num, (freqMap.get(num) || 0) + 1);
    }
    const buckets = Array(nums.length + 1).fill().map(() => []);
    for (let [num, freq] of freqMap.entries()) {
        buckets[freq].push(num);
    }
    const res = [];
    for (let i = buckets.length - 1; i >= 0 && res.length < k; i--) {
        for (let num of buckets[i]) {
            res.push(num);
            if (res.length === k) break;
        }
    }
    return res
};