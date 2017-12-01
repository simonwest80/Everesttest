---
title: Identifying the Transaction Format for a Processor
---

# Identifying the Transaction Format for a Processor


Two methods of identifying the correct format for transactions with  your Merchant Bank Provider exist.


Method 1


Use the Transaction Builder tool that is included with ICVerify 4.0.   This tool  is part of the ICVerfiy SDK and can be used to view the correct format  for each transaction type and merchant bank.


Method 2


Use the **/gx**  switch in ICVerify to display the format for .REQ  files for each processor.


{:.steps}
To identify the request transaction format,  do the following:

- Execute the  ICVerify application (ICVerify.exe)  with the /gx  switch by using the **Run** command  (**Start** > **Run**).



{:.example}
If ICVerify is installed in “C:\ICWin400\”,  enter the following command in your run parameters:


“C:\ICWin400\icverify.exe  **/gx**”

- Process transactions  in the main ICVerify window for each transaction type. When you click  'Submit' in the ICVerify window, it does not dial out; instead, the correct  request file format for the attempted transaction is displayed in a new  window.



{:.note}
You cannot identify the answer format in this  manner.


{:.steps}
To identify the answer format, do the following:

- Stop the ICVerify  service and create a transaction request in **Everest.** The .REQ  is created in the path that you define for the processor (path: **Processor** profile > **Settings**  tab > **Request Directory Name**  field).
- Close **Everest** and start ICVerify.
- ICVerify processes  the .REQ file  and generates a .ANS  file in the same folder as the request file.
- Open the .ANS  file in Notepad and create entries in the .INI  file as per the format.



{:.note}
If the format is not clear, please contact  ICVerify or your merchant bank.


{:.see_also}
See also
: [Create  an ICVerify Configuration File]({{site.sc_baseurl}}/options/payment-information/credit-card-processing/ini-file-for-icverify/create_an_icverify_configuration_file.html)
: [Configuration  File for ICVerify]({{site.sc_baseurl}}/options/payment-information/credit-card-processing/ini-file-for-icverify/configuration_file_for_icverify.html)
