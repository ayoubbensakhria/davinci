public class Solution {
    // Start from its last element, traverse backward to find the first one with    
    // index i that satisfy num[i-1] < num[i]. So, elements from num[i] to num[n-1] 
    // is reversely sorted.
    // The last step is to make the remaining higher position part as small as 
    // possible, we just have to reversely sort the num[i,n-1]


    public void NextPermutation(int[] nums) {
        int n=nums.Length;
        if(n<2)
            return;
        int index=n-1;        
        while(index>0){
            if(nums[index-1]<nums[index])
                break;
            index--;
        }
        if(index==0){
            reverseSort(nums,0,n-1);
            return;
        }
        else{
            int val=nums[index-1];
            int j=n-1;
            while(j>=index){
                if(nums[j]>val)
                    break;
                j--;
            }
            swap(nums,j,index-1);
            reverseSort(nums,index,n-1);
            return;
        }

    }
    // swap function
    public void swap(int[] num, int i, int j){
        int temp=0;
        temp=num[i];
        num[i]=num[j];
        num[j]=temp;
    }
    // using swap function to reverse
    public void reverseSort(int[] num, int start, int end){   
        if(start>end)
            return;
        for(int i=start;i<=(end+start)/2;i++)
            swap(num,i,start+end-i);
    }
}