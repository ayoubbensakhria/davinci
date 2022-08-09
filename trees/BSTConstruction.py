# Do not edit the class below except for
# the insert, contains, and remove methods.
# Feel free to add new properties and methods
# to the class.
class BST:
    def __init__(self, value):
        self.value = value
        self.left = None
        self.right = None

    def insert(self, value):
        currentNode = self
        # move to the appropriate node
        while currentNode is not None:
            if currentNode.value > value:
                if currentNode.left:
                    currentNode = currentNode.left
                else:
                    currentNode.left = BST(value)
                    break
            elif currentNode.value <= value:
                if currentNode.right:
                    currentNode = currentNode.right
                else:
                    currentNode.right = BST(value)
                    break
                 
        # Do not edit the return statement of this method.
        return self

    
    def contains(self, value):
        currentNode = self

        while currentNode is not None:
            if currentNode.value == value:
                return True
            if currentNode.value > value:
                currentNode = currentNode.left
            else:
                currentNode = currentNode.right           
        return False


    def findsmallestOnRight(self):
        currentNode = self.right    
        while currentNode.left:
            currentNode = currentNode.left        
        return currentNode
                
    def remove(self, value):
        # if right and left grab the smallest value on the right
        # delete the node with that value to keep the tree valid
        # fundamental property of BT: all nodes' values at the left <=n<=right
        currentNode = self

        if value < currentNode.value:
            self.left = self.left.remove(value)  # remove on the left

        elif value > currentNode.value:
            self.right = self.right.remove(value)  # remove on the right

        else: # currentNode.value == value: 
            # if only left child exists move it
            # if only right child exists and less than value move it
            if not currentNode:
                return None
            elif currentNode.left is None and currentNode.right is None:
                return None

            # Easy cases
            # 1. Only right node or None
            elif not currentNode.left:
                newNode = currentNode.right
                currentNode.value = newNode.value
                currentNode.left = newNode.left
                currentNode.right = newNode.right
                return currentNode
            # 2. Only left node or None     
            elif not currentNode.right:
                newNode = currentNode.left  
                currentNode.value = newNode.value            
                currentNode.left = newNode.left
                currentNode.right = newNode.right 
                return currentNode
            # if there are Left and Right Nodes
                # 1. find smallest value on right (because it has to be > left when becoming root)
                # 2. remplace currentNode value with the smallest value
                # 3. remove that value on the right using recursion (two cases above)
                # when two LR nodes are present                  
            else:
                replacementNode = currentNode.findsmallestOnRight()
                currentNode.value = replacementNode.value
                # will execute a simple LEAF with No children node case
                currentNode.right = currentNode.right.remove(replacementNode.value)
               
        # Do not edit the return statement of this method.
        return self