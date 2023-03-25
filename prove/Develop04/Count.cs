using System;

public class Count{
    private int _sec = 0;

    public Count(int sec){
        _sec = sec;
    }

    public void GetCount() {
        while (_sec > 0){
            Console.Write(_sec);
            _sec--;
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}