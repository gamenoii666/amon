using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Meta.Voice.Audio;

public class UI : MonoBehaviour
{
    public GameManager gameManager;
    public Snap Snap;
    public sfx_script sfx_Script;
    // Start is called before the first frame update

    public class LeaderboardUi : MonoBehaviour
    {
        [SerializeField] private Snap Snap;
        [SerializeField] private TMP_Text text;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            text.text = "Part: " + Snap.gameObject.name;
        }
    }
   
}

