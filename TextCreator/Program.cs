Console.WriteLine("Start");

try
{
    const int last = 111;
    const string resultFolder = "result";
    const string template = "<p align=\"center\"><img src=\"/assets/images/39-qeshm/";
    const string template2 = ".jpg\" width=\"600\" height=\"600\" alt=\"mhkarami97\" /></p>";

    Directory.CreateDirectory(resultFolder);
    using var sw = new StreamWriter($"{resultFolder}.md");

    for (var i = 1; i < last; i++)
    {
        try
        {
            sw.WriteLine(template + i.ToString("000") + template2);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    Console.WriteLine("finish");
}
catch (Exception e)
{
    Console.WriteLine(e);
}