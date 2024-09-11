using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Uppgift1
{
    internal class Podcast : Media
    {
        private string Creator;

        public Podcast(string InputCreator , string inputTitle, string inputFilePath, int inputDuration, int inputPublicationYear) : base(inputTitle, inputFilePath, inputDuration, inputPublicationYear)
        {
            Creator = InputCreator;
        }

        public override void Stop()
        {
            Console.WriteLine();

        }

        public override void Start()
        {
            Console.WriteLine();

        }

        public override void PrintMediaInfo()
        {
            Console.WriteLine();

        }
    }
}
