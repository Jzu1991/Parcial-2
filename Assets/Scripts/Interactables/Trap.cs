using UnityEngine;

public class Trap : TempleObject

    // Herencia: Hereda de TempleObject //

    // Polimorfismo: Implementa Interact() con su propio comportamiento //

    // Abstracción: No necesitas saber qué tipo de objeto es para llamarlo por Interact() //

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
