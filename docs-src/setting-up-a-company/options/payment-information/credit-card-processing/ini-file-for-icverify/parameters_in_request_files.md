---
title: Parameters in a Request File
---

# Parameters in a Request File


Request files will include several parameters describing the accounting  number and other details of the transaction.


**Transaction type:**


| Transaction name | Parameter | Identifier in Format |
| Sale | C1 | SALE |
| Ship (prior booking) | CO | SHIP |
| Book | C4 | BOOK |
| Force Sale | C5 | FORCE |
| Authorization/Pre-authorization | C6 | AUTH |
| Return or Refund | C3 | REFUND |



**Other Parameters:**


| Parameter | Description |
| CLERK | Denotes the user. **Everest** uses  this field to specify the merchant sequence number if multiple merchants  are enabled for the processor (path: **Processor**  profile > **Settings** tab **&gt; Use Multiple Accounts** field is  selected). |
| ORDERNO | Denotes the document number. |
| ACCOUNT | Denotes the credit card number. |
| EXP | Denotes the expiry  date on the card. **Everest** sends  the expiry  date in the format MMYY. |
| SWIPEINFO | Indicates the swipe information without a % sign. Normally the Track  1 data begins with a % sign. Some processors might require that the swipe  information be sent without the leading % sign. |
| SWIPEINFO% | Indicates the swipe information with ‘%’. |
| TRACK1 | Denotes Track 1 data for the swipe information. This parameter is used  if only Track 1 data is required by the processing network. |
| TRACK2 | Denotes Track 2 data for the swipe information. This parameter is used  if only Track 2 data is required by the processing network. |
| AMOUNT | Indicates the amount for which the transaction is processed. ICVerify  correctly processes amounts with up to two places of decimal accuracy  only. |
| TAX | Indicates the Tax on the transaction. This field is for information  only. The tax information is mandatory for some processing networks and  is required as a Tier 1 data for Purchase Cards. **Everest**  computes the proportional tax for the payment amount (i.e. tax is computed  in proportion to the payment amount and document amount). However, the  transaction is processed only for the Amount. |
| ADDRESS | Indicates the address that is sent for verification. |
| ZIP | Indicates the zip code that is sent for verification. |
| CVV2 | Indicates the CVV2 code. |
| APPROVECODE | Indicates the Approval code. This is mandatory for Force Sale transactions,  and is sometimes required for Ship type of transactions. |



{:.see_also}
See also
: [Create  an ICVerify Configuration File]({{site.sc_baseurl}}/options/payment-information/credit-card-processing/ini-file-for-icverify/create_an_icverify_configuration_file.html)
: [Configuration  File for ICVerify]({{site.sc_baseurl}}/options/payment-information/credit-card-processing/ini-file-for-icverify/configuration_file_for_icverify.html)
