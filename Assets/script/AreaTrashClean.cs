using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AreaTrashClean : MonoBehaviour
{    
    public static int TrashNeededToClean = 25;
    TextMeshProUGUI TrashBin;

    // Start is called before the first frame update
    void Start()
    {
        TrashBin = GetComponent<TextMeshProUGUI>();
        
    }

    void Update()
    {
        TrashBin.text= "Trash Needed to Clean : " + TrashNeededToClean;
    }

}
