using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class PickUp : MonoBehaviour
{

    private readonly int point = 1;


    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        GameManager.GameScore += point;
        Destroy(this.gameObject);
    }

}
