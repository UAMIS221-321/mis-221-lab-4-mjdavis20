// start main
int choice = GetChoice();
int rows = GetRows();

IsValid(choice);


// end main

static int GetChoice(){
    System.Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit");
    int choice = int.Parse(Console.ReadLine());
    return choice;
}

static void IsValid(int choice){
    while(choice != 3){
        int rows = GetRows();
        if(choice == 1){
            string fullTriangle = GetFull(rows);
            System.Console.WriteLine(fullTriangle);
        }
        else if (choice == 2){
            string partialTriangle = GetPartial(rows);
            System.Console.WriteLine(partialTriangle);
        }
        else if (choice == 3){
        }
        else{
            System.Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
            choice = GetChoice();
            continue;
        }
        choice = GetChoice();
    }
}

static int GetRows(){
    Random rnd = new Random();
    int rows = rnd.Next(3, 10);
    return rows;
}

static string GetFull(int rows){
    string final = "";
    for(int i = 1; i <= rows; i++){
        for(int j = 1; j <= i; j++){
            final += "O ";
        }
        final += "\n";
    }
    return final;
}

static string GetPartial(int rows){
    string final = "";
    for(int i = 1; i <= rows; i++){
        for(int j = 1; j <= i; j++){
            if( j == 1 || j == i || i == rows){
                final += "O "; // makes it so it always places one on top
            }
            else{
                Random rnd = new Random();
                int num = rnd.Next(2);
                if (num == 0){
                    final += " ";
                }
                else{
                    final += "O ";
                }
            }
        }
        final += "\n";
    }
    return final;
}
