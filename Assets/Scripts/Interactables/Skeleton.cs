using UnityEngine;

public class Skeleton : Enemy
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