using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMain : MonoBehaviour
{
    //先singelton
    private static UIMain mInstance = null;
    public static UIMain Instance() { return mInstance;  }

    public Image m_HpBar;
    public GameObject m_PlayerObject; // 為了演示方便，直接在UIMain呼叫角色
    //public Player m_PlayerObject; // 這方法是否不可行?

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
        //SendMessage("function名稱" , 要傳送的數值)
        m_PlayerObject.SendMessage("GetHit", 10.0f);
        //m_PlayerObject.GetHit(); ? ??? 這是否根本不可行?
    }
}
 