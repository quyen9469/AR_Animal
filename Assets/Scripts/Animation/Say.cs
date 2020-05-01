using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Say : MonoBehaviour
{
    public AudioSource BearSay;
    public AudioSource CattleSay;
    public AudioSource ChickenSay;
    public AudioSource CrocodileSay;
    public AudioSource DeerSay;
    public AudioSource SalamanderSay;
    public AudioSource GoatSay;
    public AudioSource IbexSay;
    public AudioSource PigSay;
    public AudioSource OctopusSay;
    public AudioSource PerchSay;
    public AudioSource PikeSay;
    public AudioSource RabbitSay;
    public AudioSource RatSay;
    public AudioSource SalmonSay;
    public AudioSource SharkSay;
    public AudioSource SnailSay;
    public AudioSource SwanGooseSay;
    public AudioSource BoarSay;
    public AudioSource WolfSay;
    AudioSource audioData;

    public void setSay()
    {


        switch (AnimalStatus.AnimalPosition)
        {
            case 1:
                audioData = BearSay;
                break;
            case 2:
                audioData = CattleSay;
                break;
            case 3:
                audioData = ChickenSay;
                break;
            case 4:
                audioData = CrocodileSay;
                break;
            case 5:
                audioData = DeerSay;
                break;
            case 6:
                audioData = SalamanderSay;
                break;
            case 7:
                audioData = GoatSay;
                break;
            case 8:
                audioData = IbexSay;
                break;
            case 9:
                audioData = PigSay;
                break;
            case 10:
                audioData = OctopusSay;
                break;
            case 11:
                audioData = PerchSay;
                break;
            case 12:
                audioData = PikeSay;
                break;
            case 13:
                audioData = RabbitSay;
                break;
            case 14:
                audioData = RatSay;
                break;
            case 15:
                audioData = SalmonSay;
                break;
            case 16:
                audioData = SharkSay;
                break;
            case 17:
                audioData = SnailSay;
                break;
            case 18:
                audioData = SwanGooseSay;
                break;
            case 19:
                audioData = BoarSay;
                break;
            case 20:
                audioData = WolfSay;
                break;
            default:
                audioData = ChickenSay;
                break;
        }
        //audioData = GetComponent<AudioSource>();
        audioData.Play();
        Debug.Log("PlaySay" + AnimalStatus.AnimalPosition);
    }
}
