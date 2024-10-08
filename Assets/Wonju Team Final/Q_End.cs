using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q_End : MonoBehaviour
{
    //public AudioSource audioSource; //오디오 소스
    public GameObject Q_EndPrefab;
    private float timer = 0f;

    public bool isInstantiate = false;
    // Start is called before the first frame update
    void Start()
    {
        ////오디오가 끝났는지 체크
        //if (!audioSource.isPlaying)
        //{
        //    // 씬 전환
        //    SceneManager.LoadScene("B");
        //}
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // 경과 시간 증가
        if (timer >= 2.5f && isInstantiate == false) // 2.5초가 지나면
        {
            Instantiate(Q_EndPrefab, transform.position + new Vector3(25.0f, 1.0f, 0), Quaternion.Euler(0, 0, -45.0f)); // 오브젝트 생성
            timer = 0f; // 타이머 초기화 (필요에 따라)
            isInstantiate = true;
        }
    }
}
