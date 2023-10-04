using System;
namespace Test{
    class GPAcalculator{
        static void Main(string[] args){
            decimal totalGradePoints=0;
            Console.Write("Enter your name: ");
            String name=Console.ReadLine();
            Console.Write("Enter grade of subject1: ");
            String grade1Input=Console.ReadLine();
            decimal grade1 = Convert.ToDecimal(grade1Input);
            Console.Write("Enter grade of subject2: ");
            String grade2Input=Console.ReadLine();
            decimal grade2 = Convert.ToDecimal(grade2Input);
            Console.Write("Enter grade of subject3: ");
            String grade3Input=Console.ReadLine();
            decimal grade3 = Convert.ToDecimal(grade3Input);
            Console.Write("Enter grade of subject4: ");
            String grade4Input=Console.ReadLine();
            decimal grade4 = Convert.ToDecimal(grade4Input);
            Console.Write("Enter grade of subject5: ");
            String grade5Input=Console.ReadLine();
            decimal grade5 = Convert.ToDecimal(grade5Input);
            Console.WriteLine("----------------------------------");
            Console.Write("Enter credit of subject1: ");
            String credit1Input=Console.ReadLine();
            decimal credit1 = Convert.ToDecimal(credit1Input);
            Console.Write("Enter credit of subject2: ");
            String credit2Input=Console.ReadLine();
            decimal credit2 = Convert.ToDecimal(credit2Input);
            Console.Write("Enter credit of subject3: ");
            String credit3Input=Console.ReadLine();
            decimal credit3 = Convert.ToDecimal(credit3Input);
            Console.Write("Enter credit of subject4: ");
            String credit4Input=Console.ReadLine();
            decimal credit4 = Convert.ToDecimal(credit4Input);
            Console.Write("Enter credit of subject5: ");
            String credit5Input=Console.ReadLine();
            decimal credit5 = Convert.ToDecimal(credit5Input);

            decimal totalCreditHours = credit1+credit2+credit3+credit4+credit5;

            totalGradePoints += credit1 * grade1;
            totalGradePoints += credit2 * grade2;
            totalGradePoints += credit3 * grade3;
            totalGradePoints += credit4 * grade4;
            totalGradePoints += credit5 * grade5;
            decimal gradePointAvg = totalGradePoints/totalCreditHours;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Name: "+name);
            Console.WriteLine("SUBJECT\t\t\tGRADE\t\t\tCREDIT\t\t\tGRADE POINTS\n");
            Console.WriteLine("Subject 1\t\t\t"+grade1+"\t\t\t"+credit1+"\t\t\t"+(grade1*credit1));
            Console.WriteLine("Subject 2\t\t\t"+grade2+"\t\t\t"+credit2+"\t\t\t"+(grade2*credit2));
            Console.WriteLine("Subject 3\t\t\t"+grade3+"\t\t\t"+credit3+"\t\t\t"+(grade3*credit3));
            Console.WriteLine("Subject 4\t\t\t"+grade4+"\t\t\t"+credit4+"\t\t\t"+(grade4*credit4));
            Console.WriteLine("Subject 5\t\t\t"+grade5+"\t\t\t"+credit5+"\t\t\t"+(grade5*credit5));
            Console.WriteLine();
            Console.WriteLine(gradePointAvg);
        }
    }
}