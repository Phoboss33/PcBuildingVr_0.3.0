using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildMotherBoard : MonoBehaviour { 
    [SerializeField] private GameObject canvasObj;
    [SerializeField] private TextMeshProUGUI text;

    bool isHover = false;
    bool isSelect = false;
    

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
}
