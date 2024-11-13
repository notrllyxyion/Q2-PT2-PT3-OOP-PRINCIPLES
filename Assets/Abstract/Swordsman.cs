using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordsman : Base2, DamageInterface
{

    private void Start()
    {
        Onclick();
        Lol();
        Attack(30);

    }
    protected override void Lol()
    {
        Debug.Log("sapakan tayo by Mercenary");
    }

    protected override void Onclick()
    {
        Debug.Log("Swordsman wants to kill Mercenary pero NABAWI! ");
    }



    public void Attack(int attack)
    {
        Debug.Log("Swordsman Health: " + Health);
        Health -= attack;
        Debug.Log("Swordsman Health attacked : " + Health);
    }

}
