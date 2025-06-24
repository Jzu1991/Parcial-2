using UnityEngine;

public class Door : TempleObject

    // Herencia: Desde TempleObject //

    // Polimorfismo: Comportamiento único de Interact() //

    // Lógica condicional: Decide si la puerta se abre o no según isLocked //
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
