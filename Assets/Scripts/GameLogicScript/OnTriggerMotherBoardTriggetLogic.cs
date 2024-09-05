using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerMotherBoardTriggetLogic : MonoBehaviour
{
    public InCaseLogic inCaseLogicScript;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("MotherBoard"))
        {
            inCaseLogicScript.IsAllPartInPlace(other.gameObject.GetComponent<BuildMotherBoard>().IsAllPartsInPc());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("MotherBoard"))
            inCaseLogicScript.IsAllPartInPlace(false);
    }
}
