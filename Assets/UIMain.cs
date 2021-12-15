using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMain : MonoBehaviour
{
    //¥ýsingelton
    private static UIMain mInstance = null;
    public static UIMain Instance() { return mInstance;  }

    public Image m_HpBar;

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

    }
}
 