using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public float lifespan = 1.0f; // 오브젝트가 존재할 시간
    // Start is called before the first frame update
    void Start()
    {
        // 오브젝트 생성 시 일정 시간 후 사라지도록 시작
        Destroy(gameObject, lifespan);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
