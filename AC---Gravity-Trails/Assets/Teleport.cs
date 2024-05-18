using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public int EnemyCount;
    // Start is called before the first frame update
    void Start()
    {

        EnemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void changeEnemyCount(int e)
    {
        EnemyCount = e;
    }
    public int getEnemyCount()
    {
        return EnemyCount;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player" && EnemyCount == 0)
        {
            SceneManager.LoadScene(1);
        }
    }

}
