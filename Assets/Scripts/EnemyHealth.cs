using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    private Stat health;

    void Awake()
    {
        health.Initialize();
    }


    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Minus))
        {
            health.CurrentValue -= 10;
        }
        if (Input.GetKeyDown(KeyCode.Equals))
        {
            health.CurrentValue += 10;
        }
        */
    }

    public void Damage()
    {
        health.CurrentValue -= 10f;
        if (health.CurrentValue <= 0)
        {
            GM.instance.GameWon();
        }
    }
}
