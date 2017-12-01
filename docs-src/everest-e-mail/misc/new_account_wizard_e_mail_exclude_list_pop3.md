---
title: New Account Wizard - Exclude Address
---

# New Account Wizard - Exclude Address


If you specify the text in the "**Exclude 
 addresses**" **** fields,  **Everest** checks for the same in  the **To**, **Cc**  or **Bcc**  fields (for outbound mails) and the **From**  field (for inbound mails). All the addresses containing the specified  text are not linked to the **My E-mail**  and **All E-mail** browsers.


In other words, if you exclude e-mail addresses or names in the exclude  section, mails will still be sent or received but classification of the  mails based on customer, vendor or user will not be available. The **Type** column in the **Everest 
 E-Mail** window will be blank and the mails will not be listed in  the [**My 
 E-mail**]({{site.eml_baseurl}}/misc/my_e_mail_browser.html) and [**All 
 E-mail**]({{site.eml_baseurl}}/misc/all_e_mail_browser.html) browsers.


However, if you do not add any text in the exclude list, the e-mails  sent or received will be listed in the respective browsers (Customers/Vendors/  Users) under **Options &gt; E-mail &gt; 
 My E-mail/All E-mail**.


{:.example}
You have specified a customer with an e-mail  address **andy@accel.com** in the  exclude list for outbound e-mail. When you send an e-mail to **andy@accel.com**,  the e-mail is delivered but is not displayed in the **My 
 E-mail**/ **All E-mail** browser  for that customer (path: **Customers**  browser **&gt;** **Options 
 &gt; E-mail &gt; My E-mail**/**All 
 E-mail)**. The **Type** column  in the **Everest E-mail** window is  blank.

- Click **Next**. You will see the **New 
 Account Wizard - POP3 Information** section, giving you details of  the account created.
- Click **Finish** to complete the process of creating  the POP3 account. You will see your POP3 e-mail account created in the  **Folder** **List**.



{:.see_also}
See also
: [New  Account Wizard - Port Information]({{site.eml_baseurl}}/misc/new_account_wizard_port_information.html)
