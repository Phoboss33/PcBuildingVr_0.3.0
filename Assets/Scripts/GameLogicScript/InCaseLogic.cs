using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InCaseLogic : MonoBehaviour
{
    private bool isPsuEnter = false;
    private bool isMotherBoardEnter = false;
    private bool isSsdEnter = false;
    private bool motherBoardAllPlace= false;


    public TextMeshProUGUI text;
    // PSU
    public void IsPsuEnter()
    {
        isPsuEnter = true;
    }
    public void IsPsuExit()
    {
        isPsuEnter = false;
    }

    // MotherBoard
    public void IsMotherBoardEnter()
    {
        isMotherBoardEnter = true;
    }
    public void IsMotherBoardEXit()
    {
        isMotherBoardEnter = false;
    }
    

    // SSD
    public void IsSsdEnter()
    {
        isSsdEnter = true;
    }
    public void IsSsdExit()
    {
        isSsdEnter = false;
    }


    // TurnOn logic
    public void TurnOnLogic()
    {
        
    }

    public void IsAllPartInPlace(bool motherBoardIsAllPartsInPlace)
    {
        motherBoardAllPlace = motherBoardIsAllPartsInPlace;
    }

    private void FixedUpdate()
    {
        if (motherBoardAllPlace && isPsuEnter && isSsdEnter)
        {
            text.text = "Success";
        }
        else
        {
            text.text = "No";
        }
    }

}
