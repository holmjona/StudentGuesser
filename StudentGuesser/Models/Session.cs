using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//https://www.c-sharpcorner.com/article/transform-an-existing-mvc-app-to-a-real-time-app-using-signalr/
public class Session {
    private string _Key;
    private string _EditCode;
    private DateTime _DateStart;
    private DateTime _DateEnd;

    public string Key {
        get { return _Key; }
        set { _Key = value; }
    }

    public string EditCode {
        get { return _EditCode; }
        set { _EditCode = value; }
    }

    public DateTime DateStart {
        get { return _DateStart; }
        set { _DateStart = value; }
    }

    public DateTime DateEnd {
        get { return _DateEnd; }
        set { _DateEnd = value; }
    }


}
