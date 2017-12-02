---
title: Identification of E-mails to/from Vendors in Everest
---

# Identification of E-mails  to/from Vendors in Everest


**Everest MailBridge**  identifies e-mails  SENT to vendors by matching the e-mailIDs in the  **To, Cc** and **Bcc**  field with the:

- E-mail  ID specified in the billing address of the vendor
- E-mail  ID specified in any of the contact addresses of the vendor
- E-mail  ID specified in any of the return addresses of the vendor



{:.note}
The billing, return and contact addresses are entered  in the [**Vendor** profile]({{site.mv_chm}}/creating/the_vendor_profile_steps_by_steps.html) (path: **Purchasing 
 &gt; Vendors &gt; Options &gt; Edit &gt; In New Window**).


The following tables display the number of ‘tasks/e-mails’  created for each mail that you SEND, that matches the e-mail  ID of the vendor.


Tasks Created


An **Everest** task is created for  each e-mail ID, but the task will not be linked.


E-mails  Created


| **If the mail is sent <br/> to:** | **E-mails <br/> sent** |
| More than one e-mail  ID (in the **To**, **Cc**  and **Bcc**  fields), that belongs to a single vendor | One |
| E-mailIDs that belong  to more than one vendor | One for each mail you send to each vendor |



E-mails that  you RECEIVE from vendors are identified by matching the e-mailIDs in the  **From** field with the:

- E-mail  ID specified in the billing address of the vendor
- E-mail  ID specified in any of the contact addresses of the vendor
- E-mail  ID specified in any of the return addresses of the vendor



{:.note}
The billing, return and contact addresses are entered  in the [**Vendor** profile]({{site.mv_chm}}/creating/the_vendor_profile_steps_by_steps.html) (path: **Purchasing 
 &gt; Vendors &gt; Options &gt; Edit &gt; In New Window**).


The following tables display the number of ‘tasks/e-mails’  created for each mail that you RECEIVE, that matches the e-mail  ID of the vendor.


Tasks Created


An **Everest** task is created for  each e-mail ID, but the task will not be linked.


E-mails  Created


| **If the e-mail <br/> ID of the mail received:** | **E-mails <br/> received** |
| Matches the e-mail  ID of a single vendor in **Everest** | One |
| Matches the e-mail  ID of more than one vendor in **Everest** | One for each e-mail  ID that matches |



{:.see_also}
See also
: [Functions  of Everest MailBridge]({{site.mb_baseurl}}/mailbridge/functions/functions_of_everest_mailbridge.html)
