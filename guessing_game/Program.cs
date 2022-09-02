Random secretNumber = new Random();
int number = secretNumber.Next(1,10);
int initialNum = 0;
int num_guess = 0;
var listOfGusses = new List<int>();
listOfGusses.Add(0);

while((number != initialNum) && (num_guess <=3))
    {
        Console.Write("Enter your guess: ");
        var guess = int.Parse(Console.ReadLine());

    if(listOfGusses.Last() == guess)
    {
        Console.WriteLine("You entered the same wrong number");
        num_guess += 0;
    }

    if(listOfGusses.Last() != guess){
        num_guess += 1;
        if(guess > number && num_guess <3){
            listOfGusses.Add(guess);
            Console.WriteLine($"Lower, you have {4-num_guess} attempts left");
        }
        if(guess < number && num_guess <3){
            listOfGusses.Add(guess);
            Console.WriteLine($"Higher, you have {4-num_guess} attempts left");
        }
            if(guess > number && num_guess == 3){
                listOfGusses.Add(guess);
                Console.WriteLine("Lower, your last attempt");
        }
            if(guess != number && num_guess == 3){
                listOfGusses.Add(guess);
                Console.WriteLine("Higher, your last attempt");
        }
        if(guess != number && num_guess == 4){
            Console.WriteLine("Game over, you have no attempts left");
        }
        else if(guess == number){Console.WriteLine("you are right");
        break;}
    }
}
