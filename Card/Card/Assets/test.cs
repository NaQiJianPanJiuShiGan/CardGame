using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface test  {
    string s { get; set; }
    void show();
}
public class test1
{
    public void show(test test)
    {
        test.show();
    }
}