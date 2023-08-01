//when the number is divisible by 3 return the word fizz

//when the number is divisible by 5 return the word buzz

//when the number is divisible by both, return the word fizzbuzz

public string fizzbuzz(int number){

    string returnString = "";

    if (number % 3 == 0){

        returnString += "fizz"
    }

    if (number % 5 == 0){

        returnString += "buzz";
    }

    return returnString;
}