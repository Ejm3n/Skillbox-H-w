using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject firstScreen;
    [SerializeField] private GameObject secondScreen;
    [SerializeField] private GameObject thridScreen;
    private GameObject currentScreen;

    public ImageTimer HarvestTimer;
    public ImageTimer EatingTimer;
    public Image PeasantTimerImg;
    public Image WarriorTimerImg;
    public Image RaidTimerimg;

    public AudioSource Battle;
    public AudioSource EatingCycle;
    public AudioSource HirePeasant;
    public AudioSource HireWarrior;
    public AudioSource HarvestCycle;

    public Button peasantButton;
    public Button WarriorButton;

    public Text recourcesText;
    public Text GameOverCountText;

    public int peasantCount;
    public int warriorsCount;
    public int wheatCount;

    public int wheatPerPeasant;
    public int wheatToWarriors;

    public int peasantCost;
    public int warriorCost;

    public float peasantCreateTime;
    public float warriorCreateTime;
    public float raidMaxTime;
    public int raidIncrease;
    public int nextRaid;
    public int FirstNRaids;
    private int CountTillRaid;
    private int RaidsSurvived;
    private int TotalWheat;
    private int TotalPeasant;
    private int TotalWarriors;
    

    private float peasantTimer = -2;
    private float warriorTimer = -2;
    private float raidTimer;

    private bool CheckWheatPeasant = true;
    private bool CheckWheatWarrior = true;
    void Start()
    {
        TotalWheat = wheatCount;
        TotalPeasant = peasantCount;
        TotalWarriors = warriorsCount;
        firstScreen.SetActive(true);
        currentScreen = firstScreen;
        UpdateText();
        raidTimer = raidMaxTime;
        RaidsSurvived = 0;
        CountTillRaid = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (wheatCount < (wheatToWarriors * warriorsCount) + peasantCost)
        {
            peasantButton.interactable = false;
        }
        else if (wheatCount < (wheatToWarriors * warriorsCount) + peasantCost + warriorCost && warriorTimer > 0)
            peasantButton.interactable = false;
        else if ((peasantTimer == -2) && wheatCount >= (wheatToWarriors * warriorsCount) + peasantCost) 
            peasantButton.interactable = true;
        if (wheatCount < (wheatToWarriors * warriorsCount) + warriorCost)
        {
            WarriorButton.interactable = false;
        }
        else if (wheatCount < (wheatToWarriors * warriorsCount) + warriorCost + peasantCost && peasantTimer >0)
            WarriorButton.interactable = false;
        else if ((warriorTimer == -2) && wheatCount >= ((wheatToWarriors+1) * warriorsCount) + warriorCost)
            WarriorButton.interactable = true;

        raidTimer -= Time.deltaTime;
        RaidTimerimg.fillAmount = raidTimer / raidMaxTime;
        if(raidTimer<=0)
        {
            
            raidTimer = raidMaxTime;
            warriorsCount -= nextRaid;
            if (warriorsCount < 0)
            {
                ChangeState(secondScreen);
                Time.timeScale = 0;
                GameOverCountText.text = RaidsSurvived + "\n" + TotalWheat + "\n" + TotalPeasant + "\n" + TotalWarriors;
            }      
            else if (CountTillRaid < FirstNRaids)
            {
                nextRaid = 0;
                CountTillRaid++;
            }
            else if (CountTillRaid == FirstNRaids)
            {
                nextRaid = 1;
                CountTillRaid = int.MaxValue;
            }
            else
            {
                RaidsSurvived += 1;
                nextRaid += raidIncrease;
                Battle.Play();
            }  
                     
        }

        if(HarvestTimer.Tick)
        {
            wheatCount += peasantCount * wheatPerPeasant;
            TotalWheat +=wheatCount;
            HarvestCycle.Play();
        }
        if(EatingTimer.Tick)
        {
            wheatCount -= warriorsCount * wheatToWarriors;
            EatingCycle.Play();
        }

        if(peasantTimer > 0)
        {
            
            peasantTimer -= Time.deltaTime;
            PeasantTimerImg.fillAmount = peasantTimer / peasantCreateTime;
        }
        else if (peasantTimer > -1)
        {
            PeasantTimerImg.fillAmount = 1;
            peasantButton.interactable = true;
            peasantCount += 1;
            TotalPeasant += 1;
            HirePeasant.Play();
            peasantTimer = -2;
        }

        if(warriorTimer>0)
        {
            warriorTimer -= Time.deltaTime;
            WarriorTimerImg.fillAmount = warriorTimer / warriorCreateTime;
        }
        else if (warriorTimer > -1)
        {
            WarriorTimerImg.fillAmount = 1;
            WarriorButton.interactable = true;
            warriorsCount += 1;
            TotalWarriors += 1;
            HireWarrior.Play();
            warriorTimer = -2;
        }
        
        UpdateText();
        if(RaidsSurvived >= 10)
        {
            ChangeState(thridScreen);
        }
    }
    public void CreatePeasant()
    {
        wheatCount -= peasantCost;
        peasantTimer = peasantCreateTime;
        peasantButton.interactable = false;
    }
    public void CreateWarrior()
    {
        wheatCount -= warriorCost;
        warriorTimer = warriorCreateTime;
        WarriorButton.interactable = false;
    }
    private void UpdateText()
    {
        recourcesText.text = peasantCount + "\n" + warriorsCount + "\n\n" + wheatCount + "\n\n" + nextRaid + "\n" + RaidsSurvived;
    }
    public void ChangeState(GameObject state)
    {
        if (currentScreen != null)
        {
            currentScreen.SetActive(false);
            state.SetActive(true);
            currentScreen = state;
        }
    }
}
