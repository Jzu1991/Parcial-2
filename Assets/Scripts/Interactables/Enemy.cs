using UnityEngine;

public class Enemy : TempleObject
{
    public int health = 100;

    public override void Interact()
    {

        Debug.Log("¡Un enemigo te ataca!");

    }

    // Herencia: Hereda de TempleObject //

    // Polimorfismo: Interact() y Attack() pueden ser sobrescritos por subclases //

    // Abstracción: Define comportamiento genérico de un enemigo //

    public virtual void Attack()
    {

        Debug.Log("El enemigo ataca.");

    }
}
