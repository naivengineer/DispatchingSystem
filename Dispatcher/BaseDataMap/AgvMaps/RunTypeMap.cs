using System.Globalization;

namespace BaseDataMap.AgvMaps
{
    public class RunTypeMap
    {
        private readonly int ID;
        public string Disp { get; set; }

        public string IDDisp { get => $"{ID}.{Disp}"; }

        public RunTypeMap()
        {

        }

        public RunTypeMap(int id, string disp) 
        { 
            ID = id;
            Disp = disp;
        }

        public string GetDisp(int id)
        {
            var temp = Items.Where(p => p.ID == id);
            if (temp.Count() == 1)
            {
                return temp.Single().Disp;
            }
            return string.Empty;
        }

        static readonly RunTypeMap StartDelayed      = new( 1, "延时启动");
        static readonly RunTypeMap StartPressKey     = new( 2, "按键启动");
        static readonly RunTypeMap StartScreen       = new( 3, "屏幕启动");
        static readonly RunTypeMap StartServer       = new( 4, "服务启动");
        static readonly RunTypeMap StartOther        = new( 5, "其他启动");
                                                            
        static readonly RunTypeMap StopPressKey      = new( 6, "按键停止");
        static readonly RunTypeMap StopScreen        = new( 7, "屏幕停止");
        static readonly RunTypeMap StopServer        = new( 8, "服务停止");
        static readonly RunTypeMap StopAnticollision = new( 9, "防撞停止");
        static readonly RunTypeMap StopPoint         = new(10, "站点停止");
        static readonly RunTypeMap StopEmergency     = new(11, "急停停止");
        static readonly RunTypeMap StopDerail        = new(12, "脱轨停止");
        static readonly RunTypeMap StopFault         = new(13, "故障停止");
        static readonly RunTypeMap StopAvoiding      = new(14, "避障停止");
        static readonly RunTypeMap StopOther         = new(15, "其他停止");

        public List<RunTypeMap> Items { get; set; } = new()
        {
            StartDelayed ,
            StartPressKey,
            StartScreen  ,
            StartServer  ,
            StartOther   ,

            StopPressKey ,
            StopScreen   ,
            StopServer   ,
            StopAnticollision,
            StopPoint    ,
            StopEmergency,
            StopDerail   ,
            StopFault    ,
            StopAvoiding ,
            StopOther    ,
        };

    }

    public class RunTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,  object parameter, CultureInfo culture) 
        { 
            if (value == null)
            {
                if (int.TryParse(value.ToString(), out int intValue))
                {
                    RunTypeMap runTypeMap = new();
                    runTypeMap.GetDisp(intValue);
                }
            }
            return string.Empty; 
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }

    }

}
