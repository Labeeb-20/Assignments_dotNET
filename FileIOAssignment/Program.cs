namespace FileIOAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WriteInFile();
            ReadFromFile();
        }
        static void WriteInFile()
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream("Products.txt", FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                Console.WriteLine("Enter the data to the file: ");
                int i = 1;
                string str;
                while (i != 0)
                {
                    str = Console.ReadLine();
                    sw.WriteLine(str);
                    Console.WriteLine("Do you wish to continue? 1(yes)/0(no)");
                    i = int.Parse(Console.ReadLine());
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fs.Close();
               
            }
        }

        static void ReadFromFile()
        {
            FileStream fsr = null;
            StreamReader sr = null;
            FileStream fsw = null;
            StreamWriter sw = null;
            try
            {
                fsr = new FileStream("Products.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fsr);
                fsw = new FileStream("Updated_Products.txt", FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fsw);
                Console.WriteLine("Read the file: ");
                string str = sr.ReadLine();
                string[] strarr;
                while (!String.IsNullOrEmpty(str))
                {
                    Console.WriteLine(str);
                    strarr = str.Split(",");
                    double price = double.Parse(strarr[2]);
                    if (price < 1000)
                    {
                        strarr[2] = Convert.ToString(price + (price * 0.1));
                        
                    }

                    else if (price > 1000 && price < 5000)
                    {
                        strarr[2] = Convert.ToString(price + (price * 0.05));
                    }
                    
                    var str1 = String.Join(",", strarr);
                    sw.WriteLine(str1);
                    str = sr.ReadLine();

                }
                sw.Close();
                sr.Close();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fsr.Close();
                fsw.Close();

            }
        }
    }
}

