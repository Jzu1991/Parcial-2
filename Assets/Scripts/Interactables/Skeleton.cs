using UnityEngine;

public class Skeleton : Enemy

    // Igual que Goblin.cs, aplica herencia y polimorfismo //

{
    private void OnCollisionEnter(Collision collision)
    {

        Attack();

    }
    public override void Attack()
    {

        Debug.Log("¡El esqueleto te lanza un hueso!");

    }
}