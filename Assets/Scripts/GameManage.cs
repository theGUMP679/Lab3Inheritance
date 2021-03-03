using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManage : MonoBehaviour
{
    public Text textBox;
    public float timer;
    public float timerX;
    public bool SetTime;

    public GameObject[] Items;


    void Start()
    {
        timerX = timer * .25f;
        
    }

    private void Update()
    {
        textBox.text = (Item.Money + "Moneys and" + Item.Health);

        timer -= 1;


        if(timer <= 0)
        {
            Instantiate(Items[Random.Range(0, Items.Length)], new Vector3(Random.Range(-6, 6), 5.5f, 0), Quaternion.identity);
            timer = timerX;
        

        }

        

    }
}
