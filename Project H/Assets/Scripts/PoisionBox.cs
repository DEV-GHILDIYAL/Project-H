using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisionBox : MonoBehaviour
{
    public bool isPoisioned;
    public PickUpAndDrop pickUpAndDrop;

    private void Start()
    {
        isPoisioned = false;
    }
    public void activateBox()
    {
        if (!isPoisioned && pickUpAndDrop.objPicked != null && pickUpAndDrop.objPicked.tag == "PoisionBag")
        {
            isPoisioned = true;
        }
        else
        {
            Debug.Log("Iski bhen ki maje maje");
        }
    }
}
