using System;

namespace FeeReceipt
{
    class Student
    {
        public string Name { get; set; }
        public string StudentID { get; set; }
        public string Course { get; set; }
        public double TuitionFee { get; set; }
        public double LibraryFee { get; set; }
        public double LabFee { get; set; }
        public double HostelFee { get; set; }
        
        // Calculate total fee
        public double TotalFee()
        {
            return TuitionFee + LibraryFee + LabFee + HostelFee;
        }

        // Method to display the fee receipt
        public void DisplayReceipt()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("   SANJIVANI COLLEGE OF ENGINEERING   ");
            Console.WriteLine("___________________________________________");
            Console.WriteLine("===========================================");
            Console.WriteLine("          Academic Fee Receipt        ");
            Console.WriteLine("===========================================");
            Console.WriteLine("                          Date: " + DateTime.Now.ToString("dd/MM/yyyy"));
            Console.WriteLine("                          Time: " + DateTime.Now.ToString("HH:mm:ss"));
            Console.WriteLine("  Student Name:               "+Name);
            Console.WriteLine("  Student ID:                 "+StudentID);
            Console.WriteLine("  Course:                     "+Course);
            Console.WriteLine("  Year:                       "+ DateTime.Now.ToString("yyyy"));
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("  Tuition Fee:                "+TuitionFee);
            Console.WriteLine("  Library Fee:                "+LibraryFee);
            Console.WriteLine("  Lab Fee:                    "+LabFee);
            Console.WriteLine("  Hostel Fee:                 "+HostelFee);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("   Total Fee:                Rs"+TotalFee());
            Console.WriteLine("=============================================");
        }
    }

    class Receipt
    {
        static void Main(string[] args)
        {
            // Create a student object
            Student student = new Student
            {
                Name = "Bhoomi",
                StudentID = "S123456",
                Course = "Computer Science",
                TuitionFee = 5000.00,
                LibraryFee = 150.00,
                LabFee = 200.00,
                HostelFee = 100.00
            };

            // Display the fee receipt
            student.DisplayReceipt();

        }
    }
}
