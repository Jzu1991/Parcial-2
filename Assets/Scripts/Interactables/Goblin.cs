using UnityEngine;

public class Goblin : Enemy
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