---
title: Default Format Used by Everest
---

# Default Format Used by Everest


The default formats used by **Everest**  for request and answer files are given below:


**Transaction Request**


If a request format is not specified for a processor, **Everest**  generates requests in the following format:


**SALE** = <C1>, CLERK, ORDERNO,  ACCOUNT, EXP  + SWIPEINFO,'AMOUNT,  ZIP, ADDRESS,, TAX,,,,,, ORDERNO,,,  CVV2


**SHIP** = <CO>, CLERK, ORDERNO,  ACCOUNT, EXP  + SWIPEINFO,  AMOUNT, ZIP, ADDRESS


**REFUND** = <C3>, CLERK,  ORDERNO, ACCOUNT,  EXP + SWIPEINFO,  AMOUNT


**BOOK** = <C4>, CLERK, ORDERNO,  ACCOUNT, EXP  + SWIPEINFO,  AMOUNT, ZIP, ADDRESS,, TAX,,,,,, ORDERNO,,,  CVV2


**FORCE** = <C5>, CLERK, ORDERNO,  ACCOUNT, EXP  +SWIPEINFO,  AMOUNT, APPROVECODE,  ZIP, ADDRESS


**AUTH**  = <C6>, CLERK, ORDERNO,  ACCOUNT, EXP  + SWIPEINFO,  AMOUNT, ZIP, ADDRESS,, TAX,,,,,, ORDERNO,,,  CVV2


**Answer**


If a request is not specified for a processor, **Everest**  translates the response assuming that the answer file is in the format  given below:


APPROVE=2,1


RESPONSE=3,6


AVS=9,1


CVV2=10,1


TRANID=12,12
