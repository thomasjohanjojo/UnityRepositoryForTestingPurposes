using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDodge : MonoBehaviour
{

    public float dodgeSpeed;

    public float playerFacingDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        CheckPlayerFacingDirection(); //no use right now
        DodgeUsingTranslate();



    }

    void CheckPlayerFacingDirection()
    {
        if (gameObject.transform.rotation.y == 0)
        {
            playerFacingDirection = 1; // 1 means right

        }
        else if (gameObject.transform.rotation.y == -1)
        {
            playerFacingDirection = -1;

        }
    }


    void DodgeUsingTranslate()
    {

        if (Input.GetKeyDown((KeyCode.LeftShift)) == true)
        {
            transform.Translate(dodgeSpeed * Time.deltaTime, 0f, 0f);
        }

        else
        {
            transform.Translate(0f, 0f, 0f);
        }
    }
}
