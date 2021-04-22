using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDodge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown((KeyCode.LeftShift)) == true)
        {
            // move player in the facing direction for a distance then stop
            // save starting point, then calculate distance with current point as absolute value, then stop if distance exceeded

           // Transform.translate(10 * Time.deltaTime * facing side)
        }
    }
}
