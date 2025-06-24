using UnityEngine;


public abstract class TempleObject : MonoBehaviour, IInteractable
{
    public abstract void Interact();

}

// Abstracción: Al ser abstracta, obliga a las clases hijas a implementar Interact() sin definir su comportamiento exacto aquí //

// Polimorfismo: Usa la interfaz IInteractable para que todas las subclases se puedan tratar de forma uniforme //