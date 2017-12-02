---
title: Workstation Settings - General - Others
---

# Workstation Settings - General - Others


Use the **Others** tab to specify  other document settings like default payment method details for change  due and for applied payments.


**Default Payment Method for Change Due**
: Specify the default payment method to be used for  change due to customers.
: When you receive an excess amount of money from  a customer on account of a Point of Sale transaction, you will have to  refund the change due to the customer. This option allows you to specify  the default payment method to be used for change due to the customer.


{:.example}
You can set 'Cash' as the default payment method for change due to customers.
: You can also specify the default payment method  to be used for change due to customers in the **Accounting**  dialog box (path: **File &gt; Setup &gt; 
 Preferences &gt; Defaults &gt; Accounting &gt; Miscellaneous** tab)  and the Cash Register profile (path: **File 
 &gt; Setup &gt; Miscellaneous &gt; Cash Register &gt; Cash Register**  profile **&gt; Payment Type &gt; Miscellaneous**  tab).
: The precedence for using the default payment method  for change due by **Everest** is:
: 1. Cash register
: 2. Workstation settings
: 3. The preference setting in accounting defaults


**Default Payment Method for Applied Payments**
: Specify the payment method to be used when amounts  are applied, using the document payment/refund options from the document  profiles. It is not used in journals.


{:.note}
The payment methods that you specify in the  **Workstation Settings** dialog box  are applicable only to the specific workstation and override the default  payment method settings for change due and applied payments, specified  in the **Accounting** dialog box (path:  **File &gt; Setup &gt; Preferences &gt; 
 Defaults &gt; Accounting &gt; Miscellaneous** tab).


Contact Manager


**Automatically check for new reminders every**
: Select this check box if you want **Everest**  to automatically check for reminders and specify the frequency for checking  reminders. You can specify a maximum value of 999 seconds. This is applicable  at the workstation level and the frequency in seconds can either be set  equal to or greater than the value set up in the **Flow 
 Control Preferences**. The value for the reminder notification in  the **Workstation settings** automatically  defaults to the value set in the flow control preferences for checking  for reminders.


{:.note}
If you specify the frequency for checking  reminders in both **Flow Control Preferences**  and **Workstation Settings**, then  the value set in **Workstation Settings**  will take precedence. Further, if the reminder notification options are  left unchecked in both the **Flow Control 
 Preferences** and **Workstation Settings**,  then reminders will **NOT** be created  in **Everest**.


**Default Cash Register for Sales Invoice**
: Select a cash register from this drop-down list  for defining the cash register for sales invoices.


**Enable incremental search when retrieving items  using smart search in Point of Sale**
: Select this check box to enable the display of matching  codes for an item as you start typing the characters in the Search for  field when adding an item using the Smart Search option. This check box  is applicable only to Point of Sale workstations.


{:.example}
If you enter 1, the search will display codes starting with 1; if you  enter 0 after this, it will list all matching codes starting with 10,  and so on.


{:.hint}
To improve scanning performance, it is recommended  that you uncheck this option at point of sale workstations to disable  the incremental search.


{:.see_also}
See also
: [Workstation  Settings - General]({{site.sc_baseurl}}/options/miscellaneous-set-up/workstation-settings/workstation_settings_general_introduction.html)
