using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakePlayerInput : MonoBehaviour
{

   public string savedInput;
   public int sizeOfMap;
   public Variables variables;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadInput(string input)
    {

        savedInput = input;
        sizeOfMap = int.Parse(savedInput);
        variables.SaveThisVariable();

    }

}
