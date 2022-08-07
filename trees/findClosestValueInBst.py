# BST property: tree.right>tree.value>tree.left
import sys
def findClosestValueInBst(tree, target):
    # Write your code here.
    return findClosestValueInBstHelper(tree, target, sys.maxsize)

def findClosestValueInBstHelper(tree, target, closest):
    # base case
    if tree is None:
        return closest
    if abs(target-closest) > abs(target-tree.value):
        closest = tree.value

    # choose where to get based on current value
    # eliminate half of the tree
    if target > tree.value:
        return findClosestValueInBstHelper(tree.right, target, closest)
    if target < tree.value:
        return findClosestValueInBstHelper(tree.left, target, closest)

    return closest

    
# This is the class of the input tree. Do not edit.
class BST:
    def __init__(self, value):
        self.value = value
        self.left = None
        self.right = None
