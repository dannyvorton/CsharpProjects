using System;

class ForEachIf
{
    public static void Run()
    {
        int examAssignments = 5;

        string[] studentNames = new string[] {"Stephi", "Paul", "Josh", "Moki"};

        int[] stephiGrades = new int[] {90, 92, 94, 96, 98};
        int[] paulGrades = new int[] {86, 88, 90, 92, 94};
        int[] joshGrades = new int[] {82, 84, 86, 88, 90};
        int[] mokiGrades = new int[] {78, 80, 82, 84, 86};

        int[] studentScores = new int[10];

        string currentStudentLetterGrade = "";

        Console.WriteLine("\nStudent\t\tGrade");

        foreach (string name in studentNames)
        {
            string currentStudent = name;

            if (currentStudent == "Stephi")
                studentScores = stephiGrades;
            
            else if (currentStudent == "Paul")
                studentScores = paulGrades;

            else if (currentStudent == "Josh")
                studentScores = joshGrades;

            else if (currentStudent == "Moki")
                studentScores = mokiGrades;
            
            int sumAssignmentScores = 0;
            decimal currentStudentGrade = 0;
            int gradedAssignments = 0;

            foreach (int score in studentScores)
            {
                gradedAssignments += 1;

                if (gradedAssignments <= examAssignments)
                    sumAssignmentScores += score;
                else
                    sumAssignmentScores += score / 10;
            }

            currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

            if (currentStudentGrade >= 97)
                currentStudentLetterGrade = "A+";
            else if (currentStudentGrade >= 93)
                currentStudentLetterGrade = "A";
            else if (currentStudentGrade >= 90)
                currentStudentLetterGrade = "A-";
            else if (currentStudentGrade >= 87)
                currentStudentLetterGrade = "B+";
            else if (currentStudentGrade >= 83)
                currentStudentLetterGrade = "B";
            else if (currentStudentGrade >= 80)
                currentStudentLetterGrade = "B-";
            else if (currentStudentGrade >= 77)
                currentStudentLetterGrade = "C+";
            else if (currentStudentGrade >= 73)
                currentStudentLetterGrade = "C";
            else if (currentStudentGrade >= 70)
                currentStudentLetterGrade = "C-";
            else if (currentStudentGrade >= 67)
                currentStudentLetterGrade = "D+";
            else if (currentStudentGrade >= 63)
                currentStudentLetterGrade = "D";
            else if (currentStudentGrade >= 60)
                currentStudentLetterGrade = "D-";
            else
                currentStudentLetterGrade = "F";
            
            Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
        }
    }
}
