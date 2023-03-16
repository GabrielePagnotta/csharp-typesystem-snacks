
//snack1();
//snack2();
//snack3();
//snack4();
//snack5();
//snack6();
//snack7();
//snack8();
snack9();


void snack1()
{
    /*
     * Snack 1
     * L’utente inserisce due numeri in successione. Il software stampa il maggiore. 
     */

    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());


    if (num1 > num2)
    {
        Console.WriteLine(num1);
    }
    else if (num2 > num1)
    {
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

    if (word1.Length > word2.Length)
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

void snack3()
{

    //il software chiede 10 volte all'utente di inserire un numero, il programma stampa la somma di tutti i numeri inseriti.
    int sum = 0;
    for (int i = 0; i < 10; i++)
    {

        var InputNumber = Convert.ToInt32(Console.ReadLine());
        sum += InputNumber;

    }
    Console.WriteLine($"la somma totale dei numeri inseriti è {sum}");
}
void snack4()
{
    //calcola la somma e la media dei numeri da 2 a 10

    int num = 2;



    for (int i = 2; i < 10; i++)
    {
        num++;
        num += i;




    }
    int sum = num / 8;
    Console.WriteLine(sum);

}
void snack5()
{
    //il software chiede all'utente di inserire un numero, si il numero inserito è pari stampa il numerom, se è dispari stampa il numero successivo.
    string AskingUser = "Ciao Paolo inserisci un numero";
    Console.WriteLine(AskingUser);
    int UserInput = Convert.ToInt32(Console.ReadLine());

    if (UserInput % 2 == 0)
    {
        Console.WriteLine(UserInput);
    }
    else if (UserInput % 2 != 0)
    {
        Console.WriteLine(UserInput + 1);
    }
}
void snack6()
{

    string[] InvitatiGatsby =
    {
        "Gennaro","Luca","Gabriele","yuri"
    };

    for (int i = 0; i <= InvitatiGatsby.Length; i++)
    {

        Console.WriteLine("inserisci il tuo nome:");
        string Request = Console.ReadLine();

        if (InvitatiGatsby.Contains(Request))
        {
            Console.WriteLine("sei invitato");
            break;
        }
        else
        {
            Console.WriteLine("Mi dispiace, non sei invitato");
            continue;
        }

    }


}
void snack7()
{
    int[] array = new int[6];
    

    for (int i = 0; i < 6; i++)
    {
        Console.WriteLine("inserisci un numero");
        var Input = Convert.ToInt32(Console.ReadLine());


        if (Input % 2 != 0)
        {
            array[i] = Input;
            
        }
        else
        {
            Console.WriteLine("devi inserire un numero dispari");
            
        }
    }
    for (int x = 0; x < array.Length; x++)
    {
       var totalView = array[x];
        Console.WriteLine(totalView);
    }
} 
void snack8()
{
    int[] ArrNum =
    {
        1,4,8,3,5,10
    };

    for(int i = 0; i < ArrNum.Length; i+=2)
    { 
          Console.WriteLine(ArrNum[i]);
       
    }
}void snack9()
{
    double[] Numbers = new double[50];
    int Cicle = 0;

    while (Cicle < 50)
    {
        Console.WriteLine("inserisci un numero");
        var Input = Convert.ToDouble(Console.ReadLine());
        Numbers[Cicle] = Input;
        Cicle++;


    }

    for(int i = 0; i < Numbers.Length; i++)
    {
        Console.WriteLine(Numbers[i]);
    }
}


    
