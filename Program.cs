using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multithreaded_web_server
{
    internal class Program
    {
        private static readonly String root = "/Files";
        private static readonly int PORT = 5050;
        // <string,string> - GET method, response
        private static ConcurrentDictionary<string, string> responseCache = new ConcurrentDictionary<string, string>();

        static void Main(string[] args)
        {
            
        }
    }
}
