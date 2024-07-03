using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Machine : MonoBehaviour
{
    public int collectItem;
    public PickUpAndDrop pickUpAndDrop;
    public bool isMachineActivate;

    private void Start()
    {
        isMachineActivate = false;
    }
    private void Update()
    {
        
    }

    public void interactWithMachine()
    {
        // Check if the player has the required object
        if (pickUpAndDrop.objPicked != null && pickUpAndDrop.objPicked.CompareTag("ObjectToActivateMachine"))
        {
            // Increment the count in the machine script
            ActivateMachine();
        } else if (pickUpAndDrop.objPicked != null && pickUpAndDrop.objPicked.CompareTag("DeadChicken"))
        {
            CheckIfCursedOrNot();
        }
    }

    private void CheckIfCursedOrNot()
    {
        throw new NotImplementedException();
    }

    public void ActivateMachine()
    {
        if(collectItem < 3)
        {
            collectItem++;
            pickUpAndDrop.objPicked = null;
            pickUpAndDrop.isPicked = false;
        }
        if(!isMachineActivate && collectItem == 3)
        {
            isMachineActivate =true;
        }
    }
}
