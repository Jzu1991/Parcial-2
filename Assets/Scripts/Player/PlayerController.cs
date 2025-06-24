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
