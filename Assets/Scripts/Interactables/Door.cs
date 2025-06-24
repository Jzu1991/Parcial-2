using UnityEngine;

public class Door : TempleObject

    // Herencia: Desde TempleObject //

    // Polimorfismo: Comportamiento �nico de Interact() //

    // L�gica condicional: Decide si la puerta se abre o no seg�n isLocked //
{
    public bool isLocked = true;

    private void OnCollisionEnter(Collision collision)
    {

        Interact();

    }
    public override void Interact()
    {
        if (isLocked)
            Debug.Log("La puerta est� cerrada.");
        else
            Debug.Log("Has abierto la puerta.");
    }
}
