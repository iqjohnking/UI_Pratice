using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float player_fHp = 100.0f;

    void Start()
    {
        
    }
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
        //¥ý©I¥s³æ¨Ò¡A¦A©I¥sfunction
        UIMain.Instance().UpdateHpBar(player_fHp / 100.0f);
    }
}
