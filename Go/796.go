// Rotate String

import (
	"fmt"
	"strings"
)

func rotateString(s string, goal string) bool {
	slen := len(s)
	gallen := len(goal)

	if slen != gallen {
		return false
	}

	for i := 0; i <= slen; i++ {
		if strings.Compare(s, goal) == 0 {
			return true
		}
		sliceString(&s)
	}

	return false
}

func sliceString(s *string) {
	runes := []rune(*s)

	if len(runes) > 0 {
		result := string(append(runes[1:], runes[0]))
		*s = result
	}
}
