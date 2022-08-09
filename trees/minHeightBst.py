def minHeightBstHelper(array, start, end):
    if end < start:
        return 
    middle = (start + end)//2
    # start from the middle
    # insert middle left then middle right and so on
    bst = BST(array[middle])
    bst.left = minHeightBstHelper(array, start, middle-1)
    bst.right = minHeightBstHelper(array, middle+1, end)
    return bst
    
def minHeightBst(array):
    return minHeightBstHelper(array, 0, len(array)-1)
    
        
        
    
class BST:
    def __init__(self, value):
        self.value = value
        self.left = None
        self.right = None

    def insert(self, value):
        if value < self.value:
            if self.left is None:
                self.left = BST(value)
            else:
                self.left.insert(value)
        else:
            if self.right is None:
                self.right = BST(value)
            else:
                self.right.insert(value)
