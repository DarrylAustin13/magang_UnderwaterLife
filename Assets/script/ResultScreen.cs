using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultScreen : MonoBehaviour
{
    public Text NightNow;
    public Text FishMoney;
    public Text TrashCleaned;
    private int MoneyF = UnderWaterUI.FishGet * 20000;
    
    // Start is called before the first frame update
    void Start()
    {
        NightNow.text = "Day " + SeaLevelRise.Day;
        FishMoney.text = "Fish : "  + MoneyF;
        TrashCleaned.text = "Trash : " + UnderWaterUI.TrashCollect;
    }
    

    public void DoneS()
    {
        SeaLevelRise.money += MoneyF;
        SeaLevelRise.TrashFill -= UnderWaterUI.TrashCollect;
        if(SeaLevelRise.TrashFill < 0)
        {
            SeaLevelRise.TrashFill = 0;
        }
        UnderWaterUI.FishGet = 0;
        UnderWaterUI.TrashCollect = 0;
        SeaLevelRise.Day += 1; 
        SceneManager.LoadScene("MorningMenu");

    } 
}
