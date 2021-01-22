using ListToDataTableConverter.Model;
using ListToDataTableConverter.Worker;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListToDataTableConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StudentInformationModel> studentInformationModels = new List<StudentInformationModel>();

            var studentModel1 = new StudentInformationModel() { StudentId = 1, StudentName = "Bob", StudentAge = 22, StudentGender = "Man" };
            var studentModel2 = new StudentInformationModel() { StudentId = 2, StudentName = "Poo", StudentAge = 23, StudentGender = "Man" };
            var studentModel3 = new StudentInformationModel() { StudentId = 3, StudentName = "Loo", StudentAge = 21, StudentGender = "Women" };
            var studentModel4 = new StudentInformationModel() { StudentId = 4, StudentName = "Noo", StudentAge = 25, StudentGender = "Women" };
            var studentModel5 = new StudentInformationModel() { StudentId = 5, StudentName = "Roo", StudentAge = 29, StudentGender = "Man" };

            studentInformationModels.Add(studentModel1);
            studentInformationModels.Add(studentModel2);
            studentInformationModels.Add(studentModel3);
            studentInformationModels.Add(studentModel4);
            studentInformationModels.Add(studentModel5);

            DataTable dataTable = FormatChanger.ConvertToDataTable(studentInformationModels);

            Launcher.PrintDataTable(dataTable);
        }
    }
}
