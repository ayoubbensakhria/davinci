def sortedSquaredArray(array):
    # Write your code here.
    sortedSquares = [0]*len(array)

    for i in range (len(array)):
        value = array[i]
        sortedSquares[i] = value * value
    sortedSquares.sort()
    return sortedSquares
