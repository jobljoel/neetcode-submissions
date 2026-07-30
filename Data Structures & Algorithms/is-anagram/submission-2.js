class Solution {
    /**
     * @param {string} s
     * @param {string} t
     * @return {boolean}
     */
    isAnagram(s, t) {
        if (s.length != t.length) {
            return false;
        }

        const s1 = Array(26).fill(0);
        const t1 = Array(26).fill(0);

        for (let i = 0; i < s.length; i++) {
            s1[s.charCodeAt(i) - 97]++;
            t1[t.charCodeAt(i) - 97]++;
        }

        return this.isEqual(s1, t1);

    }
    isEqual(a, b) {
        for (let i = 0; i < a.length; i++) {
            if (a[i] !== b[i]) {
                return false;
            }
        }
        return true;
    }
}