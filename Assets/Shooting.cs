using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Shooting : MonoBehaviour
{

    public Transform SpawnPosition;
    public GameObject BulletPrefab;
    public float BulletForce;
    public Text KillCountUI;
    public int KillCount;
    public string Win = "4";
    
    // Start is called before the first frame update
    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0))
        {

            Debug.Log("SHOOT");

           GameObject BulletClone =    Instantiate(BulletPrefab, SpawnPosition.position, SpawnPosition.rotation);

            Rigidbody rb = BulletClone.GetComponent<Rigidbody>();

            rb.AddRelativeForce(Vector3.up * BulletForce, ForceMode.Impulse);

        }


    }

     public void EnemyKilled()
    {

        Debug.Log("Enemy Killed");

        KillCount++;

        KillCountUI.text = KillCount.ToString();

        
        
        
        
        
        
        if (KillCountUI.text == Win)
        {

            


           SceneManager.LoadScene(3);

        }



      }



    
    

        

        



    
 







}



    





