using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc : MonoBehaviour
{
    string heroName = "sunny";
    int heroPower = 1;
    string villainName = "omori";
    int villainPower = 10000;
    float playerSpeed = 9.8f;
    // Start is called before the first frame update
    void Start()
    {
        if (villainPower > heroPower) 
        {
            print("omori will not succumb");
        }
        else if (villainPower < heroPower)
        {
            print("GAME OVER");
        }

        SetSpeed(2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetSpeed (float newSpeed)
    {
      
        print ("old speed is" + playerSpeed);
        playerSpeed = newSpeed;
        print("new speed is" + playerSpeed);

    }

}
