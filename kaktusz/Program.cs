namespace kaktusz
{
    internal class Program
    {
        static List<kaktusz> kaktuszlist = new List<kaktusz>();
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("kaktuszok.txt")) 
            {
                while (!sr.EndOfStream)
                {
                    kaktuszlist.Add(new kaktusz(sr.ReadLine()));
                }
            }
            Console.WriteLine($"f1 : kaktuszok száma: {kaktuszlist.Count}");
            Console.WriteLine($"f2 : leghosszabb tudományos név: {kaktuszlist.OrderByDescending(x => x.tnev).First().tnev}");
            Random rnd = new Random();
            int a = rnd.Next(0, kaktuszlist.Where(x => x.vigeny > 100).Count());
            Console.WriteLine($"f3 : 100ml-nél nagyobb vízigényű kaktuszok száma: {kaktuszlist.Where(x => x.vigeny > 100).Count()}\n\tpéldául: {kaktuszlist.Where(x => x.vigeny > 100).ToList()[a].knev} ({kaktuszlist.Where(x => x.vigeny > 100).ToList()[a].vigeny} ml/hét)");
            Dictionary<string, int> termnehez = new Dictionary<string, int>();
            foreach (var item in kaktuszlist)
            {
                if (termnehez.ContainsKey(item.tnehez))
                {
                    termnehez[item.tnehez]++;
                }
                else
                {
                    termnehez.Add(item.tnehez, 1);
                }
            }
            var rendezett = termnehez.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
            Console.WriteLine("f4: kaktuszok száma termelési nehézség szerint:");
            foreach (var item in rendezett)
            {
                Console.WriteLine($"\t{item.Key}: {item.Value}db");
            }
        }
    }
}
