using System.Text;

namespace MVC{
    static class DataBase{

        public static string GetAnser(string order, string nameData){
            // create an object (reader)   
            using (StreamReader sr = new(nameData, Encoding.Default)){
                string str = null;
                while (true){
                    ///if empty, that's the end 
                    str = sr.ReadLine();
                    if (str != null){
                        //if the line is read     
                        //equal to the search string  
                        if (str == order) return "is available.";
                    }
                    return "not available.";
                }
            }
        }

        public static void GetData(string nameData){
            string line;
            try{
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(nameData);
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null){
                    //write the line to console window
                    Console.WriteLine(" - " + line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e){
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}