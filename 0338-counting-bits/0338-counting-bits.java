class Solution {
    public int[] countBits(int n) {
        var result = new int[n + 1];

        int b = 1;
        while(b <= n){
            var i = 0;
            while(i < b && b + i <= n){
                result[i+b] = result[i] + 1;
                i++;
            }
            b <<= 1;
        }
        return result;
    }
}