public class Solution {
    public int HammingWeight(int n) {
        var num = 0;
        while( n > 0){
            n &= n - 1;
            num++; 
        }
        return num;
    }
}