using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class GameManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI _score;
    [SerializeField] private GameObject _ball;
    [SerializeField] private GameObject _startWindow;
    [SerializeField] private BallController _bc;

    private static int gameScore = 0;
    private bool isGameStart = false;
    //private static int completeLevels = 0;

    public static int GameScore { get => gameScore; set => gameScore = value; }
    public bool IsGameStart { get => isGameStart; set => isGameStart = value; }

    //public static int CompleteLevels { get => completeLevels; set => completeLevels = value; }

    void Start()
    {
        _ball.transform.position = new Vector3(2, 1.5f, 0);

        PickUp.OnUpdateText += UpdateText;
    }

     /* 
     * TODO: Оптимизировать через Events
     */
    private void Update()
    {
        // Изменение направления движения шара и начало игры.
        if (Input.GetMouseButtonDown(0))
        {
            _startWindow.SetActive(false);
            isGameStart = true;
            _bc.ChangeDir = !_bc.ChangeDir;
        }
    }

    public void UpdateText()
    {
        _score.text = GameScore.ToString();
    }


}
