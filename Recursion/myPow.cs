public class Solution {
    public double MyPow(double x, int n) {
        if (n == 0)
            return 1;
        // recursion
        if (n < 0)
            return 1/MyPow(x, -n);
        if (n%2 != 0)
            return x*MyPow(x, n - 1);
        return MyPow(x*x, n/2);
    }
}