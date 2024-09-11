using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Uppgift1
{
    internal class Media
    {
        
        public string title;
        public string filePath;
        public int duration;
        public int publicationYear;

        public Media(string inputTitle, string inputFilePath, int inputDuration, int inputPublicationYear)
        {
            title = inputTitle;
            filePath = inputFilePath;
            duration = inputDuration;
            publicationYear = inputPublicationYear; 
        }

        public int Duration
        {
            get
            {
                return duration;
            }
            set
            {
                if (value > 0)
                {
                    duration = value;
                }
            }

        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                if (value != "")
                {
                    Title = value;
                }   
            }
        }

        public string FilePath
        {
            get
            {
                return FilePath;
            }
            set
            {
                if (value != "")
                {
                    FilePath = value;
                }
            }


        }

        public int PublicationYear
        {
            get
            {
                return PublicationYear;
            }
            set
            {
                if (value > 1900)
                {
                    PublicationYear = value;
                }
            }
        }

        public virtual void Stop()
        {
            Console.WriteLine();

        }

        public virtual void Start()
        {
            Console.WriteLine();

        }

        public virtual void PrintMediaInfo()
        {
            Console.WriteLine();

        }


    }
}
