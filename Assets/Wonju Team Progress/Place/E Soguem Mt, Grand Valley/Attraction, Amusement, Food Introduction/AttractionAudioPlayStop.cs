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
        myAudioSource.Stop(); // ó�� ���۽� ����Ǵ� BGM ����� ���.
    }

    //Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0)) // ���콺 ���� ��ư�� ���� ����
        {
            if (!myAudioSource.isPlaying) // ������� ��� ���� �ƴ� ���� ���
            {
                myAudioSource.Play();
            }
        }
        else
        {
            if (myAudioSource.isPlaying) // ������� ��� ���� ���� ����
            {
                myAudioSource.Stop();
            }
        }
    }
    //public void OnPointerEnter(PointerEventData eventData) // ���콺 Ŀ���� ��ư ���� ���� ��
    //{
    //    if (!myAudioSource.isPlaying) // ������� ��� ���� �ƴ� ���� ���
    //    {
    //        myAudioSource.Play();
    //    }
    //}

    //public void OnPointerExit(PointerEventData eventData) // ���콺 Ŀ���� ��ư�� ���� ��
    //{
    //    if (myAudioSource.isPlaying) // ������� ��� ���� ���� ����
    //    {
    //        myAudioSource.Stop();
    //    }
    //}
    //public void OnPointerEnter(PointerEventData eventData) // Ŀ���� ��ư�� �� ��
    //{
    //    if (!myAudioSource.isPlaying) // ������� ��� ���� �ƴ� ���� ���
    //    {
    //        myAudioSource.Play();
    //    }
    //}

    //public void OnPointerExit(PointerEventData eventData) // Ŀ���� ��ư�� ��� ��
    //{
    //    if (myAudioSource.isPlaying) // ������� ��� ���� ���� ����
    //    {
    //        myAudioSource.Stop();
    //    }
    //}
}
