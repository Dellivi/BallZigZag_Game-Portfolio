using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{

    [SerializeField] private float speed = 1f;

    private bool state = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            state = !state;
        }

        if (!state)
        {
            transform.Translate(new Vector3(0, 0, -1f) * Time.deltaTime * speed);
        }
        else if (state)
        {
            transform.Translate(new Vector3(1f, 0, 0) * Time.deltaTime * speed);
        }
    }

}
