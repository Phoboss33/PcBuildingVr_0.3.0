using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class InSocket : MonoBehaviour
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
                MotherBoardSockets motherboard = selectedObj.GetComponent<MotherBoardSockets>();
                if (motherboard != null)
                {
                    statePC._motherText.text = "����������� �����: <color=green>����</color>";
                    statePC.isMother = true;

                    if (motherboard.isVideoCard)
                    {
                        statePC._videoCardText.text = "����������: <color=green>����</color>";
                        statePC.isVideoCard = true;
                    }
                    else
                    {
                        statePC._videoCardText.text = "����������: <color=red>�����������</color>";
                        statePC.isVideoCard = false;
                    }


                    if (motherboard.isProc)
                    {
                        statePC._procText.text = "���������: <color=green>����</color>";
                        statePC.isProc = true;
                    }
                    else
                    {
                        statePC._procText.text = "���������: <color=red>�����������</color>";
                        statePC.isProc = false;
                    }


                    if (motherboard.isCooler)
                    {
                        statePC._coolerText.text = "����� ��� ����������: <color=green>����</color>";
                        statePC.isCooler = true;
                    }
                    else
                    {
                        statePC._coolerText.text = "����� ��� ����������: <color=red>�����������</color>";
                        statePC.isCooler = false;
                    }

                    if (motherboard.isLeftRam)
                    {
                        statePC._leftDramText.text = "����� ������ ����������� ������: <color=green>����</color>";
                        statePC.isLRam = true;
                    }
                    else
                    {
                        statePC._leftDramText.text = "����� ������ ����������� ������: <color=red>�����������</color>";
                        statePC.isLRam = false;
                    }

                    if (motherboard.isRightRam)
                    {
                        statePC._rightDramText.text = "������ ������ ����������� ������: <color=green>����</color>";
                        statePC.isRRam = true;
                    }
                    else
                    {
                        statePC._rightDramText.text = "������ ������ ����������� ������: <color=red>�����������</color>";
                        statePC.isRRam = false;
                    }
                }
                
            }
        }
        else
        {
            statePC._motherText.text = "����������� �����: <color=red>�����������</color>";
            statePC._videoCardText.text = "����������: <color=red>�����������</color>";
            statePC._procText.text = "���������: <color=red>�����������</color>";
            statePC._coolerText.text = "����� ��� ����������: <color=red>�����������</color>";
            statePC._leftDramText.text = "����� ������ ����������� ������: <color=red>�����������</color>";
            statePC._rightDramText.text = "������ ������ ����������� ������: <color=red>�����������</color>";

            statePC.isMother = false;
            statePC.isCooler = false;
            statePC.isRRam = false;
            statePC.isLRam = false;
            statePC.isVideoCard = false;
            statePC.isProc = false;
        }
    }
}
