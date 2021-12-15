using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float player_fHp = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetHit(float fDamage)
    {
        player_fHp -= fDamage;
        if (player_fHp < 0 )
        {
            player_fHp = 0;
        }
        UIMain.Instance().UpdateHpBar(player_fHp / 100.0f);
    }
}
