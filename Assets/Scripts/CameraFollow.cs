using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform playerTransform;
    public float offsetX;
    public float offsety;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Camera X axis
        Vector3 temp = transform.position;
        temp.x = playerTransform.position.x;
        temp.x += offsetX;
        transform.position = temp;

        //Camera Y axis
        Vector3 tempy = transform.position;
        tempy.y = playerTransform.position.y;
        tempy.y += offsety;
        transform.position = tempy;
    }
}
