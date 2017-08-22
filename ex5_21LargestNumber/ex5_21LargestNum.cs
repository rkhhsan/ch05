using System;

class ex5_21LargestNum
{
    public static void Main(string[] args)
    {
        // initialize variables in declarations
        int counter = 1; // 
        double number; //     
        double largest; // 
        double secondLargest;
        double menor;
        double soma;
        double media;

        Console.Write("{0} - Digite um número real: ",counter);
        largest = Convert.ToDouble(Console.ReadLine());
        secondLargest = soma = menor = largest;
        counter++;

        //processa mais 9 vezes
        while (counter <= 10)
        {
            // prompt user for input and obtain a value from the user
            Console.Write("{0} - Digite um número real: ", counter);
            number = Convert.ToDouble(Console.ReadLine());

            // if...else nested in while 
            if (number >= largest) // atualiza o número maior
            {
                secondLargest = largest;
                largest = number;

            }
            else if ((number > secondLargest) && (number < largest))
                secondLargest = number;
            else if (number < menor)
                menor = number;
            soma = soma + number;
            // increment counter so loop eventually terminates
            counter++;
        } // end while

        media = (double)soma / 10;

        // termination phase; prepare and display results
        Console.WriteLine("O maior número é: {0}", largest);
        Console.WriteLine("O segundo maior número é: {0}", secondLargest);
        Console.WriteLine("O menor número é: {0}", menor);
        Console.WriteLine("A soma total é: {0}", soma);
        Console.WriteLine("A media é: {0}", media);

        Console.WriteLine("Digite Enter para terminar...");
        Console.Read();
    } // end Main
}

