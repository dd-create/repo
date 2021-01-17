using System;
using System.IO.Ports;
using System.Threading;
using System.Collections.Generic;

public class Dht11 
{
    public static void getData(List<string> data)
    {      

        SerialPort myPort = new SerialPort("COM3", baudRate:9600) ;

        myPort.Open() ;

        string datas;

        for (int i = 0; i < 4; i++)
        {
            datas = myPort.ReadLine() ;
            data.Add(datas) ;
        }

        myPort.Close() ;
    }
}