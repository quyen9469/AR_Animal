using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GoogleARCore.Examples.ObjectManipulation
{
    public class Snail : MonoBehaviour
    {
        public GameObject prefab;
        public void setAnim()
        {
            AnimalStatus.AnimalPosition = 17;
            PawnManipulator.PawnPrefab = prefab;
        }
    }
}
