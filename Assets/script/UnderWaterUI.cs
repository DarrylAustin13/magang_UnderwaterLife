using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnderWaterUI : MonoBehaviour
{
    public static int FishGet = 0;
    public static int TrashCollect = 0;
    public Text FishShow;
    public Text TrashBag;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FishShow.text = "Fish : " + FishGet;
        TrashBag.text = "Trash : " + TrashCollect;
    }
}
