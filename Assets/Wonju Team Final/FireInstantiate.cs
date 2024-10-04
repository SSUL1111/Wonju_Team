using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireInstantiate : MonoBehaviour
{  
    public GameObject leftInstantiatePrefab;
    public GameObject rightInstantiatePrefab;
    private float timer = 0f;

    public bool isInstantiate = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // ��� �ð� ����
        if (timer >= 0.5f&&isInstantiate==false) // 0.5�ʰ� ������
        {
            Instantiate(leftInstantiatePrefab, transform.position + new Vector3(-7, -0.5f, 0), Quaternion.identity); // ������Ʈ ����
            Instantiate(rightInstantiatePrefab, transform.position + new Vector3(7, -0.5f, 0), Quaternion.identity); // ������Ʈ ����
            timer = 0f; // Ÿ�̸� �ʱ�ȭ (�ʿ信 ����)
            isInstantiate = true;
        }
    }
}
