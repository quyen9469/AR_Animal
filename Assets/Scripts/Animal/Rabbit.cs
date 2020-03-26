using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GoogleARCore.Examples.ObjectManipulation
{
    public class Rabbit : MonoBehaviour
    {
        public GameObject prefab;
        public void setAnim()
        {
            AnimalStatus.AnimalPosition = 13;
            PawnManipulator.PawnPrefab = prefab;
        }
    }
}