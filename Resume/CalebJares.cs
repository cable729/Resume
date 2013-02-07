using System;
using System.Collections.Generic;

namespace Resume
{
#region Select_This_Region_To_Print
    /// <summary> An object-oriented resume written by Caleb Jares </summary>
    /// <seealso cref="https://github.com/cable729/Resume" />
    public class CalebJares : INetDeveloper, IStudent, IPassionate, IHirable
    {
        public dynamic ContactInformation = new {
            Email = new Uri("cjares@cse.unl.edu"), Phone = "970-590-3046"
        };

        public const string Objective = "To obtain a full-time internship for the summer of 2013 " +
            "where I am able to utilize my programming, problem-solving, and creative skills." +
            "I welcome an environment where I am challenged every day and look forward to " +
            "learning new technologies, making lasting connections, and having fun.";

        public IEnumerable<string> Interests = new[] {
            "C#", "Software Architecture", ".NET", "Dependency Injection & IoC",
            "MVC 4", "C++", "Game Development", "Mobile Development", "Git", "TFS"
        };
        public IEnumerable<string> Skills = new[] {
            "C#", ".NET", "PowerShell", "Git", "TFS", "EntityFramework", "XNA", "XAML",
            "MVC", "MVVM", "XML", "Java", "C++", "LaTeX", "Html", "CSS", "Javascript", "UNIX"
        };

        public dynamic PreviousWork = new {
            Locabal = new {
                Start = new DateTime(2012, 8, 24), CurrentlyEmployed = true,
                Description = "Back-end architecture lead for www.locabal.com. Locabal is a " +
                    "student-led startup whose mission is to connect producers of handcrafted items " +
                    "with buyers both locally and globally.",
                Technologies = new[] { "C#", ".NET", "MVC", "EntityFramework" }
            },
            Intel = new {
                Start = new DateTime(2012, 5, 14), End = new DateTime(2012, 8, 10),
                Description = "Used PowerShell and various cmd-line tools to automate installations " +
                    "and updates of server instances. Reverse-engineered 3rd-party installers that " +
                    "didn't offer automated installers.",
                Technologies = new[] { "PowerShell", "Windows", "cmd" }
            },
            Green_Bein = new {
                Start = new DateTime(2012, 3, 8), End = new DateTime(2012, 5, 1),
                Description = "Worked on the game Synch, a 2D platformer that allows users " +
                    "to share custom created stages through Facebook and Synch's website.",
                Technologies = new[] { "Actionscript 3" }
            },
            UNL_Avery_Hall = new {
                Start = new DateTime(2011, 11, 11), End = new DateTime(2012, 5, 1),
                Description = "Helped students with computer science homework and provided "+
                    "technical maintenance for the CSE department.",
                Technologies = new[] { "C++", "Java", "Matlab", "Unix", "Algorithms" }
            }
        };

        public string[] HighSchoolProjects = new[] { "XNA Development for Zune: Snake",
            "iOS: Objective-C, C++, cocos2d", "Warcraft III Mods: Run Kitty Run, Chase the Ent",
            "Took two C++ and one Java community college while in high school"
        };
        public string[] CollegeInvolvement = new[] { "ACM Programming Comptetition 2011 & 2012",
            "UNL Gaming Club", "UNL Math Club", "UNL Hive"
        };

        public dynamic Education = new {
            Name = "University of Nebraska-Lincoln", Majors = new[] { "Computer Science", "Mathematics" },
            GPA = "3.1", Start = new DateTime(2011, 8, 17), Graduation = new DateTime(2015, 5, 5)
        };
    }
#endregion
}
