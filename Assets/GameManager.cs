using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class GameManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI _score;

    private static int gameScore = 0;
    //private static int completeLevels = 0;

    public static int GameScore { get => gameScore; set => gameScore = value; }
    //public static int CompleteLevels { get => completeLevels; set => completeLevels = value; }

    void Start()
    {
        _score.text = GameScore.ToString();
    }

     /* 
     * TODO: Оптимизировать через Events
     */
    private void Update()
    {
       UpdateText();
    }

    public void UpdateText()
    {
        _score.text = GameScore.ToString();
    }


}
