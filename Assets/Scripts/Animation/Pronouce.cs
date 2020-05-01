using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pronouce : MonoBehaviour
{
    public AudioSource BearPronouce;
    public AudioSource CattlePronouce;
    public AudioSource ChickenPronouce;
    public AudioSource CrocodilePronouce;
    public AudioSource DeerPronouce;
    public AudioSource SalamanderPronouce;
    public AudioSource GoatPronouce;
    public AudioSource IbexPronouce;
    public AudioSource PigPronouce;
    public AudioSource OctopusPronouce;
    public AudioSource PerchPronouce;
    public AudioSource PikePronouce;
    public AudioSource RabbitPronouce;
    public AudioSource RatPronouce;
    public AudioSource SalmonPronouce;
    public AudioSource SharkPronouce;
    public AudioSource SnailPronouce;
    public AudioSource SwanGoosePronouce;
    public AudioSource BoarPronouce;
    public AudioSource WolfPronouce;
    AudioSource audioData;

    public void setPronouce()
    {
        

        switch (AnimalStatus.AnimalPosition)
        {
            case 1:
                audioData = BearPronouce;
                break;
            case 2:
                audioData = CattlePronouce;
                break;
            case 3:
                audioData = ChickenPronouce;
                break;
            case 4:
                audioData = CrocodilePronouce;
                break;
            case 5:
                audioData = DeerPronouce;
                break;
            case 6:
                audioData = SalamanderPronouce;
                break;
            case 7:
                audioData = GoatPronouce;
                break;
            case 8:
                audioData = IbexPronouce;
                break;
            case 9:
                audioData = PigPronouce;
                break;
            case 10:
                audioData = OctopusPronouce;
                break;
            case 11:
                audioData = PerchPronouce;
                break;
            case 12:
                audioData = PikePronouce;
                break;
            case 13:
                audioData = RabbitPronouce;
                break;
            case 14:
                audioData = RatPronouce;
                break;
            case 15:
                audioData = SalmonPronouce;
                break;
            case 16:
                audioData = SharkPronouce;
                break;
            case 17:
                audioData = SnailPronouce;
                break;
            case 18:
                audioData = SwanGoosePronouce;
                break;
            case 19:
                audioData = BoarPronouce;
                break;
            case 20:
                audioData = WolfPronouce;
                break;
            default:
                audioData = BearPronouce;
                break;
        }
        //audioData = GetComponent<AudioSource>();
        audioData.Play();
        Debug.Log("PlayPronouce" + AnimalStatus.AnimalPosition);
    }
}
