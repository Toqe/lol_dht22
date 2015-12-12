using System;
using System.Runtime.InteropServices;
 
public class DhtMain
{
    public static void Main()
    {
        new DhtMain().Run();
    }
    
    public void Run()
    {
        var t = new float[1];
        var h = new float[1];
        var x = read_dht22_dat_with_lock(t, h);
        var msg = string.Format("{0} {1} {2}", x, t[0], h[0]);
        Console.WriteLine(msg);
    }

    [DllImport("dht")]
    private static extern int read_dht22_dat_with_lock (float[] tOut, float[] hOut);
}

