using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Title_Script : MonoBehaviour
{
    [SerializeField]
    private AudioSource audio;
    [SerializeField]
    private GameObject background_1;
    [SerializeField]
    private GameObject background_2;


    // Start is called before the first frame update
    void Start()
    {
        //set background
        background_1.SetActive(true);
        background_2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(!audio.isPlaying){
            //switch the two
            background_1.SetActive(false);
            background_2.SetActive(true);
        }
    }

    //on click for start button
    public void start_game(){
        SceneManager.LoadScene("SampleScene");
    }
}
