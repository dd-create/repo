using System;
using System.IO.Ports;
using System.Threading;
using System.Collections.Generic;

public class Dht11 
{
    public static string getData()
    {      

        SerialPort myPort = new SerialPort("COM3", baudRate:9600) ;

        myPort.Open() ;

        string[] myData ;
        string returnData ;

        myPort.ReadLine() ;
        myPort.ReadLine() ;
        myData = ( myPort.ReadLine() ).Split(',') ;
        returnData = DateTime.Now + " 현재, 온도는 " + myData[0] + " °C , 습도는 " + myData[1] + " % 입니다." ;

        // for (int i = 0; i < 4; i++)
        // {
        //     datas = myPort.ReadLine() ;
        //     data.Add(datas) ;
        // }

        myPort.Close() ;

        return returnData ;
    }
}