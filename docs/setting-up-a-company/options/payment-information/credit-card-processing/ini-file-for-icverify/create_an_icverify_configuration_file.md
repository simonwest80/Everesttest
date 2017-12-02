---
title: Create an ICVerify Configuration File
---

# Create an ICVerify Configuration File


{:.steps}
To create an ICVerify Configuration file,  do the following:

- In a notepad,  enter all the request and answer formats required by processors that use  the ICVerify service.
- Save the file  as **ICVERREQ.INI**.



{:.note}
Ensure that you save the file ONLY with this  name.

- Save the above  .INI file in  your **Everest** Application folder  (path: C:\Program  Files\Icode\Everest\Application).



{:.note}
- If an .INI  file is not available or if an .INI  file is available but a format is not found for the processor code and  the specified transaction, **Everest**  generates requests and translates responses in the default format.



![]({{site.sc_baseurl}}/img/lens.gif)  [Default  Format Used by Everest]({{site.sc_baseurl}}/options/payment-information/credit-card-processing/ini-file-for-icverify/default_format_used_by_everest_ic_verify_ini_files.html)

- If an .INI  file is available, and a request format is specified for the processor  code and the specified transaction, **Everest**  generates the request in the specified format.
- If an .INI  file is available and a request format is specified but not a matching  answer format, **Everest** translates  the response in the default format.
- If the request  format differs from the default format, but is applicable to all ICVerify  processors that are set up in **Everest**,  the same format has to be specified for each processor code.


{:.see_also}
See also
: [Pointers  for Creating .INI  file in Everest]({{site.sc_baseurl}}/options/payment-information/credit-card-processing/ini-file-for-icverify/pointers_for_creating_.ini_file_in_everest.html)
: [Sample .INI  File]({{site.sc_baseurl}}/options/payment-information/credit-card-processing/ini-file-for-icverify/sample_.ini_file.html)
