using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalManager : MonoBehaviour
{
    private GameObject prefab;

    public GameObject getPrefab()
    {
        return prefab;
    }
    public void setPrefab(GameObject animalPrefab)
    {
        this.prefab = animalPrefab;
    }
}
