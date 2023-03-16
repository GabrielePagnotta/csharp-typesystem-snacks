
//snack1();
//snack2();
//snack3();
snack4();
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

void snack3(){

    //il software chiede 10 volte all'utente di inserire un numero, il programma stampa la somma di tutti i numeri inseriti.
    int sum = 0;
    for(int i = 0; i < 10; i++) { 

        var InputNumber = Convert.ToInt32(Console.ReadLine());
        sum += InputNumber;

    }
    Console.WriteLine($"la somma totale dei numeri inseriti è {sum}");
}
void snack4()
{
    //calcola la somma e la media dei numeri da 2 a 10

    int num = 2;
    
    

    for(int i = 2; i < 10 ; i++)
    {
      num++;
      num += i;
        
        


    }
    int sum = num / 8;
    Console.WriteLine(sum);
    
}

