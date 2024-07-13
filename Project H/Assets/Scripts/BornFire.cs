using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BornFire : MonoBehaviour
{
    public bool isActivated;
    public GameObject nonActivateObject;
    public GameObject ActivatedObject;
    public PickUpAndDrop pickUpAndDrop;
    public GameManager manager;

    // Start is called before the first frame update
    void Start()
    {
        isActivated = false;
    }
    private void Update()
    {
        nonActivateObject.SetActive(!isActivated);
        ActivatedObject.SetActive(isActivated);
    }

    public void interactWithBornfire()
    {
        if (isActivated)
        {
            if (pickUpAndDrop.objPicked != null && pickUpAndDrop.objPicked.tag == "PoisionedDeadCursedChicken")
            {
                if (!manager.isGameOver)
                {
                    if (manager.numberOfCursedChickenBurned < manager.numberOfRequiredChicken)
                    {
                        manager.numberOfCursedChickenBurned += 1;
                        pickUpAndDrop.objPicked = null;
                        pickUpAndDrop.isPicked = false;
                    }
                    if(manager.numberOfCursedChickenBurned == manager.numberOfRequiredChicken)
                    {
                        manager.isGameOver = true;
                        manager.isWin = true;
                        pickUpAndDrop.objPicked = null;
                        pickUpAndDrop.isPicked = false;
                    }
                }
            }
            {

            }
        }
        else
        {
            if (pickUpAndDrop.objPicked != null && pickUpAndDrop.objPicked.tag == "MatchBox")
            {
                isActivated=true;
                pickUpAndDrop.objPicked = null;
                pickUpAndDrop.isPicked = false;
                Debug.Log("BornFire Fired....");
            }
            else
            {
                Debug.Log("Please bring matchbox and flame bornfire...");
            }
        }
    }
}
