using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GoogleARCore.Examples.ObjectManipulation
{
    public class Crocodile : MonoBehaviour
    {
        public GameObject crocodilePrefab;
        public void setAnim()
        {
            AnimalStatus.AnimalPosition = 4;
            PawnManipulator.PawnPrefab = crocodilePrefab;
        }
    }
}
