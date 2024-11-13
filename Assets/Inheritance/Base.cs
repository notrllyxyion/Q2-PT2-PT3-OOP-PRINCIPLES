
using UnityEngine;

public class Base : MonoBehaviour 
{
    private int Health;
   [SerializeField] public int Attack;
    private int Defense;
    private float Speed;

  protected void Displaying()
    {
        Debug.Log("akina buhay mo" + Attack);
    }

   
}
