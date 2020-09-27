public class Solution {
    public int Reverse(int x) {
        var negetive = false;
        var number = x;
        if(x<0){
            negetive = true;
            number = -1*number;
        }
        long reversed = 0;
        while(number > 0){
            reversed = reversed * 10 + number % 10;
            number /= 10;
        }
        if(reversed > int.MaxValue) return 0;
        return negetive ? (int)(reversed * -1) : (int)reversed;
    }
}