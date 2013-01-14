using System;
using System.Collections.Generic;

namespace Resume
{
    /// <see cref="http://github.com/cable729"/>
    public class CalebJares //: INetDeveloper, IStudent, IPassionate, IHirable, IEmploymentHistory
    {
        public dynamic ContactInformation = new {
            Email = new Uri(@"cjares@cse.unl.edu"), Phone = "970-590-3046"
        };

        public const string Objective = "To obtain a full-time internship for the summer of 2013 " +
            "where I am able to utilize my programming, problem-solving, and creative skills." +
            "I welcome an environment where I am challenged every day and look forward to " +
            "learning new technologies, making lasting connections, and having fun.";

        public IEnumerable<string> Interests { get { return new string[] {
            "C#", "Software Architecture", ".NET", "Dependency Injection & IoC",
            "MVC 4", "C++", "Mobile Development", "Git", "TFS" };
        } }

        public IEnumerable<string> Skills { get { return new string[] {
            "C#", ".NET", "PowerShell", "Git", "TFS", "EntityFramework", "XNA", "XAML",
            "MVC", "MVVM", "XML", "Java", "C++", "LaTeX", "Html", "CSS", "Javascript", "UNIX" };
        } }

        public IEnumerable<EmploymentRecord> PreviousWork { get { return new List<EmploymentRecord> {
            new EmploymentRecord {
                Name = "Locabal", Start = new DateTime(2012, 8, 24), CurrentlyEmployed = true,
                Description = "Back-end architecture lead for www.locabal.com. Locabal is a " +
                    "student-led startup whose mission is to connect producers of handcrafted items " +
                    "with buyers both locally and globally.",
                Technologies = new string[] { "C#", "MVC", "EntityFramework" }
            },
            new EmploymentRecord {
                Name = "Intel", Start = new DateTime(2012, 5, 14), End = new DateTime(2012, 8, 10),
                Description = "Used PowerShell and various cmd-line tools to automate installations " +
                    "and updates of server instances. Reverse-engineered 3rd-party installers that " +
                    "didn't offer automated installers.",
                Technologies = new string[] { "PowerShell", "Windows", "cmd" }
            },
            new EmploymentRecord {
                Name = "Green Bein", Start = new DateTime(2012, 3, 8), End = new DateTime(2012, 5, 1),
                Description = "Worked on the game Synch, a 2D platformer that allows users " +
                    "to share custom created stages through Facebook and Synch's website.",
                Technologies = new string[] { "Actionscript 3" }
            },
            new EmploymentRecord {
                Name = "UNL Avery Hall", Start = new DateTime(2011, 11, 11), End = new DateTime(2012, 5, 1),
                Description = "Helped students with computer science homework and provided "+
                    "technical maintanence for the CSE department.",
                Technologies = new string[] { "C++, Java, Matlab, Unix, Algorithms, Discrete Mathematics" }
            } };
        } }

        public dynamic Education = new {
            Name = "University of Nebraska-Lincoln", Majors = new[] { "Computer Science", "Mathematics" },
            GPA = "3.0", Start = new DateTime(2011, 8, 17), Graduation = new DateTime(2015, 5, 5)
        };

        internal event EventHandler OnHire;
        public bool Hire(EventArgs hireArgs) { this.OnHire(this, hireArgs); return true; }

        public static void Main(string[] args) { }
    }

    public class EmploymentRecord
    {
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool CurrentlyEmployed { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> Technologies { get; set; }
    }
    public interface IEmploymentHistory { IEnumerable<EmploymentRecord> PreviousWork { get; } }
    public interface IHirable { IEnumerable<string> Skills { get; } }
    public interface IPassionate { IEnumerable<string> Interests { get; } }
    public interface INetDeveloper /* : IDisposable // ha ha */ { }
    public interface IStudent { }
}
