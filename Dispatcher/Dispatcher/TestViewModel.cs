
namespace Dispatcher
{
    public class TestViewModel
    {
        public string TestText { get; set; } = "132";

        public List<string> monkeyList { get; set; } = new List<string> 
        {
            "Baboon",
            "Capuchin Monkey",
            "Blue Monkey",
            "Squirrel Monkey",
            "Golden Lion Tamarin",
            "Howler Monkey",
            "Japanese Macaque"
        };

        static RunTypeMap Delayed = new(1, "延时启动");
        static RunTypeMap PressKey = new(2, "按键启动");
        public List<RunTypeMap> Items { get; set; } = new() { Delayed, PressKey };
    }
    public class RunTypeMap
    {
        private readonly int ID;
        public string Disp { get; set; }

        public RunTypeMap()
        {

        }

        public RunTypeMap(int id, string disp)
        {
            ID = id;
            Disp = disp;
        }

        //public static string GetDisp(int id)
        //{
        //    var temp = Items.Where(p => p.ID == id);
        //    if (temp.Count() == 1)
        //    {
        //        return temp.Single().Disp;
        //    }
        //    return string.Empty;
        //}



    }

}
