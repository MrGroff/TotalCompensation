using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalCompensation
{
    public class Program
    {
        private static string GetJsonFilePath()
        {
            //This should work if put in bin folder
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string jsonFilePath = Path.Combine(baseDirectory, "PunchLogicTest.jsonc");
            return jsonFilePath;
        }

        public static void Main()
        {
            try
            {
                string filePath = GetJsonFilePath();
                var jsonDataService = new JsonDataService(filePath);
                JsonData jsonData = jsonDataService.LoadJsonData();

                var employeeProcessor = new EmployeeProcessor(jsonData);
                employeeProcessor.PrintEmployeeReports();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
