using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(480, 800, false);
    }

    // Update is called once per frame
    void Update()
    {
        // ���콺 ��Ŭ���� y������ 300��ŭ ���� 
        if(Input.GetMouseButtonDown(0)) 
        {
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            gameObject.GetComponent<Rigidbody>().AddForce(0, 250, 0);
        }

        // R��ư ������ ���� �ʱ�ȭ �� �����
        if(Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("Game");
        }
    }

    // �浹�� ���� ����
    void OnCollisionEnter(Collision coll)
    {
        Time.timeScale = 0;
    }
}
