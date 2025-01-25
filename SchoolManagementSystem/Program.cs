/*
 * Name: Kaci
 * South Hills Username: kcraycraft45
 * 
 */

namespace SchoolManagementSystem
{
    public class Program
    {
        public static void Main()
        {
            /* HUMAN */
            Student Kaci = new Student(45, "Second Year", ["Advanced JavaScript", "Cloud & DevOps", "Job Search Skills", "Project MGMT", "Software Engineering"], "Kaci", "Craycraft", 28, 'f');
            Student Rachel = new Student(61, "Second Year", ["Advanced JavaScript", "Cloud & DevOps", "Job Search Skills", "Project MGMT", "Software Engineering"], "Rachel", "Henninger", 28, 'f');
            Student Logan = new Student(81, "Second Year", ["Advanced JavaScript", "Cloud & DevOps", "Job Search Skills", "Project MGMT", "Software Engineering"], "Logan", "Brooks", 21, 'f');
            Student Ian = new Student(611, "Second Year", ["Advanced JavaScript", "Cloud & DevOps", "Job Search Skills", "Project MGMT", "Software Engineering"], "Ian", "Paulhamus", 20, 'm');
            Student Michael = new Student(01, "Second Year", ["Advanced JavaScript", "Cloud & DevOps", "Job Search Skills", "Project MGMT", "Software Engineering"], "Michaela", "Saleese", 28, 'f');

            /* FELINE */
            Student Hannah = new Student(82, "Shark Year", ["Getting Wiggles Out", "Managing Fluff", "Being Spooky", "Disco Time", "Destruction 101", "Gremlin-ing after Midnight", "Managing Hate and Codependence"], "Hannah", "Banana", 4, 'g'); // g for gremlin
            Student Robyn = new Student(33, "Cat BS", ["Destruction 101", "Managing Fluff", "Fundamentals of Giving Bananas Away", "Loafing", "Catware Engineering", "Yakking on Everything"], "Roby", "Boby", 5, 'f');
            Student Kali = new Student(99, "Post-Graduate Degree", ["Mastering the Snuggle", "Managing Fluff", "Being Spooky", "Destruction 101", "Loafing", "Advanced Biscuit Design", "Emotional Supporting Depressed Humans 601", "Managing Hate and Codependence", "Screaming into the Void & Projecting your Voice"], "Kali", "Linux", 7, 'f');
            Student Bunny = new Student(11, "Cat BS", ["Managing Fluff", "Managing Hate and Codependence", "Loafing", "Destruction 101"], "Bartley", "Jr.", 100, 'f');
            Student Ella = new Student(84, "Shark Year", ["Destruction 101", "How Bedsheets Work", "Being Spooky", "Catware Engineering", "Managing Fluff"],"Ella", "Bella", 2, 'f');

            /* TEACHER */
            Faculty Nicholas = new Faculty(00, ["Advanced JavaScript", "SQL", "Software Engineering", "Intermediate Programming", "Mastering Innate Magic", "The Answers to Every Question"], "Nicholas", "Page", 28, 'm');
            Faculty Stephen = new Faculty(89, ["Coping with Teaching Cats", "DevOps", "Managing Metrosexuality", "Managing Fluff", "Destruction 101"], "Stephen", "Weaver", 35, 'm');

            /* CLASSES */
            Class AJ = new Class("Advanced JavaScript", [Kaci, Rachel, Logan, Ian, Michael], Nicholas);
            Class Floof = new Class("Managing Fluff", [Hannah, Robyn, Kali, Bunny, Ella], Stephen);
            Class DemolitionDerby = new Class("Destruction 101", [Hannah, Robyn, Kali, Bunny, Ella], Stephen);


            Stephen.Teaches();
            Floof.Meets();
            Kaci.PrintStudentAndGrade();
        }
    }
}
