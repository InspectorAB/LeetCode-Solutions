public class Solution {
    public int ClimbStairs(int n) {
        if( n == 1) return n;
        if( n == 2) return n;

        int first = 1;
        int second  = 1;
        while(n-- > 0){
            int temp = first;
            first = second;
            second = temp + second;
        }
        return first;
    }
}