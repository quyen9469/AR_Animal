using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GoogleARCore.Examples.ObjectManipulation
{
    public class Bear : MonoBehaviour
    {
        public GameObject bearPrefab;
        public void setAnim()
        {
            AnimalStatus.AnimalPosition = 1;
            PawnManipulator.PawnPrefab = bearPrefab;
        }
    }
}
