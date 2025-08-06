var lengthOfLongestSubstring = function(s) {
    let maxLen = 0;

    for (let i = 0; i < s.length; i++) {
        let set = new Set();
        for (let j = i; j < s.length; j++) {
            let c = s.charAt(j);
            if (set.has(c)) {
                break;
            }
            set.add(c);
            maxLen = Math.max(maxLen, j - i + 1);
        }
    }

    return maxLen;
};
