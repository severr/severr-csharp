using IO.SeverrClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeverrSampleApp
{
    /// <summary>
    /// Sample program to generate an event
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception("This is a test exception.");
            }
            catch (Exception e)
            {
                // Send the event to Severr
                e.SendToSeverr();
            }
        }
    }
}
