using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PoisionBox : MonoBehaviour
{
    public bool isPoisioned;
    public PickUpAndDrop pickUpAndDrop;

    private void Start()
    {
        isPoisioned = false;
    }
    public void interactWithPoision()
    {
        if (!isPoisioned)
        {
            if (pickUpAndDrop.objPicked != null && pickUpAndDrop.objPicked.tag == "PoisionBag")
            {
                isPoisioned = true;
                pickUpAndDrop.objPicked = null;
                pickUpAndDrop.isPicked = false;
            }
            else
            {
                Debug.Log("Iski bhen ki maje maje");
            }
        }
        else
        {
            if (pickUpAndDrop.objPicked != null && pickUpAndDrop.objPicked.tag == "DeadCursedChicken")
            {
                pickUpAndDrop.objPicked.tag = "PoisionedDeadCursedChicken";
            }
        }
    }
}
