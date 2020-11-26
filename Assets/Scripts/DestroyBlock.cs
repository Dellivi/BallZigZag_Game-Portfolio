using UnityEngine;
using System.Collections;
using Lean.Pool;

public class DestroyBlock : MonoBehaviour
{

    private bool isExit = false;
    private float startTime = 0.1f;
    private readonly float endTime = 2f;

    private void Update()
    {

        if (isExit)
        {
            startTime += Random.Range(0, 4f) * Time.deltaTime;
            if(startTime >= endTime)
            {
                gameObject.transform.Translate(new Vector3(0, -3f, 0) * Time.deltaTime);
                LeanPool.Despawn(this.gameObject, 3f);
            }
            
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        isExit = true;
    }

}
