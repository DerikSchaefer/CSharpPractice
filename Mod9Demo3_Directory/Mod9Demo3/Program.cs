using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mod9Demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DriveInfo driveInfo = new DriveInfo(@"C:\");
            Console.WriteLine($"Drive info for C drive: {driveInfo.Name}, free space {driveInfo.TotalFreeSpace}");
            Console.ReadLine();
            DirectoryInfo[] directoryInfos = new DirectoryInfo(@"C:\").GetDirectories();
          
/*            foreach (DirectoryInfo directoryInfo in directoryInfos)
            {
                if (directoryInfo.Name.Length != 0)
                {
                    directoryInfo.Delete(true);
                }*/
                Console.WriteLine(directoryInfo.Name + " " + directoryInfo.CreationTime);
                
            }
        }
    }
}
