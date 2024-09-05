using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildMotherBoard : MonoBehaviour { 
    [SerializeField] private GameObject canvasObj;
    [SerializeField] private TextMeshProUGUI text;

    bool isHover = false;
    bool isSelect = false;

    private bool procIsEnter = false;
    private bool cpu_FanIsEnter = false;
    private bool lRamIsEnter = false;
    private bool rRamIsEnter = false;
    private bool videoCardIsEnter = false;

    private void Start() {
        canvasObj.SetActive(false);
    }

    public void SetHoverEnter() {
        isHover = true;
    }

    public void SetHoverExit() {
        isHover = false;
    }

    public void SetSelect() {
        isSelect = true;
    }

    public void SetSelectExit() {
        isSelect = false;
    }

    // Pc Parts logic
    // --------------------<>--------------------
    // --Proc
    public void ProcIsEnter()
    {
        procIsEnter = true;
    }

    public void ProcIsExit()
    {
        procIsEnter = false;
    }
    
    // --CPU_Fan
    public void Cpu_FanIsEnter()
    {
        cpu_FanIsEnter = true;
    }

    public void CpuFanIsExit()
    {
        cpu_FanIsEnter = false;
    }

    // --LRam
    public void LRamIsEnter()
    {
        lRamIsEnter = true;
    }

    public void LRamIsExit()
    {
        lRamIsEnter = false;
    }

    // --RRam
    public void RRamIsEnter()
    {
        rRamIsEnter = true;
    }

    public void RRamIsExit()
    {
        rRamIsEnter = false;
    }

    // --VideoCard
    public void VideoCardIsEnter()
    {
        videoCardIsEnter = true;
    }

    public void VideoCardIsExit()
    {
        videoCardIsEnter = false;
    }


    // Canvas Logic
    public void HoverAndSelect() {
        if (isHover && !isSelect) {
            canvasObj.SetActive(true);
        }
        else {
            canvasObj.SetActive(false);
        }
    }

    public void ChengeText() {
        text.text = "Материнская плата. <Процессор Установлен!>";
    }

    private void FixedUpdate()
    {
        IsAllPartsInPc();
    }

    public bool IsAllPartsInPc()
    {
        if (procIsEnter && cpu_FanIsEnter && (lRamIsEnter || rRamIsEnter) && videoCardIsEnter)
        {
            return true;
        }
        else 
            return false;

    }
}
