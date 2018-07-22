using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
  /*  Animator animator;//You may not need an animator, but if so declare it here   

    int noOfClicks; //Determines Which Animation Will Play
    bool canClick; //Locks ability to click during animation event

    void Start()
    {
        //Initialize appropriate components
        animator = GetComponent<Animator>();

        noOfClicks = 0;
        canClick = true;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { ComboStarter(); }
    }

    void ComboStarter()
    {
        if (canClick)
        {
            noOfClicks++;
        }

        if (noOfClicks == 1)
        {
            animator.SetInteger("slash1 1", 1);
        }
    }

    public void ComboCheck()
    {

        canClick = false;

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("1HAttack") && noOfClicks == 1)
        {//If the first animation is still playing and only 1 click has happened, return to idle
            animator.SetInteger("slash1 1", 4);
            canClick = true;
            noOfClicks = 0;
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("1HAttack") && noOfClicks >= 2)
        {//If the first animation is still playing and at least 2 clicks have happened, continue the combo          
            animator.SetInteger("slash1 1", 2);
            canClick = true;
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("1HAttack 0") && noOfClicks == 2)
        {  //If the second animation is still playing and only 2 clicks have happened, return to idle         
            animator.SetInteger("slash1 1", 4);
            canClick = true;
            noOfClicks = 0;
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("1HAttack 0") && noOfClicks >= 3)
        {  //If the second animation is still playing and at least 3 clicks have happened, continue the combo         
            animator.SetInteger("slash1 1", 3);
            canClick = true;
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("2HAttack3"))
        { //Since this is the third and last animation, return to idle          
            animator.SetInteger("slash1 1", 4);
            canClick = true;
            noOfClicks = 0;
        }
    }

*/


}
