using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GoogleARCore.Examples.ObjectManipulation
{
    public class Cattle : MonoBehaviour
    {
        public GameObject cattlePrefab;
        public void setAnim()
        {
            AnimalStatus.AnimalPosition = 2;
           PawnManipulator.PawnPrefab = cattlePrefab;
        }
    }
}
