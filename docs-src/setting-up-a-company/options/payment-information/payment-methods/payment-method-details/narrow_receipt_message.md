---
title: Narrow Receipt Message
---

# Narrow Receipt Message


This message is printed on the receipt provided to customers from a  Point of Sale counter. You can customize the message to be printed whenever  Point of Sale invoice payments are made<font style="color: #000000;" color="#000000">.</font>


You can define variables to automatically retrieve the specified information  for each sale. The variables must be entered exactly as shown below, including  the dollar $ sign.


| Variable | Description |
| $AMOUNT$ | Amount of transaction (left justified) |
| $APPROVAL$ | The approval code |
| $CARD HOLDER$ | The card holder's name |
| $DOC AMOUNT$ | Document amount |
| $DOC DATE$ | The document creation date |
| $DOC NUMBER$ | The sales invoice or credit memo number for the document |
| $EXP$ | The credit card expiry  date |
| $METHOD$ | The payment method |
| $RAMOUNT$ | Amount of transaction (right justified) |
| $REFDATE$ | The date of collection |
| $REFNUMBER$ | The card number |
| $TODAY$ | Today's date |
| $TYPE$ | Payment type |



Click [here]({{site.sc_baseurl}}/misc/narrow_receipt_message_definition.html) for an  example of how a message could be defined.


{:.see_also}
See also
: [**Payment Method** profile - Miscellaneous  tab]({{site.sc_baseurl}}/options/payment-information/payment-methods/set-up-a-payment-method/payment_method_profile_miscellaneous_tab.html)
