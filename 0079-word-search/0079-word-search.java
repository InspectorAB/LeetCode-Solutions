class Solution {
    public boolean exist(char[][] board, String word) {
        
        int n = board.length;
        int m = board[0].length;
        boolean[][] visited = new boolean[n][m];
        for(int i=0; i < board.length; i++){
            for(int j=0; j < board[0].length; j++){
                if (dfs(board, word, i, j, 0, visited))
                   return true;
            }
        }
        return false;
    }
    
    boolean dfs(char[][] board, String word, int row, int col, int i, boolean[][] visited){

        if(i == word.length())
            return true;
                
        if(row < 0 || 
           col < 0 || 
           row >= board.length || 
           col >= board[0].length || 
           board[row][col] != word.charAt(i) ||
           visited[row][col] 
          )
            return false;
        
        visited[row][col] = true;
        
        boolean found = dfs(board, word, row, col + 1, i+1, visited) ||
            dfs(board, word, row, col - 1, i+1, visited) ||
            dfs(board, word, row + 1, col, i+1, visited) ||
            dfs(board, word, row - 1, col, i+1, visited);
            
        visited[row][col] = false;

        return found;     
    }
}