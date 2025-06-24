using UnityEngine;

public class Chest : TempleObject
{

    private bool isOpen = false;
    private string content = "Una gema brillante";

    public bool IsOpen
    {

        get { return isOpen; }
        private set { isOpen = value; }

    }

    private void OnCollisionEnter(Collision collision)
    {

        Interact();

    }

    // Encapsulamiento: Usa campos privados y propiedades(IsOpen) con control de acceso //

    // Herencia + Polimorfismo: Hereda de TempleObject e implementa Interact() con su lógica //

    public override void Interact()
    {
        if (!IsOpen)
        {
            isOpen = true;
            Debug.Log("Has abierto el cofre y encontraste: " + content);

        }
        else
        {

            Debug.Log("El cofre ya está vacío.");

        }
    }
}
