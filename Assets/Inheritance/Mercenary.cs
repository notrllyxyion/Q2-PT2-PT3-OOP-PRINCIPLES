using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercenary : Base
{

    public void Start()
    {
        Hello();
        Randomy();
    }
    protected override void Hello()
    {
        Debug.Log("naglakad");
    }

    protected override void Randomy()
    {
        Debug.Log("sinuntok si swordsman");
    }
}
