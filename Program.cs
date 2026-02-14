//*****************************************************************************
//** 74. Search a 2D Matrix                                         leetcode **
//*****************************************************************************
//** We treat the grid as one long, sorted sea,
//** Binary search sails through it carefully;
//** With mid divided, row and column found,
//** In log-time depth the hidden truth is crowned.
//*****************************************************************************

bool searchMatrix(int** matrix, int matrixSize, int* matrixColSize, int target) {
    if (matrixSize == 0 || matrixColSize[0] == 0)
    {
        return false;
    }

    int m = matrixSize;
    int n = matrixColSize[0];

    int low = 0;
    int high = (m * n) - 1;

    while (low <= high)
    {
        int mid = low + (high - low) / 2;
        int midElement = matrix[mid / n][mid % n];

        if (midElement == target)
        {
            return true;
        }
        else if (midElement > target)
        {
            high = mid - 1;
        }
        else
        {
            low = mid + 1;
        }
    }

    return false;
}
