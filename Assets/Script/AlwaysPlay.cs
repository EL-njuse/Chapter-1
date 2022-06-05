using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysPlay : MonoBehaviour
{
    static AlwaysPlay _instance;
    public static AlwaysPlay instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<AlwaysPlay>();
                DontDestroyOnLoad(_instance.gameObject);
            }
            return _instance;
        }
    }
    private void Awake()
    {
        //�˽ű��������٣�����ÿ�ν����ʼ����ʱ�����жϣ��������ظ���������
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this);
        }
        else if (this != _instance)
        {
            Destroy(gameObject);
        }
    }
}
