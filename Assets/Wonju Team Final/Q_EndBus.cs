using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q_EndBus : MonoBehaviour
{
    public GameObject EndBusPrefab;
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
        if (timer >= 5.0f && isInstantiate == false) // 5초가 지나면
        {
            Instantiate(EndBusPrefab, transform.position + new Vector3(1, 0, 1), Quaternion.Euler(0, 0, 0)); // 오브젝트 생성
            timer = 0f; // 타이머 초기화 (필요에 따라)
            isInstantiate = true;
        }
    }
}
