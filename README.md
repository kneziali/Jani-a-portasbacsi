<div align="center">

# 🛂 Jani-a-portasbacsi

**Portásbácsi program - C#** <br>
![Language](https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![Platform](https://img.shields.io/badge/Platform-.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Project](https://img.shields.io/badge/Project-Console%20Application-blue?style=for-the-badge)

</div>

---

## 🎯 A program célja

<div align="center">

A program célja hogy a portán lévő személy logolni tudja hogy ki mikor érkezett és hogy ezeket az adatokat később vissza lehessen keresni.

</div>

---

## 📋 Menüpontok

<div align="center">

Választási lehetőség | Funkció 

👤 **Ember (1)** | Ember adatainak rögzítése <br>
🚗 **Jármű (2)** | Jármű adatainak rögzítése <br> 
🚪 **Kilépés (3)** | Kilépés a kérdezés ciklusból <br>
🔎 **Keresés (4)** | Keresés az állományban <br>

</div>

---

## 👤 (1) Ember

- 📝 Név
- 💳️ Személyi igazolvány száma

---

## 🚗 (2) Jármű

- 🔢 Rendszám
- 🏷️ Márka
- 🚘 Típus
- 🎨 Szín

---

## 🚪 (3) Kilépés

- a hármas gomb megnyomásakor leáll a bekérdezése a látogatóknak

---

## 🔎 (4) Keresés

- a négyes gomb megnyomásakor négy opció lesz a kereséshez:
    - Név alapján keresés
    - Rendszám alapján keresés
    - Jármű típusa alapján keresés
    - Jármű márkája alapján keresés

---

## Példa egy ember érkezésére és megkeresésére

`Ember (1) - Jármű (2) - Kilép (3) - Keresés (4): 1`
`Név: Fütyülő Imre`
`Személyazonosító igazolvány szám: 432156FB`
`Ember (1) - Jármű (2) - Kilép (3) - Keresés (4): 4`
`Keresés Név (1) - Rendszám (2) - Jármű Típus (3) - Jármű Márka (4) alapján: 1`
`Keressen: fütyülő imre`

`Adatok a keresés alapján:`

`================================`
`2026.11.09 11:04:04`
`Látogató: Személy`
`Név: Fütyülő Imre`
`Személyi igazolvány szám: 432156FB`
`================================`

## 📁 Naplózás

<div align="center">

### 📄 `belepes.txt`

</div>

A Látogatás logolva lesz a belepes.txt állományba

---

<div align="center">
