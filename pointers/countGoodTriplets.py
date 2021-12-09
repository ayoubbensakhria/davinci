class Solution:
    def countGoodTriplets(self, arr: List[int], a: int, b: int, c: int) -> int:
        # find (arr[i], arr[j], arr[k]) triplets such that
        # |arr[i] - arr[j]| <= a
        # |arr[j] - arr[k]| <= b 
        # |arr[i] - arr[k]| <= c
        counter = 0
        for i in range (len(arr)):
            for j in range (i, len(arr)):
                if(i==j):
                    continue
                for k in range (j, len(arr)):
                    if(k==j or k==i):
                        continue
                    if(abs(arr[i]-arr[j]) <= a 
                        and abs(arr[j]-arr[k]) <= b
                        and abs(arr[i]-arr[k]) <= c):
                        counter +=1
        return counter