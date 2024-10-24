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
        _canTurnText.text += " <color=red>���, ��������� ���������� ������������</color>";
        _motherText.text += " <color=red>����������� </color>";
        _procText.text += " <color=red>����������� </color>";
        _videoCardText.text += " <color=red>����������� </color>";
        _ssdText.text += " <color=red>�����������</color>";
        _leftDramText.text += " <color=red>����������� </color>";
        _rightDramText.text += " <color=red>����������� </color>";
        _psuText.text += " <color=red>�����������</color>";
        _coolerText.text += " <color=red>�����������</color>";      
    }

    private void FixedUpdate()
    {
        if (isMother && isProc && isVideoCard && isSsd && (isLRam || isRRam) && isPsu && isCooler)
        {
            _canTurnText.text = "����� ��������? <color=green>��</color>";
        }
        else if (isMother && isProc && isVideoCard && isSsd && (isLRam || isRRam) && isPsu)
        {
            _canTurnText.text = "����� ��������? <color=red>��, �� ��������� ����� �������������</color>";
        }
        else
        {
            _canTurnText.text = "����� ��������? <color=red>���, ��������� ���������� ��� ������������</color>";
        }
    }
}
