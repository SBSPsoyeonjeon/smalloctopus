using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
	public string scenename;
    //public int i;

    void OnTriggerEnter2D(Collider2D other)//왕새우 먹으면
    {
        if (other.CompareTag("Player"))
        {
            //SceneManager.LoadScene("play1_2"); //이 씬 이름으로 (다음 단계로) 이동
    		SceneManager.LoadScene(scenename);
            
       
        }
    }
   
}


