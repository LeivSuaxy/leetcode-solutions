// Rotate Image

func rotate(matrix [][]int) {
	l := len(matrix)

	for i := range l {
		for j := i + 1; j < l; j++ {
			matrix[i][j], matrix[j][i] = matrix[j][i], matrix[i][j]
		}
	}

	middle := l / 2

	for i := range l {
		for j := range middle {
			matrix[i][j], matrix[i][l-1-j] = matrix[i][l-1-j], matrix[i][j]
		}
	}

	for i := range l {
		for j := range l {
			fmt.Print(matrix[i][j])
		}
		fmt.Println("")
	}
}
