def Task3(matrix):
    n = len(matrix) # Dynamic initialize Matrix Size 
    allZero = False

    for i in range(n):
        allZero = True
        for j in range(n):
            if matrix[i][j] != 0:
                allZero = False
                break # exit second loop
        
        if allZero:
            print("First all zero is: ", i)
            break

    if not allZero:
        print("No all zero rows.")


#EX: matrix
x = [
    [0,1,0], # Row 0
    [1,0,1], # Row 1
    [0,0,0]  # Row 2
]

Task3(x) # Runs the function and returns either i = 0, 1, or 2 based off the rows of the matrix from top to bottom. Will print the row index correlating to 
         # which row has all zero and is checked first. 