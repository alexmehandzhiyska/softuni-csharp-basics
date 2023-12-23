string name = Console.ReadLine();
int projectsCount = int.Parse(Console.ReadLine());

int hoursNeeded = projectsCount * 3;

Console.WriteLine($"The architect {name} will need {hoursNeeded} hours to complete {projectsCount} project/s.");