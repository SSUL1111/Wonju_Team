using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Celebration : MonoBehaviour
{
    public AudioSource audioSource; // 오디오 소스
    // Start is called before the first frame update
    void Start()
    {
        // 오디오가 끝났는지 체크
        if (!audioSource.isPlaying)
        {
            // 씬 전환
            SceneManager.LoadScene("B");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
