using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;







public class Toplamakod : MonoBehaviour
{
    public GameObject btnsayipnl;
    public Text[] textler;
    public Text sagtext1, sagtext2, sagtext3, alttext1, alttext2, alttext3;
    public int[] sayiliste;
    int sayi, sayi2,sag1Int, alt1Int;
    public GameObject
        WinTextGameObject;
    void Start()
    {
        btnsayipnl.SetActive(false);
        
        
    }


    public void butonGoster(int btnNo)
    {
        btnsayipnl.SetActive(true);
        sayi = btnNo;


    }
    public void sayiGonder(int btnsayi)
    {
        btnsayipnl.SetActive(false);
        textler[sayi].text = btnsayi.ToString();
        sayi2 = int.Parse(textler[sayi].text);
        sayiliste[sayi] = sayi2;
    }





        void start()
    {
        WinTextGameObject.SetActive(false);

    }
    void buttonGoster(int btnNo)
    {
        btnsayipnl.SetActive(true);
    }






    void kontrol()
    {

        

        int sag1int = sayiliste[1] + sayiliste[2] + sayiliste[3];
        int alt1int = sayiliste[1] + sayiliste[4] + sayiliste[7];
        int sag2int = sayiliste[4] + sayiliste[5] + sayiliste[6];
        int sag3int = sayiliste[7] + sayiliste[8] + sayiliste[9];
        int alt2int = sayiliste[2] + sayiliste[5] + sayiliste[8];
        int alt3int = sayiliste[3] + sayiliste[6] + sayiliste[9];

        Debug.Log("sagint : " + sag1int.ToString());
        Debug.Log("sagint : " + sag2int.ToString());
        Debug.Log("sagint : " + sag3int.ToString());
        Debug.Log("alt1int : " + alt1int.ToString());
        Debug.Log("alt2int : " + alt2int.ToString());
        Debug.Log("alt3int : " + alt3int.ToString());




        if
            (sagtext1.text == sag1int.ToString() && alttext1.text == alt1int.ToString() && sagtext2.text == sag2int.ToString()
            && sagtext3.text == sag3int.ToString() && alttext2.text == alt2int.ToString() && alttext3.text == alt3int.ToString())
        {

            Debug.Log("Doðru cevap");
            
        }
        else
        {
            Debug.Log("Doðru cevap");

            
        }
    }
        



   
}







    



        



            
    

    



     
        
    




    
    
    





    


















    











