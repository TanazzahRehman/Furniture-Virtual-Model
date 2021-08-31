using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeScript : MonoBehaviour
{
    public Material _handleColor;
    public Color _handKirmizi;
    public Color _handMavi;
    public Color _handYesil;

    public Material _frameMat;
    public Color _frameKirmizi;
    public Color _frameMavi;
    public Color _frameYesil;

    public float _lerpTime;
    public float _totalTime;

    public GameObject[] _tip1;
    public GameObject[] _tip2;

    private void Start()
    {
        _handleColor.color = Color.white;
        _tip1 = GameObject.FindGameObjectsWithTag("Handle-1");
        _tip2 = GameObject.FindGameObjectsWithTag("Handle-2");
    }
    public void HandMaviRenk()
    {
        _lerpTime = 0;
        StartCoroutine(RenkDegis(_handleColor,_handMavi));
    }
    public void HandKirmiziRenk()
    {
        _lerpTime = 0;
        StartCoroutine(RenkDegis(_handleColor,_handKirmizi));
        
    }
    public void HandYesilRenk()
    {
        _lerpTime = 0;
        StartCoroutine(RenkDegis(_handleColor,_handYesil));
    }
    public void KasaMaviRenk()
    {
        _lerpTime = 0;
        StartCoroutine(RenkDegis(_frameMat,_frameMavi));
    }
    public void KasaKirmiziRenk()
    {
        _lerpTime = 0;
        StartCoroutine(RenkDegis(_frameMat, _frameKirmizi));
    }
    public void KasaYesilRenk()
    {
        _lerpTime = 0;
        StartCoroutine(RenkDegis(_frameMat, _frameYesil));
    }
    IEnumerator RenkDegis(Material _mat,Color _col)
    {
        _lerpTime = 0;
        while (_lerpTime < _totalTime)
        {
            _lerpTime += Time.deltaTime;
            _mat.color = Color.Lerp(_handleColor.color, _col, _lerpTime / _totalTime);
            Debug.Log(_lerpTime);
            yield return null;
        }
    }

    public void Tip_1()
    {
        foreach(GameObject kulp1 in _tip1)
        {
            kulp1.SetActive(true);
            //Color _col = kulp1.GetComponent<Renderer>().material.color;
            //_col.a = 1;
            //Debug.Log("tip1");
        }
        foreach (GameObject kulp2 in _tip2)
        {
            kulp2.SetActive(false);
            //Color _col = kulp2.GetComponent<Renderer>().material.color;
            //_col.a = 0f;
            
        }
    }
    public void Tip_2()
    {
        foreach (GameObject kulp2 in _tip2)
        {
            kulp2.SetActive(true);
            //Color _col = kulp2.GetComponent<Renderer>().material.color;
            //_col.a -= 0.1f;
            //Debug.Log("1");
        }
        foreach (GameObject kulp1 in _tip1)
        {
            kulp1.SetActive(false);
            //Color _col = kulp1.GetComponent<Renderer>().material.color;
            //_col.a = 1;
            //Debug.Log("1");
        }
    }
    public void Tip_3()
    {
        Debug.Log("Tip-3 is not ready!!");
    }

}
