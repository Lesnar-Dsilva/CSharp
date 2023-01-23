using System.Data;

class Program {
    static void Main(string[] args) {
        //DATA TABLE SOLUTION

        Console.Write("Enter the expression you would like evaluated (use brackets to seperate calculation to follow BIDMAS)\n>");
        String u = Console.ReadLine();
        DataTable d = new DataTable();
        var x = d.Compute(u,"");
        Console.WriteLine(x);

        //03-07-2022
    }
}