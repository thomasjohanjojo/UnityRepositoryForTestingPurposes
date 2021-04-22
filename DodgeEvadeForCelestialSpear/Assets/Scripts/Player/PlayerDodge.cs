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

        
        if(gameObject.transform.rotation.y == 0)
        {
            playerFacingDirection = 1; // 1 means right
            
        }
         else if(gameObject.transform.rotation.y == -1)
        {
            playerFacingDirection = -1;
            
        }

        if(Input.GetKeyDown((KeyCode.LeftShift)) == true)
        {
            // move player in the facing direction for a distance then stop
            // save starting point, then calculate distance with current point as absolute value, then stop if distance exceeded

           // Transform.translate(dodgeSpeed * Time.deltaTime * facing side)
        }
    }
}
