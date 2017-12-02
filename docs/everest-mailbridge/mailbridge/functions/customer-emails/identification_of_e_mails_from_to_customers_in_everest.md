---
title: Identification of E-mails from/to Customers in Everest
---

# Identification of E-mails  from/to Customers in Everest


**Everest MailBridge**  identifies e-mails  SENT to customers by matching the e-mailIDs in the  **To**, **Cc**  and **Bcc**  fields with the:

- E-mail  ID specified in the billing address of the customer
- E-mail  ID specified in any of the contact addresses of the customer
- E-mail  ID specified in any of the shipping addresses of the customer



{:.note}
The billing, shipping and contact addresses are entered  in the [**Customer** profile]({{site.mc_chm}}/creating-a-customer/the_customer_profile_steps.html) (path: **Invoicing 
 &gt; Customers &gt; Options &gt; Edit &gt; In New Window**).


The following tables display the number of ‘tasks/e-mails’  created for each e-mail  that you SEND, that matches the e-mail  ID of customer.


Tasks Created


| **If the e-mail <br/> is sent to:** | **Tasks created** |
| More than one e-mail  ID (specified in the **To**, **Cc** and **Bcc**  fields), that belongs to a single customer | One |
| E-mailIDs that belong  to more than one customer | One for each mail you send to each customer |



E-mails  Created


| **If the e-mail <br/> is sent to:** | **E-mails <br/> sent** |
| More than one e-mail  ID (specified in the **To**, **Cc** and **Bcc**  fields), that belongs to a single customer | One |
| E-mailIDs that belong  to more than one customer | One for each mail you send to each customer |



E-mails that  you RECEIVE from customers are identified by matching the e-mailIDs in the  **From** field with the:

- E-mail  ID specified in the billing address of the customer
- E-mail  ID specified in any of the contact addresses of the customer
- E-mail  ID specified in any of the shipping addresses of the customer



{:.note}
The billing, shipping and contact addresses are entered  in the [**Customer** profile]({{site.mc_chm}}/creating-a-customer/the_customer_profile_steps.html) (path: **Invoicing 
 &gt; Customers &gt; Options &gt; Edit &gt; In New Window**).


The following tables display the number of ‘tasks/e-mails’  created for each mail that you RECEIVE, that matches the e-mail  ID of the customer.


Tasks Created


| **If the e-mail <br/> ID of the mail received:** | **Tasks created** |
| Matches the e-mail  ID of a single customer in **Everest** | One |
| Matches the e-mail  ID of more than one customer in **Everest** | One for each e-mail  ID that<br/><br/><br/>matches |



E-mails  Created


| **If the e-mail <br/> ID of the mail received:** | **E-mails <br/> received** |
| Matches the e-mail  ID of a single customer in **Everest** | One |
| Matches the e-mail  ID of more than one customer in **Everest** | One for each e-mail  ID that is matches |



{:.see_also}
See also
: [Functions  of Everest MailBridge]({{site.mb_baseurl}}/mailbridge/functions/functions_of_everest_mailbridge.html)
