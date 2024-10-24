using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideTipsLogic : MonoBehaviour
{
    public GameObject handler;
    
    private bool canShow;

    private void Start()
    {
        handler.SetActive(false);
        canShow = true;
    }

    public void _Show()
    {
        if (canShow)
        {
            handler.SetActive(true);
        }
    }

    public void _Hide()
    {
        handler.SetActive(false);
    }

    public void _Select()
    {
        canShow = false;
        _Hide();
    }
    public void _UnSelect()
    {
        canShow = true;
    }
}
