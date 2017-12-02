---
title: General Information
---

# General Information


This section details the general information that needs to be specified  in the **Processor** profile.


{:.refer}
The instructional materials provided by your  payment service provider for detailed information on the following fields.


**Code and Description**
: The code and description identify the processor.  If the processor is being set up for ICVerify and for each type of credit  card supported by ICVerify, enter a name that identifies it.


{:.example}
For MasterCard, you can specify the name ICVerify Master.


**Time-out (seconds)**
: The time-out indicates the number of seconds before  which a response must be received for the transaction. After this time  lapses, the request for authorization is cancelled and it must be sent  again.


{:.note}
The time-out factor is effective from the  time the payment gateway receives the request and not from the time the  request is sent.


{:.see_also}
See also
: [**Processor** Profile - **General**  Tab]({{site.sc_baseurl}}/options/payment-information/credit-card-processing/create-a-processor/processor_profile_general_tab.html)
