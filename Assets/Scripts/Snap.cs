using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snap : MonoBehaviour
{
    public GameManager gameManager;
    [SerializeField]
    private string _NamePartSnap;

    public bool isSnap = false;
    public bool isPartCorrect = false;
    // Start is called before the first frame update

    private void OnEnable()
    {
        if (PlayerPrefs.HasKey("Part"))
        {
            _NamePartSnap = PlayerPrefs.GetString("Part");
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Part"))
        {

            other.gameObject.transform.position = transform.position;
            other.gameObject.transform.rotation = transform.rotation;

            if (other.gameObject.name == _NamePartSnap)
            {
                isPartCorrect = true;
            }
            if (!isSnap)
            {
                isSnap = true;
                gameManager.snapCheck();

            }

        }
    }


    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.CompareTag("Part"))
        {
            isSnap = false;
            isPartCorrect = false;

        }
    }
    private void OnDestroy()
    {
        savePrefs();
    }

    void savePrefs()
    {
        PlayerPrefs.SetString("Part", _NamePartSnap);
        PlayerPrefs.Save();
    }

}
