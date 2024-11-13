
using UnityEngine;

public abstract class Base : MonoBehaviour , DamageInterface
{
     [SerializeField] public int health;
     [SerializeField] public int attack;
    [SerializeField]  public int defense;
    [SerializeField]  public float speed;


    protected abstract void Hello();
    protected abstract void Randomy();
    public void Attack(int attack)
    {
       
    }
}
