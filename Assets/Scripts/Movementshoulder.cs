using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;
using System;
using System.Threading;
using UnityEditor.Build.Content;
using UnityEngine.SceneManagement;

public class MovementShoulder : MonoBehaviour
{
    public int switch_on;
    public int n;
    public bool flag;
    public bool flag2;
    public bool flag3;
    public GameObject gameObject1;
    public GameObject gameObject2;
    public GameObject gameObject3;
    public GameObject gameObject4;
    public GameObject gameObject5;
    public GameObject gameObject6;
    public GameObject gameObject7;
    public GameObject gameObject8;
    public GameObject gameObject9;
    public GameObject gameObject10;
    public GameObject Movement1;
    public GameObject Movement2;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    { 
        switch_on = 0;
        n = 0;
        flag = false;
        flag2 = false;
        flag3 = false;
    }
    // Update is called once per frame
     async void Update()
     {
        switch (switch_on)
        {
            case 0:
                {
                    gameObject4.transform.position += new Vector3(0, 0, 0.01f);
                    if(gameObject4.transform.position.z > 8.7){
                        switch_on = 1;
                    }
                    break;
                }
            case 1:
                {
                    Movement1.transform.localRotation = Quaternion.Lerp(Movement1.transform.localRotation, Quaternion.Euler(0, -64.535f, -89.718f), Time.deltaTime);
                    Movement2.transform.localRotation = Quaternion.Lerp(Movement2.transform.localRotation, Quaternion.Euler(25.349f, 0, 0), Time.deltaTime); transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(0, 0, 105), Time.deltaTime);
                    if (transform.localRotation == Quaternion.Euler(0, 0, 105))
                    {
                        switch_on = 2;
                        n += 1;
                        gameObject1.SetActive(true);

                    }
                    break;
                }
            case 2:
                {
                    Movement1.transform.localRotation = Quaternion.Lerp(Movement1.transform.localRotation, Quaternion.Euler(-0.203f, 30.438f, -90.922f), Time.deltaTime);
                    Movement2.transform.localRotation = Quaternion.Lerp(Movement2.transform.localRotation, Quaternion.Euler(131.645f, 0, 0), Time.deltaTime);
                    transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(0, 0, 60), Time.deltaTime);
                    if (transform.localRotation == Quaternion.Euler(0, 0, 60))
                    {
                        if (n < 4)
                        {
                            switch_on = 1;

                        }
                        else
                        { 
                            switch_on = 0; 
                        }
                        n += 1;
                        gameObject1.SetActive(false);
                        if (n == 2)
                        {   
                            gameObject2.SetActive(true);
                        }
                        if (n == 4)
                        {
                            gameObject1.SetActive(true);
                            switch_on = 3;
                        }
                        
                        if(flag)
                        {
                            gameObject1.SetActive(true);
                            switch_on = 3;
                            flag = false;
                            flag2 = true;

                        }
                        if (flag2)
                        {
                            gameObject1.SetActive(true);
                            gameObject2.SetActive(false);
                            switch_on = 3;
                            flag = false;
                        }
                       

                        
                    }
                    break;
                }
            case 3:
                {
                    flag = true;
                    
                    
                    Movement1.transform.localRotation = Quaternion.Lerp(Movement1.transform.localRotation, Quaternion.Euler(-0.823f, -32.733f, -90.416f), Time.deltaTime);
                    Movement2.transform.localRotation = Quaternion.Lerp(Movement2.transform.localRotation, Quaternion.Euler(55.395f, 0, 0), Time.deltaTime);
                    transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(0, 0, 16.121f), Time.deltaTime);
                    if (transform.localRotation == Quaternion.Euler(0, 0, 16.121f))
                    {
                        if (n < 5) { 
                        gameObject1.SetActive(true);
                           }
                        switch_on = 5;
                        n += 1;
                        gameObject1.SetActive(false);
                        gameObject5.SetActive(true);
                    }
                    break;
                }
            case 4:
                {
                    Movement1.transform.localRotation = Quaternion.Lerp(Movement1.transform.localRotation, Quaternion.Euler(-0.614f, -11.327f, -90.688f), Time.deltaTime);
                    Movement2.transform.localRotation = Quaternion.Lerp(Movement2.transform.localRotation, Quaternion.Euler(101.315f, 0, 0), Time.deltaTime);
                    transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(0, 0, 75.052f), Time.deltaTime);
                    if (transform.localRotation == Quaternion.Euler(0, 0, 75.052f))
                    {
                        if (flag3)
                        {
                            switch_on = 7;
                            break;
                        }
                        gameObject7.SetActive(false);
                        gameObject8.SetActive(true);
                        if (flag2)
                        {
                           
                            gameObject9.SetActive(true);
                            switch_on = 6;
                            gameObject9.SetActive(false);
                            gameObject7.SetActive(true);
                             if (!flag)
                            {
                                gameObject8.SetActive(false);
                                flag3 = true;
                              
                            }
                            break;

                        }

                        switch_on = 2;
                        n += 1;
                       
                    }
                    
                    break;
                }
            case 5:
                {   

                    gameObject5.SetActive(true);
                    anim.Play("move1");
                    gameObject10.SetActive(true);
                    await Task.Delay(2000);
                    gameObject5.SetActive(false);
                    gameObject6.SetActive(true);
                    await Task.Delay(2000);
                    gameObject10.SetActive(false);
                    gameObject6.SetActive(false);
                    gameObject7.SetActive(true);
                    await Task.Delay(2000);
                    switch_on = 4;
                    if (!flag2) { flag = true; }
                    break;
                }

            case 6:
                {
                   


                    Movement1.transform.localRotation = Quaternion.Lerp(Movement1.transform.localRotation, Quaternion.Euler(0, -64.535f, -89.718f), Time.deltaTime);
                    Movement2.transform.localRotation = Quaternion.Lerp(Movement2.transform.localRotation, Quaternion.Euler(25.349f, 0, 0), Time.deltaTime); transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(0, 0, 105), Time.deltaTime);
                    if (transform.localRotation == Quaternion.Euler(0, 0, 105))
                    {
                        switch_on = 4;
                        gameObject7.SetActive(false);
                        flag = false; 
                    }
                    break;
                }
            case 7:
                { 
                    gameObject4.transform.position += new Vector3(0, 0, -0.01f);
           
                    if (gameObject4.transform.position.z < 5)
                    {
                        switch_on = 8;
                    }
                    break;
  
                }
            case 8:
                {
                    break;
                }

        }
       
    }

}
