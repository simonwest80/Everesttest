---
title: Customer
---

# Customer 


The customer code identifies the customer to whom the items have been  sold, and who has to be credited for the items returned.


{:.steps}
To specify a customer code, do any one of  the following:

- Specify the  customer code from the **Customer**  field in the sales return documents.
- Select **Popup customer selection browser when creating 
 a new sales and credit document** as a flow control preference (path:  **File &gt; Setup &gt; Preferences &gt; 
 Flow Control &gt; Documents &gt; Popups**  tab). You can then select the required customer from the **Customers**  browser.



![]({{site.sp_baseurl}}/img/lens.gif) [Documents  - Flow Control - Popups  Tab]({{site.bp_chm}}/flow-ctrl/ctrl/opt/popups-tab/flow_control_setup_dialog_box_popups_tab_steps.html)


If you create a customer from the **Customer** field (path: click the drop-down button beside the **Customer**  field > Right-click in the drop-down list > select **New** from the right-click menu options > mention details and save),  this field defaults to the newly created customer's code.


When you change a customer on a credit  order or credit memo after retrieving items into the document, **Everest**  warns you that you have changed the customer and that the prices applicable  to the selected customer may be different. You can choose from the following  options:

- **Update 
 prices based on new customer** - This option is selected by default.  Prices relevant to the new customer selected are applied.
- **Retain 
 Pricing on the document** - Selecting this option retains the prices  on the existing document. However, you must possess the required rights  to do so.



<font style="font-family: Verdana;" face="Verdana">When you select a 
 customer code from a sales return document (credit quotes/orders/memos) 
 it is populated with the following default information (for the selected 
 customer code):</font>

- [Billing  Address]({{site.sp_baseurl}}/sales-ret-docs/sales-ret-doc/contents/customer-info/billing_address_customer_information_sales_return_document_content.html)
- [Contact  Address]({{site.sp_baseurl}}/sales-ret-docs/sales-ret-doc/contents/customer-info/customer_contact_address_customer_information_sales_return_document_content.html)
- [Ship  To Address]({{site.sp_baseurl}}/sales-ret-docs/sales-ret-doc/contents/customer-info/return_to_address_customer_information_sales_return_document_content.html)
- [Sales  Representative for the Customer]({{site.sp_baseurl}}/sales-ret-docs/sales-ret-doc/contents/tab-details/dtls-info/other/sale_representative.html)
- [Payment  Terms]({{site.sp_baseurl}}/sales-ret-docs/sales-ret-doc/contents/pmnt/payment_terms_payment_information_sales_return_document_content.html)
- [Due  Date]({{site.sp_baseurl}}/sales-ret-docs/sales-ret-doc/contents/pmnt/due_date_payment_information_sales_return_document_content.html)
- [Jurisdiction]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/tab-details/details/other/jurisdiction_sales_process_contents.html)
- [Delivery  Method]({{site.sp_baseurl}}/sales-ret-docs/sales-ret-doc/contents/tab-details/dtls-info/delivery/ship_via_delivery_information_sales_return_document_content.html)
- [Loc/Sub-Loc]({{site.sp_baseurl}}/sales-ret-docs/sales-ret-doc/contents/tab-details/dtls-info/other/department_document_information_sales_return_document_content.html)



{:.see_also}
See also
: [Customer  Information]({{site.sp_baseurl}}/sales-ret-docs/sales-ret-doc/contents/customer-info/customer_information_sales_return_documents_content.html)
