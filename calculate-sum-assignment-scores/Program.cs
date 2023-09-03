// functions to get summation of scores, average of scores, and letter grade
Func<int, int, int, int, int, int> calcSum = (a, b, c, d, e) => a + b + c + d + e;
Func<decimal, int, decimal> averageScore = (a, b) => a / b;
Func<decimal, string> getLetterGrade = finalScore => 
{
    switch (finalScore)
        {
            case decimal n when n >= 97:
                return "A+";
            case decimal n when n <= 96 && n >= 93:
                return "A";
            case decimal n when n <= 92 && n >= 90:
                return "A-";
            case decimal n when n <= 89 && n >= 87:
                return "B+";
            case decimal n when n <= 86 && n >= 83:
                return "B";
            default:
                return "No score";
        };
};

// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

// set decimals for average scores
decimal sophiaScore;
decimal nicolasScore;
decimal zahirahScore;
decimal jeongScore;

// initial variables for students set to sum using calcSum() function
decimal sophiaSum = calcSum(sophia1, sophia2, sophia3, sophia4, sophia5);
decimal nicolasSum = calcSum(nicolas1, nicolas2, nicolas3, nicolas4, nicolas5);
decimal zahirahSum = calcSum(zahirah1, zahirah2, zahirah3, zahirah4, zahirah5);
decimal jeongSum = calcSum(jeong1, jeong2, jeong3, jeong4, jeong5);

// calculate average scores using the averageScore() function
sophiaScore = averageScore(sophiaSum, currentAssignments);
nicolasScore = averageScore(nicolasSum, currentAssignments);
zahirahScore = averageScore(zahirahSum, currentAssignments);
jeongScore = averageScore(jeongSum, currentAssignments);

// display the student name and the value of summed assignment scores
// commented out, as not needed in the final showing
// Console.WriteLine("Sophia: " + sophiaSum);
// Console.WriteLine("Nicolas: " + nicolasSum);
// Console.WriteLine("Zahirah: " + zahirahSum);
// Console.WriteLine("Jeong: " + jeongSum);

// write out the average scores
Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine($"Sophia: \t{sophiaScore} \t{getLetterGrade(sophiaScore)}");
Console.WriteLine($"Nicolas: \t{nicolasScore} \t{getLetterGrade(nicolasScore)}");
Console.WriteLine($"Zahirah: \t{zahirahScore} \t{getLetterGrade(zahirahScore)}");
Console.WriteLine($"Jeong: \t\t{jeongScore} \t{getLetterGrade(jeongScore)}");