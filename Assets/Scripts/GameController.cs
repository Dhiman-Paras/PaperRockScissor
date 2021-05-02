using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour{
    public GameObject mainMenu;
    public GameObject gamePlayMenu;
    public GameObject showingResultMenu;

    public GameObject[] cpuHands;
    public GameObject[] userHands;

    public int userChoice=4;
    int computerChoice = 0;

    public Text resultText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CPUShowAnimation() {
       // cpuAnimation[0].SetActive(true);
        //for (float i = 0; i <= 1000;i+=0.1f) { Debug.Log(i); }
       // cpuAnimation[1].SetActive(false);
    }
    int ComputerChoice() {
        int computerChoice = Random.Range(0,3);
        Debug.Log("Computer Choice: "+computerChoice);
        return computerChoice;
    }
    void CalculateTheResult() {
        userHands[0].SetActive(false);
        userHands[1].SetActive(false);
        userHands[2].SetActive(false);
        cpuHands[0].SetActive(false); 
        cpuHands[1].SetActive(false);
        cpuHands[2].SetActive(false);
        string user = "";
        string cpu = "";
        switch (userChoice)
        {
            case 0: user = "Paper";
                userHands[0].SetActive(true);
                break;
            case 1: user = "Rock"; userHands[1].SetActive(true); break;
            case 2: user = "Scissor"; userHands[2].SetActive(true); break;
        }
        switch (computerChoice)
        {
            case 0: cpu = "Paper"; cpuHands[0].SetActive(true); break;
            case 1: cpu = "Rock"; cpuHands[1].SetActive(true); break;
            case 2: cpu = "Scissor"; cpuHands[2].SetActive(true); break;
        }
        // 0 -> paper
        // 1-> Rock
        //2 -> Scissor
        if (userChoice == computerChoice)
        {
            Debug.Log("Draw...");
            resultText.text = "Draw";// + "You Choose: " + user +
                // "\n and \n CPU Choose: " + cpu;
        }
        else if (userChoice == 0 && computerChoice == 1)
        {
            resultText.text = "You Win";// + "You Choose: " + user +
                     // "\n and \n CPU Choose: " + cpu;
            Debug.Log("User Wins");
        }
        else if (userChoice == 1 && computerChoice == 2)
        {
            Debug.Log("User Wins");
            resultText.text = "You Win";// + "You Choose: " + user +
           //"\n and \n CPU Choose: " + cpu;
        }
        else if (userChoice == 2 && computerChoice == 0)
        {
            Debug.Log("User Wins");
            resultText.text = "You Win";//+ "You Choose: " + user +
          // "\n and \n CPU Choose: " + cpu;
        }
        else
        {
            
            Debug.Log("Computer Wins");
            resultText.text = "CPU Win";// + "You Choose: " + user +
          // "\n and \n CPU Choose: " + cpu;
        }
        ShowResult();
    }
    public void ChoosePaper() { userChoice = 0;
        CalculateTheResult();

        Debug.Log("Paper...");
    }
    public void ChooseRock() { userChoice = 1;
        CalculateTheResult();
    }
    public void ChooseScissor() { userChoice = 2;
        CalculateTheResult();
    }
    public void Play() {
        mainMenu.SetActive(false);
        showingResultMenu.SetActive(false);
        gamePlayMenu.SetActive(true);

        computerChoice = ComputerChoice();
       
    }

    public void ShowResult() {
        showingResultMenu.SetActive(true);
        gamePlayMenu.SetActive(false);

       
            
    }
   
}
