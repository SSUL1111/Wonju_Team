using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationPlayStop : MonoBehaviour
{
    Animator myAnim;
    private bool isTalking = true; // 기본값을 true로 설정
    public AudioSource myAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
        myAnim.SetBool("Talk", isTalking); // 초기 애니메이션 상태 설정
        myAudioSource = GetComponent<AudioSource>();
        myAudioSource.volume = 1.0f;
        myAudioSource.Play(); // 처음 시작시 재생되는 BGM 오디오 재생.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) // 마우스 왼쪽 버튼 클릭 시
        {
            isTalking = !isTalking; // 상태 말하기
            myAnim.SetBool("Talk", isTalking); // 애니메이션 상태 업데이트
            if (isTalking)
            {
                myAudioSource.Play(); // Talking 상태일 때 소리 재생
            }
            else
            {
                myAudioSource.Pause(); // Talking 상태가 아닐 때 소리 일시정지
            }
        }
    }
}
