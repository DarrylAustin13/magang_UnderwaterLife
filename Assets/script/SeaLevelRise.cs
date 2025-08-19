using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SeaLevelRise : MonoBehaviour
{
    public Text SeaLevelText;
    int SeaLevel = 1;
    public Text DayNum;
    public static int Day = 1;
    public static int money = 10000;
    private int MoneyNee = 300000;
    private int moneyTimerUpgrade = 50000;
    public Text MoneyAmount;
    public Text MoneyToClean;
    public Text MoneyToProLong;
    public TextMeshProUGUI TrashCollect;
    public static int TrashFillL = 25;
    public static int TrashFill = 25;
    [SerializeField] GameObject CleanReady;
    
    // Start is called before the first frame update
    void Start()
    {
        
        SeaLevelText.text = "Sea Lv " + SeaLevel;
        DayNum.text = "Day " + Day;
        MoneyAmount.text = "Rp " + money;
        MoneyToProLong.text = "Rp " + moneyTimerUpgrade;
        
        if (TrashFill == 0)
        {
            CleanReady.SetActive(true);
            MoneyToClean.text = "Money needed = " + MoneyNee;
        }
        
    }

    void Update()
    {
        TrashCollect.text = "Trash Needed To Clean: " + TrashFill;
    }
    public void CleanTheSea()
    {
        if( TrashFill == 0 && money >= MoneyNee && SeaLevel < 3)
        {
            SeaLevel += 1;
            TrashFillL += 20;
            TrashFill = TrashFillL;
            CleanReady.SetActive(false);
            money -= MoneyNee;
            MoneyNee += (SeaLevel * 15000);
            SeaLevelText.text = "Sea lv " + SeaLevel;
            MoneyAmount.text = "Rp " + money;
            TrashCollect.text = "Trash Needed To Clean: " + TrashFill;
        }
    }

    public void UpgradeTime()
    {
        Timer.remainingTime += 10;
        money -= moneyTimerUpgrade;
        moneyTimerUpgrade += 5000;
        MoneyToProLong.text = "Rp " + moneyTimerUpgrade;
    }

    public void EnterSea()
    {
        string SeaDiving = "Diving Lv " + SeaLevel;
        SceneManager.LoadScene(SeaDiving);
    }

}
