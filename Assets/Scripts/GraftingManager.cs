using UnityEngine;
using UnityEngine.UI;

public class GraftingManager : MonoBehaviour
{
    public enum TahapGrafting { PotongBatangBawah, SayatEntres, SatukanDanIkat, SungkupPlastik, Selesai }
    public TahapGrafting tahapSaatIni = TahapGrafting.PotongBatangBawah;

    public Text teksPetunjuk;
    public Slider bilahKemajuan;

    public GameObject modelBatangBawahUtama;
    public GameObject modelBatangBawahTerpotong;
    public GameObject modelEntres;
    public GameObject modelTaliPlastik;
    public GameObject modelSungkup;

    void Start()
    {
        UpdateTahapPraktikum();
    }

    public void UpdateTahapPraktikum()
    {
        switch (tahapSaatIni)
        {
            case TahapGrafting.PotongBatangBawah:
                teksPetunjuk.text = "TUGAS: Geser pisau untuk memotong dan membuat celah V pada batang bawah!";
                bilahKemajuan.value = 0;
                modelBatangBawahUtama.SetActive(true);
                modelBatangBawahTerpotong.SetActive(false);
                break;

            case TahapGrafting.SayatEntres:
                teksPetunjuk.text = "TUGAS: Sayat kedua sisi pangkal entres hingga berbentuk baji!";
                bilahKemajuan.value = 0;
                modelBatangBawahUtama.SetActive(false);
                modelBatangBawahTerpotong.SetActive(true);
                break;

            case TahapGrafting.SatukanDanIkat:
                teksPetunjuk.text = "TUGAS: Seret entres ke batang bawah, lalu lilitkan tali plastik dari bawah ke atas!";
                modelTaliPlastik.SetActive(false);
                break;

            case TahapGrafting.SungkupPlastik:
                teksPetunjuk.text = "TUGAS: Pasang sungkup plastik bening untuk menjaga kelembaban entres!";
                modelSungkup.SetActive(false);
                break;

            case TahapGrafting.Selesai:
                teksPetunjuk.text = "Selamat! Sambung pucuk berhasil. Bibit siap diaklimatisasi.";
                break;
        }
    }

    public void TambahKemajuan(float nilai)
    {
        bilahKemajuan.value += nilai;
        if (bilahKemajuan.value >= 1f)
        {
            tahapSaatIni++;
            UpdateTahapPraktikum();
        }
    }
}
