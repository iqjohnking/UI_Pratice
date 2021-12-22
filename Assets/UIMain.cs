using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMain : MonoBehaviour
{
    //��singelton
    private static UIMain mInstance = null;
    public static UIMain Instance() { return mInstance;  }

    public Image m_HpBar;
    public GameObject m_PlayerObject; // ���F�t�ܤ�K�A�����bUIMain�I�s����
    //public Player m_PlayerObject; // �o��k�O�_���i��?

    private void Awake()
    {
        mInstance = this;
    }

    void Start()
    {
        
    }
    void Update()
    {
        
    }

    public void UpdateHpBar(float fHpValue)
    {
        m_HpBar.fillAmount = fHpValue;
    }


    public void DealDamageTest(Button b)
    {
        Debug.Log(b.name + ":click");
        //SendMessage("function�W��" , �n�ǰe���ƭ�)
        m_PlayerObject.SendMessage("GetHit", 10.0f);
        //m_PlayerObject.GetHit(); ? ??? �o�O�_�ڥ����i��?
    }
}
 