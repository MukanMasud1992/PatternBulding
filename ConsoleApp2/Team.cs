using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Team
    {
        public TeamLeader teamLeader;
        public Worker[] workers;

        public string Name => "ZhanaKazahstanStroi";

        public Team()
        {
            teamLeader = new TeamLeader() { Name="Tokaev" };
            workers = new Worker[]
                {
                    new Worker(){ Name = "Masimov",profession = "BasementMaker"},
                    new Worker(){ Name = "Mamin",profession = "WallMaker"},
                    new Worker(){ Name = "Mami", profession = "WindowMaker"},
                    new Worker(){ Name = "Mussin", profession = "DoorMaker"},
                    new Worker(){ Name = "Abayev",profession = "RoofMaker"}
                };
        }
    }
    class Worker
    {
        public string Name;
        public string profession;

        private Home home = new Home();
        public Worker BuildPart(IParts parts)
        {
            parts.Build(home);
            return this;
        }

        public Home BuildFinishedHome()
        {
            return home;
        }
    }

    class TeamLeader
    {
        public string Name;

        public string Report1(Home home)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (home.basement != null)
            {
                stringBuilder.AppendLine($"The basement is alreade done area {home.basement.Area}");
            }
            if (home.walls != null)
            {
                stringBuilder.AppendLine($"The Walls is alreade done with high {home.walls[0].High}");
            }
            if (home.windows != null)
            {
                stringBuilder.AppendLine($"The windows is alreade donewith with high {home.windows[0].High}");
            }
            if (home.door != null)
            {
                stringBuilder.AppendLine($"The door is alreade done with high {home.door.High}");
            }
            if (home.roof != null)
            {
                stringBuilder.AppendLine($"The roof is alreade done with area {home.roof.area}");
            }
            return stringBuilder.ToString();
        }
        public void Report(Home home)
        {
            if (home.basement != null)
            {
                Console.WriteLine($"The basement is alreade done area {home.basement.Area}");
            }
            if (home.walls != null)
            {
                Console.WriteLine($"The Walls is alreade done with high {home.walls[0].High}");
            }
            if (home.windows != null)
            {
                Console.WriteLine($"The windows is alreade donewith with high {home.windows[0].High}");
            }
            if (home.door != null)
            {
                Console.WriteLine($"The door is alreade done with high {home.door.High}");
            }
            if (home.roof != null)
            {
                Console.WriteLine($"The roof is alreade done with area {home.roof.area}");
            }

        }
    }
}
