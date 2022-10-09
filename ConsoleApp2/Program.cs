using ConsoleApp2;
using System.Text;

class Progamm
{
    static void Main(string[] args)
    {
        Team team = new Team();
        Console.WriteLine($"Name of the building company: {team.Name}");
        Console.WriteLine($"Name of CEO: {team.teamLeader.Name}");
        for (int i = 0; i < team.workers.Length; i++)
        {
            Console.WriteLine($"The name of the worker:{team.workers[i].Name} and his profession: {team.workers[i].profession} ");
        }
        
        Console.WriteLine("it's your team");
        Console.WriteLine("Please push any key");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Let's start make a building");
        int choise;
        do
        {
            Console.WriteLine("1. Build Basement");
            Console.WriteLine("2. Build Walls");
            Console.WriteLine("3. Build Windows");
            Console.WriteLine("4. Build Door");
            Console.WriteLine("5. Build Roof");
            Console.WriteLine("6. Checkup of ending works");
            Console.WriteLine("7. I spend all my money sorry");

            try
            {
                choise = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
          
            switch (choise)
            {
                case 1://build basement
                    {
                        team.workers[0].BuildPart(new Basement()); //team.workers[0].BuildPart(new Basement()).BuildPart(new Roof()) - работает паттерн;
                        Console.WriteLine($"The worker {team.workers[0].Name}, {team.workers[0].profession} make this basement with area {team.workers[0].BuildFinishedHome().basement.Area}");
                        Console.WriteLine("Push any button");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    }
                case 2://build walls
                    {

                        if (team.workers[0].BuildFinishedHome().basement==null)
                        {
                            Console.WriteLine("Sorry you can't build walls before Basement, make Basement first");
                            Console.WriteLine("Push any button");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            team.workers[1].BuildPart(new Wall());
                            Console.WriteLine($"The worker {team.workers[1].Name}, {team.workers[1].profession} make this walls with high: {team.workers[1].BuildFinishedHome().walls[0].High}");
                            Console.WriteLine("Push any button");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    }
                case 3://build windows
                    {

                        if (team.workers[2].BuildFinishedHome().basement==null && team.workers[1].BuildFinishedHome().walls==null)
                        {
                            Console.WriteLine("Sorry you can't build windows with out walls and Basement");
                            Console.WriteLine("Push any button");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            team.workers[2].BuildPart(new Window());
                            Console.WriteLine($"The worker {team.workers[2].Name}, {team.workers[2].profession} make this windows with high {team.workers[2].BuildFinishedHome().windows[0].High}");
                            Console.WriteLine("Push any button");
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        }
                    }
                case 4://build door
                    {
                        if (team.workers[2].BuildFinishedHome().basement==null && team.workers[1].BuildFinishedHome().walls==null)
                        {
                            Console.WriteLine("Sorry you can't build door with out walls and Basement");
                            Console.WriteLine("Push any button");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {

                            team.workers[3].BuildPart(new Door());
                            Console.WriteLine($"The worker {team.workers[3].Name}, {team.workers[3].profession} make this door with high :{team.workers[3].BuildFinishedHome().door.High}");
                            Console.WriteLine("Push any button");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    }
                case 5://build roof
                    {
                        if (team.workers[2].BuildFinishedHome().basement==null && team.workers[1].BuildFinishedHome().walls==null&& team.workers[3].BuildFinishedHome().door==null)
                        {
                            Console.WriteLine("Sorry you can't build roof with out walls , Basement and door");
                            Console.WriteLine("Push any button");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {

                            team.workers[4].BuildPart(new Roof());
                            Console.WriteLine($"The worker {team.workers[4].Name}, {team.workers[4].profession} make this roof with the area: {team.workers[4].BuildFinishedHome().roof.area}");
                            Console.WriteLine("Push any button");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    }
                case 6://report
                    {
                        StringBuilder stringBuilder = new StringBuilder();
                        for (int i = 0; i < team.workers.Length; i++)
                        {
                            stringBuilder.Append(team.teamLeader.Report1(team.workers[i].BuildFinishedHome())); 
                        }
                        if (stringBuilder.ToString().Length==0)
                        {
                            Console.WriteLine("The works not started");
                        }
                        else
                        {
                            Console.WriteLine(stringBuilder);
                        }
                        //Console.WriteLine(stringBuilder);
                        Console.WriteLine("Push any button");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case 7://bastarde
                    {
                        Console.WriteLine("You are bad man");
                        break;
                    }
            }
        } while (choise!=7 && !(team.workers[0].BuildFinishedHome().basement!=null && team.workers[1].BuildFinishedHome().walls!=null &&
        team.workers[2].BuildFinishedHome().windows!=null && team.workers[3].BuildFinishedHome().door!=null && team.workers[4].BuildFinishedHome().roof!=null));

        if (!(team.workers[0].BuildFinishedHome().basement==null && team.workers[1].BuildFinishedHome().walls==null &&
        team.workers[2].BuildFinishedHome().windows==null && team.workers[3].BuildFinishedHome().door==null && team.workers[4].BuildFinishedHome().roof==null))
        {
            Console.WriteLine("Home is done.Welcome home");
        }
        else
        {
            Console.WriteLine("Home is not done");
        }
    }
}