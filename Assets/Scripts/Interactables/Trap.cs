using UnityEngine;

public class Trap : TempleObject
{
    private void OnCollisionEnter(Collision collision)
    {

        Interact();

    }
    public override void Interact()
    {

        Debug.Log("¡Has activado una trampa!");

    }
}
