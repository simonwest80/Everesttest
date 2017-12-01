---
title: Settings in AVS.ini File
---

# Settings in AVS.ini  File


The AVS.ini  file is by default installed in the System 32 directory of your Application  server and Web server also if it is a different server.


The AVS.ini  file contains defaults settings for **Everest**  processors that use "Payflow" as the **Service**.


![]({{site.sc_baseurl}}/img/lens.gif)  [Processor  Profile - Settings tab]({{site.sc_baseurl}}/options/payment-information/credit-card-processing/create-a-processor/the_processors_profile_settings.html)


It has the following three tags.


**COUNTRY**
: This setting determines whether the address/zip  settings of this .ini  file should apply to US('U'),  Non-US('N')  or ALL('A')  customers.


**ADDRESS and ZIP**
: These settings determine whether the Address or  Zip verification result should be ignored or considered.
: R - Required
: O - Optional
: N  - NONE


{:.example}
If you want PayFlow  Pro to verify addresses of Non-US customers also, you can make the following  setting:


COUNTRY = A


ADDRESS = R


ZIP = R


If you make any other settings in the above-mentioned tags (apart from  those specified), **Everest** treats  the default setting as 'NONE'.
