using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSelectionResponse : MonoBehaviour, ISelectionResponse
{
    //[SerializeField] AudioSource audio;
    [SerializeField] private GameObject arrowPrefab;
    [SerializeField] private Vector3 offset;

    private GameObject _arrow;

    private void Start()
    {
        //audio = GetComponent<AudioSource>();
    }
    public void OnSelect(Transform selection)
    {
        //audio.Play();
        _arrow = Instantiate(arrowPrefab, selection);
        _arrow.transform.localPosition += offset;
    }

    public void OnDeselect(Transform selection)
    {
        if (_arrow != null)
        {
            Destroy(_arrow);
        }
    }
}
