---
title: Sample .INI File
---

# Sample .INI  File


**Request Format**


You run the /gx  switch for the processor “ICVERRET”  (i.e. IC Verify Processor for the ‘Retail’ Business Type) and get the  following response:


"C1","clerk<CMN>custname","SO1245","4111111111111111","0601","10.00","N",


"54845","bill address","0.02","2545"


Enter the following in the .INI  file:


[REQUEST ICVERIFY]


**SALE**=<C1>,CLERK,ORDERNO,ACCOUNT,EXP+SWIPEINFO,AMOUNT,,ZIP,


ADDRESS,TAX,CVV2


Similarly, you can enter the following:


**SHIP**=<CO>,CLERK,ORDERNO,ACCOUNT,EXP,AMOUNT,,ZIP,ADDRESS,


TAX,CVV2


**REFUND**=<C3>,CLERK,ORDERNO,ACCOUNT,EXP,AMOUNT


**BOOK**=<C4>,CLERK,ORDERNO,ACCOUNT,EXP,AMOUNT,,ZIP,ADDRESS,


TAX


**FORCE**=<C5>,CLERK,ORDERNO,ACCOUNT,EXP,AMOUNT,APPROVECODE,


TAX,CVV2


**AUTH**  = <C6>,CLERK,ORDERNO,ACCOUNT,EXP,HARDCODE,ZIP,


AMOUNT,ADDRESS,CVV2


**Answer Format**


If the Answer text (which includes the double quote) is "Y123456WA125346039401",  enter the following in the .INI  file:


[ANSWER ICVERIFY]


APPROVE=2,1 [Here, the starting position is 2 and the length is 1]


RESPONSE=3,6


AVS=9,1


CVV2=10,1


TRANID=10,12


The data is read as below:


APPROVE = Y


RESPONSE = 123456


AVS = W


CVV2 = A


TRANID =  125346039401
