---
title: Customer Code
---

# Customer Code


Every customer is assigned a unique code in **Everest**.  The customer code identifies the:

- Customer to  whom the quote has been issued, if the document is a sales quote.
- Customer who  has placed the order, if the document is a sales order.
- Customer to  whom the items have been delivered, if the document is a sales invoice.



{:.steps}
To specify a customer code, do one of the following:

- Specify the  customer code from the **Customer**  field in the sales documents.
- Select **Popup customer selection browser when creating 
 a new sales or credit document** as a flow control preference (path:  **File** > **Setup**  > **Preferences** > **Flow 
 Control** > **Documents** > **Popups**tab) to automatically pop up the **Customer**  browser whenever a new sales document is created.



![]({{site.sp_baseurl}}/img/lens.gif)<font style="color: #800080;" color="#800080"> 
 </font>[Documents  - Flow Control - Popups  Tab]({{site.bp_chm}}/flow-ctrl/ctrl/opt/popups-tab/flow_control_setup_dialog_box_popups_tab_steps.html)


If you create a customer from the **Customer** field (path: click the drop-down  button beside the **Customer** field  > right-click in the drop-down list > select **New** from the right-click menu options > mention details and save),  this field defaults to the newly created customer's code.


When you change a customer on a sales order  or sales invoice after retrieving items into the document, **Everest**  warns you that you have changed the customer and that the prices applicable  to the selected customer may be different. You can choose from the following  options:

- **Update 
 prices based on new customer** - This option is selected by default.  Prices relevant to the new customer selected are applied.
- **Retain 
 Pricing on the document** - Selecting this option retains the prices  on the existing document. However, you must possess the required rights  to do so.



When you select a customer code on a sales  document (sales quotes/orders/invoices), it is populated with the following  default information (for the selected customer code):

- [Billing  Address]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/customer-info/customers_billing_address_customer_information_sales_document_content.html)
- [Contact  Address]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/customer-info/customers_contact_address_customer_information_sales_document_content.html)
- [Ship  to Address]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/customer-info/ship_to_address_customer_information_sales_document_content.html)
- [Sales  Representative]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/tab-details/details/other/sales_representative_sales_document_content.html)
- [Payment  Terms]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/tab-details/details/pmnt/payment_terms_payment_information_sales_document_contents.html)
- [Due  Date]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/tab-details/details/pmnt/due_date_check_box_payment_information_sales_document_contents.html)
- [Jurisdiction]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/tab-details/details/other/jurisdiction_sales_process_contents.html)
- [Delivery  Method]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/tab-details/details/delivery/ship_via_delivery_information_sales_document_content.html)
- [Loc/Sub-Loc]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/tab-details/details/other/department_document_information_sales_content.html)



{:.see_also}
See also
: [Customer  Information]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/customer-info/customer_information_sales_document_content.html)
