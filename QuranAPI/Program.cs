using System.Net;
using RestSharp;
using Newtonsoft.Json.Linq;

internal class QuranAPI
{
    public static String get_verse(int verse)
    {
        String d_ = "";
        try
        {
            var client = new RestClient("https://api.alquran.cloud");
            var request = new RestRequest("v1/ayah/" + verse + "/editions/en.asad", Method.Get);
            var respo___ = client.Execute(request);
            var parsed = JObject.Parse(respo___.Content)["data"][0]["text"];
            d_ = (string)parsed;
        }
        catch (Exception e)
        {
            d_ = "";
        }
        return d_;
    }
}
internal class ColorWriter
{
    public static void write_color(String msg, int color, bool reset_color = true, bool write_line = true)
    {
        List<ConsoleColor> s = Enum.GetValues(typeof(ConsoleColor)).Cast<ConsoleColor>().ToList();
        Console.ForegroundColor = s[color];
        if (write_line == true)
        {
            Console.WriteLine(msg);
        }
        else
        {
            Console.Write(msg);
        }
        if (reset_color == true)
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public static void write_sequence(List<String> messages, List<int> colors, bool reset_color = true, bool write_line = true)
    {
        List<ConsoleColor> s = Enum.GetValues(typeof(ConsoleColor)).Cast<ConsoleColor>().ToList();
        foreach (String message in messages)
        {
            int current_Index = colors[messages.IndexOf(message)];
            Console.ForegroundColor = s[current_Index];
            if (write_line == true)
            {
                Console.WriteLine(message);
            }
            else
            {
                Console.Write(message);
            }
        }
        if (reset_color == true)
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
        List<String> before_prompt = new List<string>();
        before_prompt.Add("\n\n\tSalam, I hope you enjoy this project.");
        before_prompt.Add("\n\t----------------------------------");
        before_prompt.Add("\n\tI made this project as a way of learning C#,\n\tand to benefit the peoples from this project");
        before_prompt.Add("\n\tMay this message reach you in the best of health and Iman.\n\n\tCommands:\n\t ?n -- next verse\n\t ?p -- previous verse\n\t ?t [verse_n] -- goes to the verse index\n\t ?ar [max_verses] [delay (s)] -- logs all verses until max_verses (plus delay so you can read)\n\t ?b -- exit");
        List<int> color_prompts = new List<int>();
        color_prompts.Add((int)ConsoleColor.Yellow);
        color_prompts.Add((int)ConsoleColor.Yellow);
        color_prompts.Add((int)ConsoleColor.Red);
        color_prompts.Add((int)ConsoleColor.Blue);
        ColorWriter.write_sequence(before_prompt, color_prompts);
        int cur = 0;
        int cln = 0;
        int MAX_VERSES = 6236;
        int MAX_COLORS = 15;
        while (true)
        {
            string cmd = Console.ReadLine();
            if (cmd == "?n")
            {
                cur++;
                cln++;
                if (cur > MAX_VERSES)
                {
                    Console.WriteLine("Reached max verses. Setting verse back to 0..");
                    cur = 0;
                }
                if (cln >= MAX_COLORS)
                {
                    cln = 0;
                }
                ColorWriter.write_color(QuranAPI.get_verse(cur), cln);
            }
            else if (cmd == "?p")
            {
                cur--;
                if (cur < 0)
                {
                    Console.WriteLine("Error occured going back!");
                    cur = 0;
                }
                ColorWriter.write_color(QuranAPI.get_verse(cur), cln);
            }
            else if (cmd.StartsWith("?t ") && cmd.Split(' ')[1] != null)
            {
                cln++;
                if (cln >= MAX_COLORS)
                {
                    cln = 0;
                }
                var verse_arguments = cmd.Split(' ');
                var m_v = Convert.ToInt32(verse_arguments[1]);
                if (m_v > MAX_VERSES)
                {
                    Console.WriteLine("Cannot set verse greater than " + MAX_VERSES + ".");
                    m_v = 1;
                }
                cur = m_v;
                ColorWriter.write_color(QuranAPI.get_verse(cur), cln);
            }
            else if (cmd == "?b")
            {
                break;
            }
            else if (cmd.StartsWith("?ar ") && cmd.Split(' ')[1] != null)
            {
                var m_args = cmd.Split(' ');
                int until_verse;
                try
                {
                    until_verse = Convert.ToInt32(m_args[1]);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid number!");
                    until_verse = 0;
                }
                int delay;
                try
                {
                    delay = Convert.ToInt32(m_args[2]);
                }
                catch (Exception m)
                {
                    delay = 1;
                }
                if (until_verse > 0)
                {
                    for (var l = 1; l <= until_verse; l++)
                    {
                        var kl = cur + l;
                        if (cln >= MAX_COLORS)
                        {
                            cln = 0;
                        }
                        cln++;
                        if (kl > MAX_VERSES)
                        {
                            Console.WriteLine("Exceeded max verses");
                        }

                        ColorWriter.write_color(QuranAPI.get_verse(kl), cln);
                        Thread.Sleep(delay * 1000);
                    }
                }
            }
        }
    }
}