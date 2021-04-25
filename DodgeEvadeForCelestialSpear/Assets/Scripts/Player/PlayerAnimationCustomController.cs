using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationCustomController : MonoBehaviour
{

    public PlayerMovement playerMovementScriptReference;
    public PlayerDodge playerDodgeScriptReference;

    public Animator myAnimator;

    public string currentState;
    
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
}
