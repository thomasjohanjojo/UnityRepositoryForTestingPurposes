using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDodge : MonoBehaviour
{

    public float dodgeSpeed;
    public float thatMillisecondsOfTimeAfterWhichTheDodgeActuallyHappens;

    public Rigidbody2D myRigidbody2D;
    public BoxCollider2D myBoxCollider2D;

    public float playerFacingDirection;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        myBoxCollider2D = gameObject.GetComponent<BoxCollider2D>();
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
            StartCoroutine(waitBeforeDodging());
           
            
            
        }

        else
        {
            transform.Translate(0f, 0f, 0f);
            myBoxCollider2D.enabled = true;
            myRigidbody2D.gravityScale = 1;
        }
    }

    IEnumerator waitBeforeDodging()
    {
        yield return new WaitForSeconds(thatMillisecondsOfTimeAfterWhichTheDodgeActuallyHappens);
        TurnOffColliderAndGravityAndDoTheDodge();
        
    }

    void TurnOffColliderAndGravityAndDoTheDodge()
    {
        myRigidbody2D.gravityScale = 0;
        myBoxCollider2D.enabled = false;

        Vector2 forceToAddWhenDodging = new Vector2(dodgeSpeed * playerFacingDirection, 0f);
        myRigidbody2D.AddForce(forceToAddWhenDodging, ForceMode2D.Impulse);

        Debug.Log("Entered co routine");
    }
}
