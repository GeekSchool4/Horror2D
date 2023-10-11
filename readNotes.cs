using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class readNotes : MonoBehaviour
{

    [SerializeField] private GameObject _note;

    
   [SerializeField] private GameObject _hero;
    public float _distanceToNote;
    [SerializeField] private GameObject _helpToRead;

    private void Update()
    {



        if (Vector3.Distance(transform.position, _hero.transform.position) < _distanceToNote)

        {

                _helpToRead.SetActive(true);




            if (Input.GetKeyDown(KeyCode.E))
            {
                _note.SetActive(true);
            }
        }
        else
        {
            _helpToRead.SetActive(false);
        }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                _note.SetActive(false);
                _helpToRead.SetActive(false);


            }

        }
        

    }







