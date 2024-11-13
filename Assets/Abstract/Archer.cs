using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Base2
{
    protected override void Onclick()
    {
        Debug.Log("Archer says boom panis");
    }

    protected override void Lol()
    {
        Debug.Log("Archer attacks");
    }

    private void Start()
    {
        Onclick();
        Lol();
    }
    
   
}
