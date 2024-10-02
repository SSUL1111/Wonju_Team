using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationPlayStop : MonoBehaviour
{
    Animator myAnim;
    private bool isTalking = true; // �⺻���� true�� ����
    public AudioSource myAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
        myAnim.SetBool("Talk", isTalking); // �ʱ� �ִϸ��̼� ���� ����
        myAudioSource = GetComponent<AudioSource>();
        myAudioSource.volume = 1.0f;
        myAudioSource.Play(); // ó�� ���۽� ����Ǵ� BGM ����� ���.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) // ���콺 ���� ��ư Ŭ�� ��
        {
            isTalking = !isTalking; // ���� ���ϱ�
            myAnim.SetBool("Talk", isTalking); // �ִϸ��̼� ���� ������Ʈ
            if (isTalking)
            {
                myAudioSource.Play(); // Talking ������ �� �Ҹ� ���
            }
            else
            {
                myAudioSource.Pause(); // Talking ���°� �ƴ� �� �Ҹ� �Ͻ�����
            }
        }
    }
}
