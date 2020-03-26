using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GoogleARCore.Examples.ObjectManipulation
{
    public class Deer : MonoBehaviour
    {
        public GameObject deerPrefab;
        public void setAnim()
        {
            AnimalStatus.AnimalPosition = 5;
            PawnManipulator.PawnPrefab = deerPrefab;
        }
    }
}
