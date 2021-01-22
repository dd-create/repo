using System ;
using System.IO.Ports ;

public class Arduino
{
    public static string getData()
    {
        SerialPort arduino = new SerialPort("COM3", baudRate:9600) ;

        arduino.Open() ;

        arduino.ReadLine() ;
        string data = arduino.ReadLine() ;

        arduino.Close() ;

        return data ;
    }

    public static string getTempHumi()
    {
        string[] datas = (getData()).Split(',') ;
        string returnString = "온도 : " + datas[0] + " °C, 습도 : " + datas[1] ;
        
        return returnString ;
    }

    public static int getFlame()
    {
        string[] datas = (getData()).Split(',') ;
        int returnInt = Int32.Parse(datas[2]) ;
        
        return returnInt ;
    }
}
