using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AnimalStatus : MonoBehaviour
{
    // Start is called before the first frame update
    public static int AnimalPosition = 1;
    public static int NumberAnimation = 1;
    string animalText;
    string animationText;
    Text animal;
    // Start is called before the first frame update
    void Start()
    {
        animal = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (AnimalPosition)
        {
            case 1:
                animalText = "Bear";
                break;
            case 2:
                animalText = "Cattle";
                break;
            case 3:
                animalText = "Chicken";
                break;
            case 4:
                animalText = "Crocodile";
                break;
            case 5:
                animalText = "Deer";
                break;
            case 6:
                animalText = "Fire Salamander";
                break;
            case 7:
                animalText = "Goat";
                break;
            case 8:
                animalText = "Ibex";
                break;
            case 9:
                animalText = "Iron Age";
                break;
            case 10:
                animalText = "Octopus";
                break;
            case 11:
                animalText = "Perch";
                break;
            case 12:
                animalText = "Pike";
                break;
            case 13:
                animalText = "Rabbit";
                break;
            case 14:
                animalText = "Rat";
                break;
            case 15:
                animalText = "Salmon";
                break;
            case 16:
                animalText = "Shark";
                break;
            case 17:
                animalText = "Snail";
                break;
            case 18:
                animalText = "Swan Goosee";
                break;
            case 19:
                animalText = "Wild Boar";
                break;
            case 20:
                animalText = "Wolf";
                break;
            default:
                animalText = "Bear";
                break;
        }

        switch (NumberAnimation)
        {
            case 1:
                animationText = "Attack";
                break;
            case 2:
                animationText = "Eat";
                break;
            case 3:
                animationText = "Run";
                break;
            case 4:
                animationText = "Walk";
                break;
            default:
                animationText = "Attack";
                break;
        }

        //animal.text = " Animal: " + animalText + " + " + animationText;
        animal.text = " Animal: " + animalText ;
    }

}
