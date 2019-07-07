using System;
using System.Net;

namespace oai_pmh_invalid_char_locator {
    class Program {
        static void Main(string[] args) {
            if(args.Length != 1) {
                Console.WriteLine("Invalid amount of arguments.");
                return;
            }

            var url = args[0];
            Console.WriteLine("Downloading data, this might take a while..");

            var wc = new WebClient();
            var source = wc.DownloadString(url);
            
            Console.WriteLine("Data downloaded, validating..");
            Validator.Validate(source);
        }
    }
}
