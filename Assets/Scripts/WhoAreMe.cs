using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NamePart {
    motherBoard,
    ram,
    processor,
    cpuCooler,
    videoCard,
    psu,
    ssd
};

public class WhoAreMe : MonoBehaviour
{
    public NamePart part;
}
