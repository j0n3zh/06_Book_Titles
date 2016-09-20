using System;

namespace _06_Book_Titles
{
    internal class Book
    {
        private string title;
        public string Title { get { return title;} internal set { title = upper(value); } }

        private string upper(string value)
        {
            if (value.Length > 1)
            {
                string[] Array = value.Split(' ');
                string returnString = "";
                int firstRun = 0;
                foreach (string i in Array)
                {
                    if (firstRun == 0) returnString = returnString + i[0].ToString().ToUpper() + i.Substring(1, i.Length - 1) + " " ;
                    else if (i == "the" || i == "over" || i == "and" || i == "of" || i == "in" || i == "an" || i == "a")
                        {
                            returnString = returnString + i + " ";
                        }
                    else returnString = returnString + i[0].ToString().ToUpper() + i.Substring(1, i.Length - 1) + " ";
                    firstRun = 1;
                }
                value = returnString.Substring(0, returnString.Length - 1);
            }
            return value;
        }
    }
}