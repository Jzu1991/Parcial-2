using UnityEngine;

public class Door : TempleObject
{
    public bool isLocked = true;

    private void OnCollisionEnter(Collision collision)
    {

        Interact();

    }
    public override void Interact()
    {
        if (isLocked)
            Debug.Log("La puerta está cerrada.");
        else
            Debug.Log("Has abierto la puerta.");
    }
}
