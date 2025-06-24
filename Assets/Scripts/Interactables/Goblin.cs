using UnityEngine;

public class Goblin : Enemy

    // Herencia: Hereda de Enemy //

    // Polimorfismo: Sobrescribe Attack() con un comportamiento específico del goblin //
{
    private void OnCollisionEnter(Collision collision)
    {

        Attack();

    }

    public override void Attack()
    {

        Debug.Log("¡El goblin lanza una piedra!");

    }
}