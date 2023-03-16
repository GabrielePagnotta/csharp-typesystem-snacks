
//snack1();
snack2();
void snack1()
{
    /*
     * Snack 1
     * L’utente inserisce due numeri in successione. Il software stampa il maggiore. 
     */

    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());
    

    if(num1 > num2){
        Console.WriteLine(num1);
    }
    else if(num2 > num1) { 
        Console.WriteLine(num2);
    }
    else
    {
        Console.WriteLine("sono uguali");
    }
    
    
}
void snack2()
{
    // l' utente inserisce due parola in successione, verra mostrata prima la parola piu corta e poi quella più lungha.

    string word1 = Console.ReadLine();
    string word2 = Console.ReadLine();

    if(word1.Length > word2.Length)
    {
        Console.WriteLine(word2);
        Console.WriteLine(word1);
    }
    else 
    {
        Console.WriteLine(word1);
        Console.WriteLine(word2);
    }
}

