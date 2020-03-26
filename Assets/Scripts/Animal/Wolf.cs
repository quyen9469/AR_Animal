using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GoogleARCore.Examples.ObjectManipulation
{
    public class Wolf : MonoBehaviour
    {
        public GameObject prefab;
        public void setAnim()
        {
            AnimalStatus.AnimalPosition = 20;
            PawnManipulator.PawnPrefab = prefab;
        }
    }
}