using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Celebration : MonoBehaviour
{
    //public AudioSource audioSource; //오디오 소스
    public GameObject CelebrationInstantiatePrefab;
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
        if (timer >= 1.0f && isInstantiate == false) // 1초가 지나면
        {
            Instantiate(CelebrationInstantiatePrefab, transform.position + new Vector3(4.0f, 2.0f, 0), Quaternion.Euler(0,0,-45.0f)); // 오브젝트 생성
            timer = 0f; // 타이머 초기화 (필요에 따라)
            isInstantiate = true;
        }
    }
}
