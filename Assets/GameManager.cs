using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject ballPrefab;

    public Pin[] allPins;
    public int score;
    public int totalScore;
    public int throwCounter;
    public int frameCounter;

    public GameObject gameOverScreen;
    public TextMeshProUGUI totalScoreText;

    public UIFrame[] allUIFrames;


    
    void Start()
    {
        Instantiate(ballPrefab);

        int temporaryNumber = 1;

        foreach(UIFrame ui in allUIFrames)
        {
            ui.frameNumberTitle.text = temporaryNumber.ToString();
            temporaryNumber += 1;

        }
    }

    void Update()
    {

    }

    public void CalculateScore()
    {
        int firstThrowScore = score;
        score = 0;

        throwCounter +=  1;


        foreach (Pin x in allPins)
        {
            if (x.isKnockedDown)
            {
                score += 1;
                x.gameObject.SetActive(false);
            }
        }


        if(throwCounter == 1)
        {
            allUIFrames[frameCounter].firstThrowScore.text = score.ToString();
        }

        if(throwCounter == 2)
        {
            allUIFrames[frameCounter].secondThrowScore.text = (score - firstThrowScore).ToString();
        }

        if(score == 10)
        {
            if (throwCounter == 2)
            {
                Debug.Log("SPARE!");
                allUIFrames[frameCounter].secondThrowScore.text = "/";
            }

            if (throwCounter == 1)
            {
                Debug.Log("STRIKE!");
                allUIFrames[frameCounter].firstThrowScore.text = "";
;               allUIFrames[frameCounter].secondThrowScore.text = "X";
                throwCounter = 2;
            }
        }



        if(throwCounter == 2)
        {
            totalScore += score;

            allUIFrames[frameCounter].currentTotalScore.text = totalScore.ToString();

            ResetPins();

            throwCounter = 0;

            frameCounter += 1;
        }

        if(frameCounter == 10)
        {
            gameOverScreen.SetActive(true);
            totalScoreText.text = totalScore.ToString();
        }

        Instantiate(ballPrefab);
    }


    void ResetPins()
    {
        foreach(Pin x in allPins)
        {
            x.isKnockedDown = false;

            x.gameObject.SetActive(true);
            x.transform.position = x.originalPosition;
            x.transform.eulerAngles = Vector3.zero;
        }
    }

}
