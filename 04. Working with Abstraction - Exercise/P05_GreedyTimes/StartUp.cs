using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            string[] protection = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var box = new Dictionary<string, Dictionary<string, long>>();
            long gold = 0;
            long rocks = 0;
            long money = 0;

            for (int i = 0; i < protection.Length; i += 2)
            {
                string name = protection[i];
                long count = long.Parse(protection[i + 1]);

                string current = string.Empty;

                if (name.Length == 3)
                {
                    current = "Cash";
                }
                else if (name.ToLower().EndsWith("gem"))
                {
                    current = "Gem";
                }
                else if (name.ToLower() == "gold")
                {
                    current = "Gold";
                }

                if (current == "")
                {
                    continue;
                }
                else if (input < box.Values.Select(x => x.Values.Sum()).Sum() + count)
                {
                    continue;
                }

                switch (current)
                {
                    case "Gem":
                        if (!box.ContainsKey(current))
                        {
                            if (box.ContainsKey("Gold"))
                            {
                                if (count > box["Gold"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (box[current].Values.Sum() + count > box["Gold"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                    case "Cash":
                        if (!box.ContainsKey(current))
                        {
                            if (box.ContainsKey("Gem"))
                            {
                                if (count > box["Gem"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (box[current].Values.Sum() + count > box["Gem"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                }

                if (!box.ContainsKey(current))
                {
                    box[current] = new Dictionary<string, long>();
                }

                if (!box[current].ContainsKey(name))
                {
                    box[current][name] = 0;
                }

                box[current][name] += count;
                if (current == "Gold")
                {
                    gold += count;
                }
                else if (current == "Gem")
                {
                    rocks += count;
                }
                else if (current == "Cash")
                {
                    money += count;
                }
            }

            foreach (var x in box)
            {
                Console.WriteLine($"<{x.Key}> ${x.Value.Values.Sum()}");
                foreach (var item2 in x.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
                {
                    Console.WriteLine($"##{item2.Key} - {item2.Value}");
                }
            }
        }
    }
}