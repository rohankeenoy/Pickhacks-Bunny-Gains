using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breadAmt : MonoBehaviour
{
    public int bread;
    // Start is called before the first frame update
    void Start()
    {
        bread = 0;     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // methods for updating or subtracking cash flow
    // can call this outside of the script
    public void addBread(int breadToAdd)
    {
        //take money and add to
        bread += breadToAdd;
    }
    //Subtracts money
    public void subtractBread(int breadToSub)
    {
        //no negative amounts 
        if(bread - breadToSub < 0)
        {
        
        }
        else 
        {
            bread -= breadToSub;
        }
    }
}
