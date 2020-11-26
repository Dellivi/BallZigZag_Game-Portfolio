using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using Lean.Pool;

public class PickUp : MonoBehaviour
{
    public delegate void UpdateScore();
    public static event UpdateScore OnUpdateText;

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        AddScore(1);
        
        LeanPool.Despawn(this.gameObject);
    }

    public void AddScore(int score)
    {
        GameManager.GameScore += score;
        OnUpdateText();
    }

}
