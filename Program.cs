// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

class BingoBoard{
    private string[,] Board;

    BingoBoard(string[,] board){
        Board = board;
    }

    public bool checkIfFinished(){
        Console.WriteLine("checkIfFinished -> NOT IMPLEMENTED");
        return false;
    }
}