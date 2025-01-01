using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp7.ExceptionHandling
{
    internal class FReader
    {

        public void ReadFile(string filePath)
        {
            StreamReader fileReader = null;

            try
            {
                Console.WriteLine($"Attempting to read file: {filePath}");

                // Open the file
                fileReader = new StreamReader(filePath);

                // Read and display the file content
                string content = fileReader.ReadToEnd();
                Console.WriteLine("File Content:");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: The file was not found.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error: An I/O error occurred. Details: {ex.Message}");
            }
            finally
            {
                // Ensure the file stream is properly closed
                if (fileReader != null)
                {
                    fileReader.Close();
                    Console.WriteLine("File stream has been closed.");
                }
            }
        }
    }
}
