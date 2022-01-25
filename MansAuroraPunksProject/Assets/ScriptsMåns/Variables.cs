using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public TakePlayerInput takePlayerInput;
    public int sizeOfMap;
    public int counter;

    // Start is called before the first frame update
    public void SaveThisVariable()
    {
        sizeOfMap = takePlayerInput.sizeOfMap;
        Debug.Log(sizeOfMap);
        Object.DontDestroyOnLoad(this);
    
    }

    // Update is called once per frame
    public int GiveThisVariable()
    {
        Debug.Log(sizeOfMap);
        return sizeOfMap;

    }


    public void ResetCounter()
    {

        counter = 0;

    }

    public int GetCounter()
    {

        return counter;

    }

}
