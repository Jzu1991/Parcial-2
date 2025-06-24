using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

// Abstracci�n: Define una interfaz com�n para todos los objetos interactuables. No se preocupa de c�mo se implementa Interact(), solo de que exista //

public interface IInteractable
{
    void Interact();

}
