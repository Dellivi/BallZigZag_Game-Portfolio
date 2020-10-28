using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class PickUp : MonoBehaviour
{

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        AddScore(1);
        Destroy(this.gameObject);
    }

    public void AddScore(int score)
    {
        GameManager.GameScore += score;
    }

}
