using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireInstantiate : MonoBehaviour
{  
    public GameObject leftInstantiatePrefab;
    public GameObject rightInstantiatePrefab;
    private float timer = 0f;

    public bool isInstantiate = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // 경과 시간 증가
        if (timer >= 1.0f&&isInstantiate==false) // 1초가 지나면
        {
            Instantiate(leftInstantiatePrefab, transform.position + new Vector3(-7, -0.5f, 0), Quaternion.identity); // 오브젝트 생성
            Instantiate(rightInstantiatePrefab, transform.position + new Vector3(8, -0.5f, 0), Quaternion.identity); // 오브젝트 생성
            timer = 0f; // 타이머 초기화 (필요에 따라)
            isInstantiate = true;
        }
    }
}
