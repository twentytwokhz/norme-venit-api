# Norme Venit API

![GitHub release (latest by date)](https://img.shields.io/github/v/release/twentytwokhz/norme-venit-api)
![GitHub Release Date](https://img.shields.io/github/release-date/twentytwokhz/norme-venit-api)
![GitHub issues](https://img.shields.io/github/issues/twentytwokhz/norme-venit-api)
![GitHub](https://img.shields.io/github/license/twentytwokhz/norme-venit-api)

![Lines of code](https://img.shields.io/tokei/lines/github/twentytwokhz/norme-venit-api)
[![Azure Static Web Apps CI/CD](https://github.com/twentytwokhz/norme-venit-api/actions/workflows/azure-static-web-apps-ashy-water-07abb6e03.yml/badge.svg)](https://github.com/twentytwokhz/norme-venit-api/actions/workflows/azure-static-web-apps-ashy-water-07abb6e03.yml)

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

> Notă: Momentan există date disponibile **doar** pentru județul Cluj

Tip Localitate:

- 0 = Municipiu Reședință de județ
- 1 = Municipiu Nereședință de județ
- 2 = Oraș
- 3 = Comună sau sat

#### 1. Lista norme de venit conform codului CAEN si judetului

`https://norme-venit-api.florinbobis.me/api/normavenit/{caen}/{judet}/{tipActivitate}`

- https://norme-venit-api.florinbobis.me/api/normavenit/2219/cluj/lc019/

#### 2. Norma de venit conform codului CAEN, judetului si tipului de localitate

`https://norme-venit-api.florinbobis.me/api/normavenit/{caen}/{judet}/{tipActivitate}/{tipLocalitate?}`

- https://norme-venit-api.florinbobis.me/api/normavenit/2219/cluj/lc019/0

---
## Sursă date

Datele au fost preluate și prelucrate de pe [acest](https://static.anaf.ro/static/10/Anaf/AsistentaContribuabili_r/Normevenit2022/Norme_venit_2022.html) site.

---
MIT licensed | Copyright © 2022 Florin Bobiș
