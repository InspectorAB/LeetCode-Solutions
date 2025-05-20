public class Solution {
    public int MaxArea(int[] height) {
        int maxArea = 0;
        int aPoint = 0;
        int bPoint = height.Length-1;

        while(aPoint < bPoint)
        {
            if(height[aPoint] < height[bPoint]){
                maxArea = Math.Max(maxArea,height[aPoint] * (bPoint - aPoint));
                aPoint += 1;
            }else{
                maxArea = Math.Max(maxArea,height[bPoint] * (bPoint - aPoint));
                bPoint -= 1;
            }
        }
        return maxArea;
    }
}