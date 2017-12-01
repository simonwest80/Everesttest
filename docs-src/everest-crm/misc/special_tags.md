---
title: Special Tags
---

# Special Tags


One of the special tags is **Payment 
 Information**. When you select this tag in your e-mail template,  the complete payment details are generated and sent with the mail in a  table format. This tag is available for all document related event groups.


| ![]({{site.crm_baseurl}}/img/example.gif) | This is how order details to a customer  with the following format will be seen:<br/><br/><br/>Sales Order #: <#SOORDNO>  as Sales Order # 850004<br/><br/><br/>Sales Order date: <#SODOCDT>  as Sales Order Date: 5/5/2003<br/><br/><br/>Customer name: <#SOCUSTFIRSTNAMECONT>  as Customer Name: DOUGLAS<br/><br/><br/>Payment Info: <#SODOCPYMNTINFO>  as<br/><br/><br/>Payment Info:<br/><br/><br/>| Journal Date | Pay Type | Check No | Check Date | Amount Forex(F) | Amount Base($) | Type |<br/>| 5/5/2003 | CASH |  | 5/5/2003 | 73.28 | 10.23 | Payment | |



Another special tag, **Attach Document**  is available only for the template type **E-mail**.  When you select this tag, **Everest**  generates the document as an HTML file and attaches it with the mail to  the recipient. This tag is available for all document related event groups.


For instance, to send a sales invoice to a customer as an e-mail attachment,  choose the <#ATTACHDOCUMENT>  tag in your template.
