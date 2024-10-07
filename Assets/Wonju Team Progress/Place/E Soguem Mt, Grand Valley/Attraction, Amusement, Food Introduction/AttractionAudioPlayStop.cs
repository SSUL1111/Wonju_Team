using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AttractionAudioPlayStop : MonoBehaviour
{
    public AudioSource myAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
        myAudioSource.volume = 1.0f;
        myAudioSource.Stop(); // 처음 시작시 재생되는 BGM 오디오 재생.
    }

    //Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0)) // 마우스 왼쪽 버튼이 눌린 동안
        {
            if (!myAudioSource.isPlaying) // 오디오가 재생 중이 아닐 때만 재생
            {
                myAudioSource.Play();
            }
        }
        else
        {
            if (myAudioSource.isPlaying) // 오디오가 재생 중일 때만 정지
            {
                myAudioSource.Stop();
            }
        }
    }
    //public void OnPointerEnter(PointerEventData eventData) // 마우스 커서가 버튼 위에 있을 때
    //{
    //    if (!myAudioSource.isPlaying) // 오디오가 재생 중이 아닐 때만 재생
    //    {
    //        myAudioSource.Play();
    //    }
    //}

    //public void OnPointerExit(PointerEventData eventData) // 마우스 커서가 버튼을 떠날 때
    //{
    //    if (myAudioSource.isPlaying) // 오디오가 재생 중일 때만 정지
    //    {
    //        myAudioSource.Stop();
    //    }
    //}
    //public void OnPointerEnter(PointerEventData eventData) // 커서가 버튼에 들어갈 때
    //{
    //    if (!myAudioSource.isPlaying) // 오디오가 재생 중이 아닐 때만 재생
    //    {
    //        myAudioSource.Play();
    //    }
    //}

    //public void OnPointerExit(PointerEventData eventData) // 커서가 버튼을 벗어날 때
    //{
    //    if (myAudioSource.isPlaying) // 오디오가 재생 중일 때만 정지
    //    {
    //        myAudioSource.Stop();
    //    }
    //}
}
