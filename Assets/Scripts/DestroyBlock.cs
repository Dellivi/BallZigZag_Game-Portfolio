using UnityEngine;
using System.Collections;

public class DestroyBlock : MonoBehaviour
{

    private bool isExit = false;
    private float startTime = 0.1f;
    private readonly float endTime = 2f;

    private void FixedUpdate()
    {

        if (isExit)
        {
            startTime += 2f * Time.fixedDeltaTime;
            if(startTime >= endTime)
            {
                transform.Translate(new Vector3(0, -3f, 0) * Time.fixedDeltaTime);
                Destroy(this.gameObject, 3f);
            }
            
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        isExit = true;
    }

}
