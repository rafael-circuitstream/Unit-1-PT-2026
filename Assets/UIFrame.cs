using UnityEngine;
using TMPro;

public class UIFrame : MonoBehaviour
{
    public TextMeshProUGUI frameNumberTitle;
    public TextMeshProUGUI firstThrowScore;
    public TextMeshProUGUI secondThrowScore;
    public TextMeshProUGUI currentTotalScore;

    void Start()
    {
        firstThrowScore.text = "";
        secondThrowScore.text = "";
        currentTotalScore.text = "";
    }
}
