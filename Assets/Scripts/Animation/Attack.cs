using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

   
    public void setAttack()
    {
        AnimalStatus.NumberAnimation = 1;
        //StartCoroutine(AttackRoutime());
        
    }
    IEnumerator AttackRoutime()
    {
        animator.SetInteger("checkBear", 4);
        yield return new WaitForSeconds(5);
        animator.SetInteger("checkBear", 5);
    }
}
