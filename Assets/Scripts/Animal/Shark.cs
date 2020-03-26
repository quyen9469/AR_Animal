using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GoogleARCore.Examples.ObjectManipulation
{
    public class Shark : MonoBehaviour
    {
        public GameObject prefab;
        public void setAnim()
        {
            AnimalStatus.AnimalPosition = 16;
            PawnManipulator.PawnPrefab = prefab;
        }
    }
}
