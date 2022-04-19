using System;
using System.Reflection;

namespace CustomAttribute
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SoftwareAttribute : System.Attribute
    {
        public string ProjectName{ get; set; }
        public string Description{ get; set; }
        public string ClientName{ get; set; }
        public string StartedDate{ get; set; }
        public string EndDate{ get; set; }

        public SoftwareAttribute(string message)
        {
            Console.WriteLine(message);
        }

        public SoftwareAttribute(string PName, string desc, string CName, string SDate, string EDate)
        {
            ProjectName = PName;
            Description = desc;
            ClientName = CName;
            StartedDate = SDate;
            EndDate = EDate;
        }
    }

    [SoftwareAttribute("Return details of the project.")]
    class HDFCAccount
    {}

    [SoftwareAttribute("Return details of the project.")]
    class ICICIAccount
    {}

    class Test
    {
        SoftwareAttribute attribute = (SoftwareAttribute)Attribute.GetCustomAttribute(typeof(HDFCAccount), typeof(SoftwareAttribute));
        public Test()
        {
            Console.WriteLine(attribute.ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
        }
    }
}
