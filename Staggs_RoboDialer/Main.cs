// Colton Staggs
// IT112
// NOTES: I had some troubles interpreting what you were asking entirely.
// BEHAVIORS NOT IMPLIMENTED AND WHY: 
using System.Runtime.ExceptionServices;

namespace Staggs_RoboDialer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone[] DialingNames = new Phone[10];
            DialingNames[0] = new CellPhone("CompuTest", "(303) 985-5060", 1);
            DialingNames[1] = new HomePhone("Curtis Manufacturing", "(603) 532-4123", 2);
            DialingNames[2] = new CellPhone("Data Functions", "(800) 876-2524", 1);
            DialingNames[3] = new CellPhone("Donnay Repair", "(708) 397-3330", 1);
            DialingNames[4] = new CellPhone("ErgoNomic Inc", "(360) 434-3894", 1);
            DialingNames[5] = new CellPhone("ErgoSource", "(800) 969-4374", 1);
            DialingNames[6] = new HomePhone("Fox Bay Industries", "(800) 874-8527", 2);
            DialingNames[7] = new HomePhone("Glare-Guard", "(800) 545-6254", 2);
            DialingNames[8] = new HomePhone("Hazard Comm Specialists", "(407) 783-6641", 2);
            DialingNames[9] = new HomePhone("Komfort Support", "(714) 472-4409", 2);
            for (int i = 0; i < DialingNames.Length; i++)
            {
                Console.WriteLine(DialingNames[i].Dial());
            }
        }
    }
}