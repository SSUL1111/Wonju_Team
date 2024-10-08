using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Bus : MonoBehaviour
{
    public AudioClip audioClip; // 재생할 오디오 클립
    private AudioSource audioSource;
    private float timer = 0f;
    private bool isAudioPlayed = false;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = audioClip;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isAudioPlayed)
        {
            timer += Time.deltaTime; // 타이머 증가

            if (timer >= 5.0f) // 5초가 지났다면
            {
                audioSource.Play(); // 오디오 재생
                isAudioPlayed = true; // 오디오가 재생되었음을 기록
            }
        }
    }
}
