using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Uppgift1
{
    internal class Song : Media
    {
        private string Artist;

        public Song(string inputArtist, string inputTitle, string inputFilePath, int inputDuration, int inputPublicationYear) : base(inputTitle, inputFilePath, inputDuration, inputPublicationYear)
        {
            Artist = inputArtist;
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
