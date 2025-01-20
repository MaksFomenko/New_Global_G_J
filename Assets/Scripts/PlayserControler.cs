using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayserControler : MonoBehaviour
{

    public float speed = 1;
    public float xH;
    public float yV;
    public Vector3 deltMove;
    void Update()
    {
        xH = Input.GetAxisRaw("Horizontal");
        yV = Input.GetAxisRaw("Vertical");
        deltMove = new Vector3(xH, 0f, yV) * speed;
        transform.Translate(deltMove* Time.deltaTime);
    }
}
