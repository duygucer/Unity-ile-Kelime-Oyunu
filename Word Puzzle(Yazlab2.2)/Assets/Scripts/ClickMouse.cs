using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMouse : MonoBehaviour
{
    public gmScript yeni;

    void OnMouseEnter()
    {
        if (yeni.drawingLine && !gmScript.positions.Contains(GetComponent<TextMesh>().gameObject.transform.position))
        {
            gmScript.positions.Add(GetComponent<TextMesh>().gameObject.transform.position);
            gmScript.currentWord += GetComponent<TextMesh>().text;
            gmScript.letterNum += 1;
            gmScript.selectLetter[gmScript.letterNum] = GetComponent<TextMesh>().text;
            yeni.ekle(transform);

        }
    }
    void OnMouseDown()
    {
        if (!gmScript.positions.Contains(GetComponent<TextMesh>().gameObject.transform.position))
        {
            gmScript.positions.Add(GetComponent<TextMesh>().gameObject.transform.position);
        }
        yeni.CizgiCiz(transform);
        gmScript.currentWord += GetComponent<TextMesh>().text;
        gmScript.letterNum += 1;
        gmScript.selectLetter[gmScript.letterNum] = GetComponent<TextMesh>().text;
    }

}
