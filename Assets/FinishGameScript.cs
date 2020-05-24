using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGameScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas canvas;
    public EnemyStats stats;
    private int counter = 0;
    void Start()
    {
        stats = GetComponent<EnemyStats>();
        canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (stats.isDeath && counter == 0)
        {
            canvas.enabled = true;
            Time.timeScale = 0;
            counter++;
        }
    }

    public void Run()
    {
        Time.timeScale = 1;
        canvas.enabled = false;
    }
}
