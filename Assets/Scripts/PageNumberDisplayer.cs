using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using BookCurlPro;

public class PageNumberDisplayer : MonoBehaviour
{

    public TMP_Text numberText;
    private int currentPage, pageIndex;
    BookPro myBookPro;

    public void Start()
    {
        myBookPro = GetComponent<BookPro>();
        numberText.text = "101 / 1";
    }

    public void UpdatePageNumber()
    {
        currentPage = myBookPro.currentPaper;
        pageIndex = Mathf.Abs(currentPage - 103); 
        numberText.text = "101 / " + pageIndex; 
    }
 
}
