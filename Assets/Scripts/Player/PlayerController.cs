using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {

        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(moveX, 0, moveZ) * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.E))
        {

            Interact();

        }

    }

    // Polimorfismo: El jugador interactúa sin importar qué tipo de objeto sea(cofre, trampa, puerta) gracias a la interfaz IInteractable //

    // Abstracción: No necesita saber detalles internos del objeto con el que interactúa //

    void Interact()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 2f))
        {

            IInteractable interactable = hit.collider.GetComponent<IInteractable>();
            if (interactable != null)
            {

                interactable.Interact();

            }

        }

    }

}
