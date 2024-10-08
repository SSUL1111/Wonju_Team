using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fire_route : MonoBehaviour
{
    public GameObject FirePrefab;
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
        if (timer >= 1.5f && isInstantiate == false) // 1.5초가 지나면
        {
            Instantiate(FirePrefab, transform.position + new Vector3(0, 0, 1), Quaternion.Euler(0, 0, 0)); // 오브젝트 생성
            timer = 0f; // 타이머 초기화 (필요에 따라)
            isInstantiate = true;
        }
    }
}
