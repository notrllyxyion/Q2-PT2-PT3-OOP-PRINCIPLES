using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class Swordsman : Base2, DamageInterface
{
    protected override void Lol()
    {
        print("sapakan tayo by swordsman");
    }

    protected override void Onclick()
    {
        print("Swordsman wants to make sapakan");
    }

    private void Start()
    {
        Onclick();
        Lol();
        Debug.Log("Health: " + Health);
    }
    public void Damage(int damage)
    {
        Debug.Log("Swordsman Health: " + Health);
        Health -= damage;
        Debug.Log("Swordsman health: " + Health);


    }

}
