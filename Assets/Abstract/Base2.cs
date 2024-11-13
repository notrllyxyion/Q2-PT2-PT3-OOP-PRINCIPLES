using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Base2 : MonoBehaviour
{
    [SerializeField] public int Health;
    [SerializeField] private int Mana;
    [SerializeField] private int ATtack;
    [SerializeField] private int Defense;
    [SerializeField] private float Speed;
    [SerializeField] private float Luck;

    protected abstract void Onclick();
    protected abstract void Lol();
    
}
