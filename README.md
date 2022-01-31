# Norme Venit API

![GitHub release (latest by date)](https://img.shields.io/github/v/release/twentytwokhz/caen-api)
![GitHub Release Date](https://img.shields.io/github/release-date/twentytwokhz/caen-api)
![GitHub issues](https://img.shields.io/github/issues/twentytwokhz/caen-api)
![GitHub](https://img.shields.io/github/license/twentytwokhz/caen-api)

![Lines of code](https://img.shields.io/tokei/lines/github/twentytwokhz/caen-api)
[![Azure Static Web Apps CI/CD](https://github.com/twentytwokhz/caen-api/actions/workflows/azure-static-web-apps-lively-island-0c5aca203.yml/badge.svg)](https://github.com/twentytwokhz/caen-api/actions/workflows/azure-static-web-apps-lively-island-0c5aca203.yml)

Acesta este un efort open-source pentru a democratiza găsirea normelor de venit bazate pe coduri CAEN din România.
Orice persoană care dorește să găsească cuantumul normei de venit pentru un cod CAEN in proiecte personale e liber să folosească acest API.

---
## Mod de utilizare
Acest API este găzduit gratuit pe un subdomeniu temporar.
https://norme-venit-api.florinbobis.me

API-ul poate fi găzduit de asemenea prin `Azure Static Web Apps`, `Azure Functions` sau alte variante de găzduire pentru aplicații web.
Vizitați directorul [src](https://github.com/twentytwokhz/norme-venit-api/tree/master/src) pentru a vedea mai multe.

### Endpoint-uri disponibile

> Notă: Parametrii cu `?` sunt opționali

#### 1. Lista coduri CAEN Codes după secțiune/divizie/grup

`https://norme-venit-api.florinbobis.me/api/caen/{sectionId?}/{divisionId?}/{groupId?}`

- https://norme-venit-api.florinbobis.me/api/caen
- https://norme-venit-api.florinbobis.me/api/caen/A
- https://norme-venit-api.florinbobis.me/api/caen/A/1
- https://norme-venit-api.florinbobis.me/api/caen/A/1/11

#### 2. Căutare cod CAEN

`https://norme-venit-api.florinbobis.me/api/search/{searchTerm}`

- https://norme-venit-api.florinbobis.me/api/search/plant

---
## Sursă date

Datele au fost preluate și prelucrate de pe [acest](https://static.anaf.ro/static/10/Anaf/AsistentaContribuabili_r/Normevenit2022/Norme_venit_2022.html) site.

---
MIT licensed | Copyright © 2022 Florin Bobiș
