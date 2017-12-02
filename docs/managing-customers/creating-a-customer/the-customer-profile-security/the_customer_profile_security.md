---
title: The Customer Profile - Security
---

# The Customer Profile - Security


This tab is used to enter the security details for the customer. You  need to specify details in this tab only if you have set up an online  store using **Everest Enterprise E-Commerce**.


![]({{site.mc_baseurl}}/img/lens.gif) [Security]({{site.mc_baseurl}}/customer-details/e-commerce/security.html)


**Password**
: This field displays the password used by your online  customer to login to your online store.


**Confirm password**
: When a customer's password is modified, the password  entered has to be confirmed before it can be saved.


**Secret question**
: This field displays the secret question that the  customer will be prompted with, if the customer does not remember the  password.


**Secret answer**
: This field displays the answer entered by the customer  for the secret question. If the customer enters the correct answer, the  password is mailed to the customer.


Account Lockout


In accordance with the specified settings in the E-Commerce Preferences  (path: **File &gt; Setup &gt; E-Commerce 
 &gt; Preferences &gt; Customer &gt; Security** tab), **Everest**  verifies the number of invalid attempts to log in to your website  and locks out the account of such customers. The lockout status of a customer  is reflected in this section.


**Lock Account**
: This check box is automatically selected when **Everest** locks out the account of a customer.


**![]({{site.mc_baseurl}}/img/image1.gif)**
: Click this icon to view the reason for the lockout  status of a customer in the **Notes**  dialog box. This dialog box is updated with information based on the reason  for the account’s lockout.
: ![]({{site.mc_baseurl}}/img/example.gif) ‘Exceeded  the allowed number of login attempts’ or ‘Exceeded the number of credit  card usage attempts’.
: You can edit the information  in the **Notes** dialog box.


Back-end Processes for Account Lockout


When **Everest** detects a fraudulent  customer and locks out the corresponding customer’s account, an event  is triggered to send an e-mail to the merchant, that is, you.


Persons specified in the billing and contact addresses profile for the  locked out customer are also denied access to the account.


![]({{site.mc_baseurl}}/img/lens.gif)[Manually Lock an  Account]({{site.mc_baseurl}}/misc/manually_lock_an_account.html)


{:.see_also}
See also
: [The Customer  Profile]({{site.mc_baseurl}}/creating-a-customer/the_customer_profile_steps.html)
