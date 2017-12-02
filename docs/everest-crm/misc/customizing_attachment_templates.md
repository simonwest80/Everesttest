---
title: Customizing Attachment Templates
---

# Customizing Attachment Templates


**Everest** allows you to create  your own attachment templates and send them as an HTML attachment along  with e-mails from Business Activity Monitoring to internal parties such  as users of **Everest** and external  parties such as customers and vendors whenever the specified event occurs.


{:.note}
- The attachment  templates will be only in .htm or .html format. No other file formats  are supported.
- You must copy your  own attachment templates into the folder where **xpEverestACRM.dll**  resides other than **Everest** folder  structure. This folder location can vary, but it is typically located  in the path: **C:\Program Files\Microsoft 
 SQL Server\MSSQL\Binn**. If the MS SQL instance is located on the  D: drive, the path could begin with a D instead of a C.
- If you do not copy  any attachment template files to this path, the attachments will be sent  in the system defined format.


{:.example}
: You may want to create a purchase invoice template  in your own format and send as an e-mail attachment whenever a purchase  invoice is created. To execute this, you have to create a purchase invoice  template with the given list of tags provided in **Everest**  and copy it in the specified name and path, typically **C:\Program 
 Files\Microsoft SQL Server\MSSQL\Binn**. The system will use the  attachment template file associated with the document type to generate  e-mail attachment if it is saved in the specified name and path and attached  to the event.


![]({{site.crm_baseurl}}/img/lens.gif)
: [Attachment  Template Names]({{site.crm_baseurl}}/misc/attachment_template_names.html)
: [List  of tags for Attachment Template]({{site.crm_baseurl}}/misc/list_of_tags_for_attachment_template.html)


{:.see_also}
See also
: [Send E-mail  Setup - General]({{site.crm_baseurl}}/misc/send_e_mail_setup_general.html)
