using StreamReader f = new StreamReader(@"C:\Users\egora\RiderProjects\ConsoleApp1\input.txt");
int s = int.Parse(f.ReadLine());

for (int i = 0; i < s; i++)
{
    string[] line = f.ReadLine().Split(new char[] { ' ' });
    int n = int.Parse(line[0]);
    int m = int.Parse(line[1]);
    int d = 19 * m + (n + 239) * (n + 366) / 2;
    using (StreamWriter sw = new StreamWriter(@"C:\Users\egora\RiderProjects\ConsoleApp1\output.txt", true))
    {
        sw.WriteLine(d.ToString());
    }
}