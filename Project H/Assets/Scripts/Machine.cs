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
    public Transform dropPoint;

    bool isChickenCursed;
    GameObject chickenToDetect;
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
            if (isMachineActivate)
            {
                chickenToDetect = pickUpAndDrop.objPicked;
                StartCoroutine(CheckIfCursedOrNot());
            }
            else
            {
                Debug.Log("Please activate machine first");
            }
        }
        else
        {
            Debug.Log("None of the above");
        }
    }

    private IEnumerator CheckIfCursedOrNot()
    {
        Debug.Log("Checking if the dead chicken is cursed...");
        yield return new WaitForSeconds(5);

        SpawnChicken();
    }

    private void SpawnChicken()
    {
        Debug.Log("Spawning a chicken...");
        if(chickenToDetect != null)
        {
            if(chickenToDetect.name == "DeadCursedChickens(Clone)")
            {
                pickUpAndDrop.objPicked.transform.position = dropPoint.position;
                pickUpAndDrop.objPicked.SetActive(true);
                pickUpAndDrop.objPicked.tag = "DeadCursedChicken";
                pickUpAndDrop.objPicked = null;
                pickUpAndDrop.isPicked = false;
                Debug.Log("Dropped");
            }else if(chickenToDetect.name == "NormalCursedChickens(Clone)")
            {
                Debug.Log("Your Chicken is normal");
            }
            else
            {
                Debug.Log("What is this....");
            }
        }
        else
        {
            Debug.Log("Hello");
        }
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
