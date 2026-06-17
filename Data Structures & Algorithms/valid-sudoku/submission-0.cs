public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> seen = new HashSet<string>();

        for (int r = 0; r < 9; r++) {
            for (int c = 0; c < 9; c++) {
                char val = board[r][c];

                if (val == '.') {
                    continue;
                }

                int boxRow = r/3;
                int boxCol = c/3;

                if (!seen.Add($"row {r} val {val}")
                    || !seen.Add($"col {c} val {val}")
                    || !seen.Add($"box {boxRow}-{boxCol} val {val}")) {
                        return false;
                }
            }
        }
        return true;
    }
}
