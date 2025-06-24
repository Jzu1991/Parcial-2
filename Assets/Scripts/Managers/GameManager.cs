using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject goblinPrefab;
    public GameObject skeletonPrefab;
    public GameObject chestPrefab;

    // Abstracción + polimorfismo: Puede instanciar cualquier objeto que derive de TempleObject e implemente IInteractable //

    // Diseño dinámico: Flexibilidad para crear objetos en tiempo de ejecución //

    void Start()
    {

        Instantiate(goblinPrefab, new Vector3(-3, 1, 4), Quaternion.identity);
        Instantiate(skeletonPrefab, new Vector3(3, 1, 4), Quaternion.identity);
        Instantiate(chestPrefab, new Vector3(3, 1, 16), Quaternion.identity);

    }
}
