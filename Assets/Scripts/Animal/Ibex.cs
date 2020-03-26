using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GoogleARCore.Examples.ObjectManipulation
{
    public class Ibex : MonoBehaviour
    {
        public GameObject prefab;
        public void setAnim()
        {
            AnimalStatus.AnimalPosition = 8;
            PawnManipulator.PawnPrefab = prefab;
        }
    }
}
