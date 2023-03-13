using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class hesapMakinesi : MonoBehaviour
{
    public TextMeshProUGUI inputText;
    public Text sonucText;
    int  kontrol,sayac=0;
    float sonuc=0;
    float input;
    float son;
    float eskiDeger=0;

    public void tiklamaSayi(int deger){
        Debug.Log("deger: " + deger);
        inputText.text="Secilen Sayi: "+deger.ToString();
        sayac++;
        print(sayac);

        #region birden fazla basamakli sayilari alma
        if(sayac<=1){
            input=deger;
             eskiDeger=input;
        }else{
eskiDeger=eskiDeger*10+deger;
input=eskiDeger;
inputText.SetText("Secilen Sayi: "+input.ToString());
        } 
        #endregion
    }
      #region Matematikİslemleri
      public void tiklamaIslem(string islem){
        Debug.Log("islem: " + islem);
       switch (islem)
        {     
            case "arti" : 
            kontrol=0;
            sonuc+=input;
            break;
            case "eksi" :
            kontrol=0;
            sonuc-=input;
            break;
            case "carpma":
            kontrol=0;
            if(sonuc==0)
               sonuc=1;
            sonuc*=input;
            break;
            case "bolme":
            sonuc/=input;
            break; 
            case "denk" : 
           kontrol=0;
            son=input;
            input=sonuc;
            inputText.SetText("Sonuc: " + input.ToString() + " Secilen Sayi : " + son.ToString());
            input=son;
            break;
            case "delete" :
             kontrol=1;
            eskiDeger=(int)eskiDeger/10;
            input=eskiDeger;
            inputText.SetText("Secilen Sayi : " + input.ToString());
            break;
            case "reset" :
            kontrol=0;
            sonuc=0;
            input=0;
            inputText.SetText("0");
            break;
           
        }
        // bu kontrol delete tuşuna basılmışsa silerken tek tek silmesini saglıyor
     if(kontrol==0){
eskiDeger=0;
     }
        sonucText.text=sonuc.ToString();
    }
    #endregion
}
