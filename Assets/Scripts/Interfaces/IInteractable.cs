using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

// Abstracción: Define una interfaz común para todos los objetos interactuables. No se preocupa de cómo se implementa Interact(), solo de que exista //

public interface IInteractable
{
    void Interact();

}
