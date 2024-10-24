using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SSDSocket : MonoBehaviour
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
                statePC._ssdText.text = "Твердотельный накопитель: <color=green>Есть</color>";
                statePC.isSsd = true;
            }
        }
        else
        {
            statePC._ssdText.text = "Твердотельный накопитель: <color=red>Отсутствует</color>";
            statePC.isSsd = false;
        }
    }
}
