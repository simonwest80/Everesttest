---
title: Parameters in an Answer File
---

# Parameters in an Answer File


The answer file specifies the parameter name, the starting position  (of the response) and the total number of characters (or length) in the  response.


The ANSWER format is as below:


Parameter Name - <starting position>, <length>


The length includes the starting position.


| Parameter | Description |
| APPROVE | Indicates whether the request was approved.  The  response is usually Y  or N. |
| RESPONSE | Returns the approval code if the transaction was approved or a response  code, otherwise. |
| AVS | Address Verification result |
| CVV2 | CVV2 result |
| TRANID | Transaction ID |



| ![]({{site.sc_baseurl}}/img/note.gif) | Some networks do not return a CVV2 value if CVV2 is not given or if  they do not support CVV2.  The  Answer file in such a case may or may not contain a blank space for the  CVV2 response.  This  does not matter if the CVV2 is the last part of the response. But, if  the CVV2 response is recorded in between two other response parameters,  and if a blank space is not sent, the response may not be interpreted  accurately.<br/><br/><br/>{:.example}<br/>The answer file format is:<br/><br/><br/>APPROVE = 2,1<br/><br/><br/>RESPONSE = 3,6<br/><br/><br/>AVS = 9, 1<br/><br/><br/>CVV2 = 10,1<br/><br/><br/>TRANID =  11, 8<br/><br/><br/>If a CVV2 code is not sent for a transaction, then the TRANID  may start from position 10 instead of position 11.<br/><br/><br/>Therefore, if the answer format includes CVV2 and it is in the middle  of two parameters, it is mandatory that you include the CVV2 information  in the request format.<br/><br/><br/>Some networks return the CVV2 prefixed by “CVV”.   In such  cases, the Answer format must identify only the actual CVV2 response.<br/><br/><br/>{:.example}<br/>If the 18th, 19th, and 20th positions would be occupied by "CVV"  and the actual CVV2 response would be in the 21st position, you must define  the format as:<br/><br/><br/>APPROVE = 2,1<br/><br/><br/>RESPONSE = 3,6<br/><br/><br/>AVS = 9, 1<br/><br/><br/>TRANID =  10, 8<br/><br/><br/>CVV2 = 21,1<br/><br/><br/>All formats are defined in the “Y”  type of answer format for ICVerify.<br/><br/><br/>"Y123456WA125346039401" |



{:.see_also}
See also
: [Create  an ICVerify Configuration File]({{site.sc_baseurl}}/options/payment-information/credit-card-processing/ini-file-for-icverify/create_an_icverify_configuration_file.html)
: [Configuration  File for ICVerify]({{site.sc_baseurl}}/options/payment-information/credit-card-processing/ini-file-for-icverify/configuration_file_for_icverify.html)
