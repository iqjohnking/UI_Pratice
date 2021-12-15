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
    public GameObject m_PlayerObject; // 為了演示方便，此為強制放進來
    //public Player m_PlayerObject; // 這方法是否不可行?

    private void Awake()
    {
        mInstance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHpBar(float fHpValue)
    {
        m_HpBar.fillAmount = fHpValue;
    }


    public void DealDamageTest()
    {
        m_PlayerObject.SendMessage("GetDamage!!", 10.0f);
        //m_PlayerObject.GetHit(); ???? 這是否根本不可行?
    }
}
 