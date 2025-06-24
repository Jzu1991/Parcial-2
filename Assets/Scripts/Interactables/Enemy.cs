using UnityEngine;

public class Enemy : TempleObject
{
    public int health = 100;

    public override void Interact()
    {

        Debug.Log("¡Un enemigo te ataca!");

    }

    public virtual void Attack()
    {

        Debug.Log("El enemigo ataca.");

    }
}
