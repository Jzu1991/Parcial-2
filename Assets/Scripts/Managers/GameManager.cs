using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject goblinPrefab;
    public GameObject skeletonPrefab;
    public GameObject chestPrefab;

    void Start()
    {

        Instantiate(goblinPrefab, new Vector3(-3, 1, 4), Quaternion.identity);
        Instantiate(skeletonPrefab, new Vector3(3, 1, 4), Quaternion.identity);
        Instantiate(chestPrefab, new Vector3(3, 1, 16), Quaternion.identity);

    }
}
