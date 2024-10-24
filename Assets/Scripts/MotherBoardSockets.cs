using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherBoardSockets : MonoBehaviour
{
    [HideInInspector] public bool isProc;
    [HideInInspector] public bool isLeftRam;
    [HideInInspector] public bool isRightRam;
    [HideInInspector] public bool isVideoCard;
    [HideInInspector] public bool isCooler;

    private void Start()
    {
        isProc = false;
        isLeftRam = false;
        isRightRam = false;
        isVideoCard = false;
        isCooler = false;
    }

    public void _isProcSetUp()
    {
        isProc = true;
    }
    public void _isProcRemove()
    {
        isProc = false;
    }
    public void _isLeftSetUp()
    {
        isLeftRam = true;
    }
    public void _isLeftRemove()
    {
        isLeftRam = false;
    }
    public void _isRightSetUp()
    {
        isRightRam = true;
    }
    public void _isRightRemove()
    {
        isRightRam = false;
    }
    public void _isVideoCardSetUp()
    {
        isVideoCard = true;
    }
    public void _isVideoCardRemove()
    {
        isVideoCard = false;
    }
    public void _isCoolerSetUp()
    {
        isCooler = true;
    }
    public void _isCoolerRemove()
    {
        isCooler = false;
    }
}
