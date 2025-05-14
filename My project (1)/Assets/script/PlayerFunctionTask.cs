using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFunctionTask : MonoBehaviour
{
    // Start is called before the first frame update

    public int playerHealt;
    public int playerArmor;
    public int damage;
    public bool isDead = false;
    public int currentHp;

    void Start()
    {
        GetPlayerStatus();
        CalculateEffectiveDamage();
        isPlayerAlive();
    }

    public void GetPlayerStatus()
    {
        Debug.Log("HP : " + playerHealt);
    }

    public void CalculateEffectiveDamage()
    {
        int total = playerHealt + playerArmor;
        currentHp = total - damage;

        Debug.Log("Armor : " + playerArmor);
        Debug.Log("Total HP : " + total);
        Debug.Log("Damage yang diterima : " + damage);
        Debug.Log("Current HP : " + currentHp);
    }

    public void isPlayerAlive()
    {
        if (currentHp <= 0)
        {
            isDead = true;
            Debug.Log("Player telah mati");
        }
        else
        {
            Debug.Log("Player masih hidup");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}