using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPickups : MonoBehaviour
{

    public GameObject[] collectiblePrefabArray;

    // Start is called before the first frame update
    void Start()
    {
        try
        {
            Instantiate(collectiblePrefabArray[Random.Range(0, 3)], transform.position, transform.rotation);
            throw new UnassignedReferenceException("Objects not spawning." + name + "Not able to continue.");
        }

        finally
        {
            Debug.Log("Objects are placed. You can continue.");
        }
    }
}
