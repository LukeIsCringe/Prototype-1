using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] public float Score;
    [SerializeField] private TMP_Text ScoreText;

    void Update()
    {
        Score++;

        ScoreText.text = Score.ToString();       
    }
}
