using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Position_following : MonoBehaviour
{
    Vector3 mouseVector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouseVector=Input.mousePosition;
        this.gameObject.transform.position = mouseVector;
        Debug.Log(Input.mousePosition);
    }
}
