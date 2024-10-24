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
                    statePC._motherText.text = "Материнская плата: <color=green>Есть</color>";
                    statePC.isMother = true;

                    if (motherboard.isVideoCard)
                    {
                        statePC._videoCardText.text = "Видеокарта: <color=green>Есть</color>";
                        statePC.isVideoCard = true;
                    }
                    else
                    {
                        statePC._videoCardText.text = "Видеокарта: <color=red>Отсутствует</color>";
                        statePC.isVideoCard = false;
                    }


                    if (motherboard.isProc)
                    {
                        statePC._procText.text = "Процессор: <color=green>Есть</color>";
                        statePC.isProc = true;
                    }
                    else
                    {
                        statePC._procText.text = "Процессор: <color=red>Отсутствует</color>";
                        statePC.isProc = false;
                    }


                    if (motherboard.isCooler)
                    {
                        statePC._coolerText.text = "Кулер для процессора: <color=green>Есть</color>";
                        statePC.isCooler = true;
                    }
                    else
                    {
                        statePC._coolerText.text = "Кулер для процессора: <color=red>Отсутствует</color>";
                        statePC.isCooler = false;
                    }

                    if (motherboard.isLeftRam)
                    {
                        statePC._leftDramText.text = "Левая плашка оперативной памяти: <color=green>Есть</color>";
                        statePC.isLRam = true;
                    }
                    else
                    {
                        statePC._leftDramText.text = "Левая плашка оперативной памяти: <color=red>Отсутствует</color>";
                        statePC.isLRam = false;
                    }

                    if (motherboard.isRightRam)
                    {
                        statePC._rightDramText.text = "Правая плашка оперативной памяти: <color=green>Есть</color>";
                        statePC.isRRam = true;
                    }
                    else
                    {
                        statePC._rightDramText.text = "Правая плашка оперативной памяти: <color=red>Отсутствует</color>";
                        statePC.isRRam = false;
                    }
                }
                
            }
        }
        else
        {
            statePC._motherText.text = "Материнская плата: <color=red>Отсутствует</color>";
            statePC._videoCardText.text = "Видеокарта: <color=red>Отсутствует</color>";
            statePC._procText.text = "Процессор: <color=red>Отсутствует</color>";
            statePC._coolerText.text = "Кулер для процессора: <color=red>Отсутствует</color>";
            statePC._leftDramText.text = "Левая плашка оперативной памяти: <color=red>Отсутствует</color>";
            statePC._rightDramText.text = "Правая плашка оперативной памяти: <color=red>Отсутствует</color>";

            statePC.isMother = false;
            statePC.isCooler = false;
            statePC.isRRam = false;
            statePC.isLRam = false;
            statePC.isVideoCard = false;
            statePC.isProc = false;
        }
    }
}
