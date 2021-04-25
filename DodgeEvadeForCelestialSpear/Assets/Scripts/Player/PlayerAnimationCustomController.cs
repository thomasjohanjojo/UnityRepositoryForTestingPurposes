using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationCustomController : MonoBehaviour
{

    public PlayerMovement playerMovementScriptReference;
    public PlayerDodge playerDodgeScriptReference;

    public Animator myAnimator;

    public string currentState;

    public const string IDLE = "Idle";
    public const string RUNNING = "Running";
    public const string HOLDBEFOREDODGE = "HoldBeforeDodge";
    public const string DODGE = "Dodge";
    
    // Start is called before the first frame update
    void Start()
    {
        playerDodgeScriptReference = GetComponent<PlayerDodge>();
        playerMovementScriptReference = GetComponent<PlayerMovement>();
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animationTransitionLogicControllerFunction();
    }

    void ChangeAnimationState(string newState)
    {
        if(newState == currentState)
        {
            return;
        }

        else
        {
            myAnimator.Play(newState);

            currentState = newState;
        }

    }

   void animationTransitionLogicControllerFunction()
    {
        if(playerMovementScriptReference.isMoving == true && playerMovementScriptReference.playerHorizontalInputValue != 0f)
        {
            ChangeAnimationState(RUNNING);
        }

        if(playerDodgeScriptReference.HoldBeforeTheDodge == true)
        {
            ChangeAnimationState(HOLDBEFOREDODGE);
        }

        else if (playerDodgeScriptReference.DoTheDodge == true)
        {
            ChangeAnimationState(DODGE);
        }

        else if(playerMovementScriptReference.isMoving == false) // here idle has the potential to override hold before dodge and dodge therefore it is kept as an else if AFTER the other two
        {
            ChangeAnimationState(IDLE);
        }

        
    }
}
