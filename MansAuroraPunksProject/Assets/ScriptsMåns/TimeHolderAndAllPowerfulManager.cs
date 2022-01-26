using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeHolderAndAllPowerfulManager : MonoBehaviour
{
    float timer = 0;
    float maxTime = 5;
    // Update is called once per frame
    void Update()
    {


        if (Time.timeScale < 1f)
        {
            timer += Time.deltaTime;
            if (timer > maxTime)
            {

                Time.timeScale = 1f;
                timer = 0;
            }


        }


    }
}
