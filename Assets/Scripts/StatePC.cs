using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatePC : MonoBehaviour
{
    public TextMeshProUGUI _canTurnText;
    public TextMeshProUGUI _motherText;
    public TextMeshProUGUI _procText;
    public TextMeshProUGUI _videoCardText;
    public TextMeshProUGUI _ssdText;
    public TextMeshProUGUI _leftDramText;
    public TextMeshProUGUI _rightDramText;
    public TextMeshProUGUI _psuText;
    public TextMeshProUGUI _coolerText;

    public bool isMother = false;
    public bool isProc = false;
    public bool isVideoCard = false;
    public bool isSsd = false;
    public bool isLRam = false;
    public bool isRRam = false;
    public bool isPsu = false;
    public bool isCooler = false;


    private void Start()
    {
        _canTurnText.text += " <color=red>Нет, требуется установить комлектующие</color>";
        _motherText.text += " <color=red>Отсутствует </color>";
        _procText.text += " <color=red>Отсутствует </color>";
        _videoCardText.text += " <color=red>Отсутствует </color>";
        _ssdText.text += " <color=red>Отсутствует</color>";
        _leftDramText.text += " <color=red>Отсутствует </color>";
        _rightDramText.text += " <color=red>Отсутствует </color>";
        _psuText.text += " <color=red>Отсутствует</color>";
        _coolerText.text += " <color=red>Отсутствует</color>";      
    }

    private void FixedUpdate()
    {
        if (isMother && isProc && isVideoCard && isSsd && (isLRam || isRRam) && isPsu && isCooler)
        {
            _canTurnText.text = "Можно включать? <color=green>Да</color>";
        }
        else if (isMother && isProc && isVideoCard && isSsd && (isLRam || isRRam) && isPsu)
        {
            _canTurnText.text = "Можно включать? <color=red>Да, но процессор будет перегреваться</color>";
        }
        else
        {
            _canTurnText.text = "Можно включать? <color=red>Нет, требуется установить все комлектующие</color>";
        }
    }
}
