using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BoxCtrl : MonoBehaviour
{
    public Vector3 origionalPos;
    public Transform target;

    public Vector2 OffsetRate;

    public float defaltYOffset;

    private void Start()
    {
        origionalPos = transform.position;
        defaltYOffset = Camera.main.transform.parent.position.y;
    }
    private void Update()
    {
        // transform.position = new Vector3(target.position.x + target.position.x * OffsetRate.x, 
        //     0,
        //     target.position.z + target.position.z * OffsetRate.y);
        transform.position = new Vector3(target.position.x * OffsetRate.x, 
            0,
            target.position.z * OffsetRate.y);
    }
} 
