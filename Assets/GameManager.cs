using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ballPrefab;

    public Pin[] allPins;
    public int score;
    public int throwCounter;
    void Start()
    {
        Instantiate(ballPrefab);
    }

    void Update()
    {
        
    }

    public void CalculateScore()
    {
        score = 0;

        throwCounter += 1;


        foreach (Pin x in allPins)
        {
            if (x.isKnockedDown)
            {
                score += 1;
                x.gameObject.SetActive(false);
            }
        }

        Instantiate(ballPrefab);

    }

}
