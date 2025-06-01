public class Solution {
    public bool LemonadeChange(int[] bills) {
        int fiveS = 0, tenS = 0 , twentyS = 0;
        bool isPossible = true;
        for(int i = 0; i < bills.Length;i++){
            if(bills[i] == 5){
                fiveS++;
            }else if(bills[i] == 10){
                if(fiveS >= 1){
                    fiveS--;
                    tenS++;
                }else{
                    //Console.WriteLine("10s");
                    isPossible = false;
                    break;
                }
            }else{
                if(tenS >= 1 && fiveS >= 1){
                    tenS--;
                    fiveS--;
                }else if(fiveS>=3){
                    fiveS -= 3;
                }else{
                    isPossible = false;
                    break;
                }
            }
        }
        return isPossible;
    }
}