// See https://aka.ms/new-console-template for more information

int score1;
int score2;
int score3;

Console.WriteLine("** Student Grade Calculator **");

Console.WriteLine("Enter students name:");
String sName = Console.ReadLine();


Console.WriteLine("Enter score 1 (out of 100):");
int.TryParse(Console.ReadLine(), out score1);


Console.WriteLine("Enter score 2 (out of 100):");
int.TryParse(Console.ReadLine(), out score2);


Console.WriteLine("Enter score 3 (out of 100):");
int.TryParse(Console.ReadLine(), out score3);



String[] FixedNames = sName.Split(" ");

FixedNames[0] = char.ToUpper(FixedNames[0][0]) + FixedNames[0].Substring(1);
FixedNames[1] = char.ToUpper(FixedNames[1][0]) + FixedNames[1].Substring(1);


Console.WriteLine(FixedNames[0] + " " +  FixedNames[1]);

Console.WriteLine("**Grade Report **");
Console.WriteLine("Student Name: " + FixedNames[0] + " " + FixedNames[1]);
Console.WriteLine("Scores: " + score1 +"%" +  ", " + score2 + "%" + ", " + score3 + "%");

double Average;
Average = (double)(score1 + score2 + score3) / 3;

Console.WriteLine("Average: " + Average.ToString("f2") + "%");

String Grade;

switch (Average)
{
    case > 90:
        Grade = "A";
        break;
    case > 80:
        Grade = "B";
        break;
    case > 70:
        Grade = "C";
        break;
    case > 60:
        Grade = "D";
        break;
    default:
        Grade = "F";
       break;
}


Console.WriteLine("Final Grade: " + Grade);