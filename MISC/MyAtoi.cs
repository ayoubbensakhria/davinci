public class Solution {
    public int MyAtoi(string s) {
        int sign = 1; 
        int result = 0; 
        int index = 0;
        int n = s.Length;

        // Discard all spaces from the beginning of the input string.
        while (index < n && s[index] == ' ') { 
            index++; 
        }

        // sign = +1, if it's positive number, otherwise sign = -1. 
        if (index < n && s[index] == '+') {
            sign = 1;
            index++;
        } else if (index < n && s[index] == '-') {
            sign = -1;
            index++;
        }

        // Traverse next digits of input and stop if it is not a digit
        while (index < n && Char.IsDigit(s[index])) {
            int digit = s[index] - '0';

            // Check overflow and underflow conditions. 
            if ((result > Int32.MaxValue / 10) || 
                (result == Int32.MaxValue / 10 && digit > Int32.MaxValue % 10)) {     
                // If integer overflowed return 2^31-1, otherwise if underflowed return -2^31.    
                return sign == 1 ? Int32.MaxValue : Int32.MinValue;
            }

            // Append current digit to the result.
            result = 10 * result + digit;
            index++;
        }

        // We have formed a valid number without any overflow/underflow.
        // Return it after multiplying it with its sign.
        return sign * result; 
    }
}

//-------------------------------
// Solution 
// ------------------------------
public class Solution {
    public int MyAtoi(string s) {
        s = s.Trim();
        bool neg = false;
        long x = 0;
        for (var i = 0; i < s.Length; i++)
        {
            if (i == 0 && s[0] == '-')
            {
                neg = true;
                continue;
            }
            if (i == 0 && s[0] == '+')
            {
                continue;
            }
            if (s[i] < '0' || s[i] > '9')
            {
                break;
            }
            x = x * 10 + (s[i] - '0');
            if (x > int.MaxValue)
            {
                return neg ? int.MinValue : int.MaxValue;
            }
        }
        return neg ? -1 * (int)x : (int)x;
    }
}