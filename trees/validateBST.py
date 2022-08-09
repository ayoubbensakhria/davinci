# This is an input class. Do not edit.
class BST:
    def __init__(self, value):
        self.value = value
        self.left = None
        self.right = None


def validateBstHelper(tree, minValue, maxValue):
    currentNode = tree
    if currentNode is None:
        return True
    # each node has to be between min and max
    if currentNode.value < minValue or currentNode.value >= maxValue:
        return False
        
    left = validateBstHelper(currentNode.left, minValue, currentNode.value)
    right = validateBstHelper(currentNode.right, currentNode.value, maxValue)

    return left and right

def validateBst(tree):
    # A tree is valid if a fundamental condition is met:
    # each node must have all its left children smaller and right children greater
    return validateBstHelper(tree, float("-inf"), float("inf"))
