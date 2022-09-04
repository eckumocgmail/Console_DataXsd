using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml.Serialization;

 
internal class XsdProgram
{
        
    internal static string _wrk = System.IO.Directory.GetCurrentDirectory();
    /// <summary>
    /// 
    /// xsd.exe<assembly>.dll|.exe[/ outputdir:][/ type: [...]]
    /// xsd.exe <instance>.xml [/ outputdir:]
    /// xsd.exe<schema>.xdr [/outputdir:]
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {


        var definition = new tDefinitions()
        {
            types = new tTypes[] { 
                new tTypes()
                {
                        
                }
            },
            import=new tImport[0],
            

            message = new tMessage[0],

            portType=new tPortType[0],

            binding = new tBinding[0],

            service = new tService[] { 
                new tService()
                {
                    port = new tPort[]
                    {
                            
                    }
                }
            }

    };
          
        using (var stream=new MemoryStream())
        {
            var serializer = new XmlSerializer(typeof(tDefinitions));
            serializer.Serialize(stream, definition);
            Console.WriteLine(Encoding.UTF8.GetString(stream.ToArray()));
        }
                


        Console.WriteLine("Hello World!");
        var scheme = new MetroScheme();
             
        Exec("CMD HELP");
    }

    static void ClassesGeneration(string Schema){
        Exec($"xsd.exe {Schema}.xsd /classes|dataset [/e:] [/l:] [/n:] [/o:] [/s] [/uri:]");
    }
    static void DatasetGeneration(string Schema){
        Exec($"xsd.exe {Schema}.xsd /dataset [/e:] [/l:] [/n:] [/o:] [/s] [/uri:]");
    }

    public static string Exec(string command)
    {
        System.Console.WriteLine("Execute command: " + command);
        //new PowerShell().Execute("Get-Command").ToJsonOnScreen().WriteToConsole();
        var t = new System.Threading.Thread(() =>
        {
            ProcessStartInfo info = new ProcessStartInfo("PowerShell.exe", $"d: && cd {_wrk} && " + command);
            info.RedirectStandardError = true;
            info.RedirectStandardOutput = true;
            info.UseShellExecute = false;

            System.Diagnostics.Process process = System.Diagnostics.Process.Start(info);
            System.IO.StreamReader reader = process.StandardOutput;
            while(process.HasExited==false)
            {
                string line;
                while((line=process.StandardOutput.ReadLine())!=null)
                {
                    Console.WriteLine(line);
                }
            }
        });
        t.IsBackground = true;
        t.Start();
           
        return "Process Has Been Started";
    } 
}
 