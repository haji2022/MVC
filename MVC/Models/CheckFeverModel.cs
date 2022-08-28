namespace MVC.Models
{
    public class CheckFeverModel
    {
        public static string CheckifTempIsOk(int Temp)
        {
            if (Temp == 37)
                return "you are ok";

            else if (Temp > 37)
                return "you are sick stay at Home";
            else return "you have hypothermia";
        }

    
    }
}
