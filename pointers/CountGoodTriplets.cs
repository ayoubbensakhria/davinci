public class Solution {
    	
    public int CountGoodTriplets(int[] arr, int a, int b, int c) {
        // find (arr[i], arr[j], arr[k]) triplets such that
        // |arr[i] - arr[j]| <= a
        // |arr[j] - arr[k]| <= b 
        // |arr[i] - arr[k]| <= c
        int counter = 0;
        // brute force (O(N^3))        
        for (int i=0; i< arr.Length; i++){
            for (int j=i; j< arr.Length; j++){                
                if (j==i) continue;                
                for (int k=j; k<arr.Length; k++){
                    if(k==j || k==i) continue;
                    if(Math.Abs(arr[i]-arr[j]) <= a 
                        && Math.Abs(arr[j]-arr[k]) <= b
                        && Math.Abs(arr[i]-arr[k]) <= c){
                            counter++;
                        
                    }
                }
            }
        }
    return counter;
    }
}