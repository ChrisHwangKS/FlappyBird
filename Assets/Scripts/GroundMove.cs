using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour
{
    float _distance = 6.13f;
    int _count = 2;
    int _index = 2;

    public GameObject[] grounds;
    void Awake()
    {
        Application.targetFrameRate = 40;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale == 0)
        {
            return;
        }

        gameObject.transform.localPosition += new Vector3(-0.05f, 0, 0);

        _count = 2 + (int)(-gameObject.transform.localPosition.x / 6.13f);

        if(_index != _count)
        {
            grounds[(_index - 2) % 3].transform.localPosition = new Vector3(_distance * _count, -3.91f, 0);
            _index = _count;
        }
    }
}
