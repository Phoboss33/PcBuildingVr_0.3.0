using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PSUSocket : MonoBehaviour
{
    public StatePC statePC;
    private XRSocketInteractor interactor;

    private void Start()
    {
        interactor = GetComponent<XRSocketInteractor>();
    }
    private void FixedUpdate()
    {
        GetSelectedObject();
    }

    private void GetSelectedObject()
    {
        if (interactor.hasSelection)
        {
            var selectedObj = interactor.selectTarget;

            if (selectedObj != null)
            {
                statePC._psuText.text = "Блок питания: <color=green>Есть</color>";
                statePC.isPsu = true;
            }
        }
        else
        {
            statePC._psuText.text = "Блок питания: <color=red>Отсутствует</color>";
            statePC.isPsu = false;
        }
    }
}
