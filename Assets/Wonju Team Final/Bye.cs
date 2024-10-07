using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bye : MonoBehaviour
{ 
    //public AudioSource audioSource; //오디오 소스
    public GameObject ByePrefab;
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
        if (timer >= 0.5f && isInstantiate == false) // 0.5초가 지나면
        {
            Instantiate(ByePrefab, transform.position + new Vector3(11.0f, 0.0f, 0), Quaternion.Euler(0, 0, -40.0f)); // 오브젝트 생성
            timer = 0f; // 타이머 초기화 (필요에 따라)
            isInstantiate = true;
        }
    }
}
