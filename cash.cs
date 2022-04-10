using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cash : MonoBehaviour
{
    public int money;
    // Start is called before the first frame update
    void Start()
    {
        money = 0;     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // methods for updating or subtracking cash flow
    // can call this outside of the script
    public void addMoney(int moneyToAdd)
    {
        //take money and add to
        money += moneyToAdd;
    }
    //Subtracts money
    public void subtractMoney(int moneyToSub)
    {
        //no negative amounts 
        if(money - moneyToSub < 0)
        {
        
        }
        else 
        {
            money -= moneyToSub;
        }
    }
}
