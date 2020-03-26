using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GoogleARCore.Examples.ObjectManipulation
{

    public class Chicken : MonoBehaviour
    {
        public GameObject chickenPrefab;
        public void setAnim()
        {
            AnimalStatus.AnimalPosition = 3;
            PawnManipulator.PawnPrefab = chickenPrefab;
        }
    }
}
