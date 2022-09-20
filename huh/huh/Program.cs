int score = 0;
string answer = "null";
Console.WriteLine("Welcome to this quiz. \n Lets kick it off with Question 1, what is 'int = 10 % 8' \n a: 2 \n b: 1 \n c: 18 ");
answer = Console.ReadLine();
if(answer == "a"){
    Console.WriteLine("Correct! +1 points");
    score += 1;
}
else {
    System.Console.WriteLine("incorrect answer");
}
Console.WriteLine($"your score is now: {score}");
Console.ReadLine();

Console.WriteLine("Question 2, why can you not type a number over 2147483647 with the 'int' command  \n a: because c# cannot handle numbers over 9 digits \n b: because 'int' is limited to 32 bit numbers \n c: because it is a uneven number ");
answer = Console.ReadLine();
if(answer == "b"){
    Console.WriteLine("Correct! +1 points");
    score += 1;
}
else {
    Console.WriteLine("incorrect answer");
}
Console.WriteLine($"your score is now: {score}");
Console.ReadLine();

Console.WriteLine("Question 3, what does the shortcut 'cr' do? \n a: it writes 'Console.Readline();' \n b: nothing \n c: it stores numbers");
answer = Console.ReadLine();
if(answer == "a"){
    Console.WriteLine("Correct! +1 points");
    score += 1;
}
else{
    Console.WriteLine("Incorrect answer");
}
if(score == 3){
    Console.WriteLine($"your final score is {score}, well done. \nthanks for playing.");
}
else if(score == 2){
    Console.WriteLine($"your final score is {score}, close but could be better. better get back to practice. \nthanks for playing");
}
else{
    Console.WriteLine($"your final score is {score}, you seem to need to practice at this. better get to it.");
}

Console.ReadLine();
