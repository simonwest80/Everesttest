---
title: Customer Status
---

# Customer Status


Place your cursor over the icon in the status bar of the sales document  to view the status of the customer. The customer status indicators are  as follows:


| Status Displayed | Icon | Description |
| <font color="#000000" class="hcp4">Customer On Hold</font> | ![]({{site.sp_baseurl}}/img/sales_customer_status_icon_on_hold.gif) | The customer has been put on credit hold. |
| <font color="#000000" class="hcp4">Over Credit Limit (Has prior Purchases) <br/> </font> | ![]({{site.sp_baseurl}}/img/sales_customer_over_credit_limit_icon_status_bar.gif) | The balance due from the customer exceeds the credit  limit specified in the **Credit <br/> Limit** field in the **Payment <br/> Information** tab of the **Customer**  profile.<br/><br/><br/>The balance specified for calculating available credit  would be based on the preference made in the **Customers**  dialog box (path: **File &gt; Setup &gt; <br/> Preferences &gt; Flow Control &gt; Customers**). |
| <font color="#000000" class="hcp4">Over Credit Limit (No prior Purchases)</font> | ![]({{site.sp_baseurl}}/img/sales_over_credit_limit_no_prior_purchases_customer_status_icon_status_bar.gif) | The balance due from the customer exceeds the credit limit specified  in the **Credit <br/> Limit** field in the **Payment <br/> Information** tab of the **Customer**  profile.<br/><br/><br/>The balance specified for calculating available credit would be based  on the preference made in the **Customers**  dialog box (path: **File &gt; Setup &gt; <br/> Preferences &gt; Flow Control &gt; Customers**).<br/><br/><br/>A sales invoice has NOT been created for the customer  previously. |
| <font color="#000000" class="hcp4">Normal with prior Purchase(s)</font> | ![]({{site.sp_baseurl}}/img/sales_customer_status_normal_with_prior_purchases_icon_status_bar.gif) | The balance due from the customer does not exceed the  credit limit specified in the **Credit <br/> Limit**  field  in the **Payment Information** tab  of the [**Customer** profile]({{site.mc_chm}}/creating-a-customer/the-customer-profile-payment-information/the_customer_profile_payment_information.html).<br/><br/><br/>A sales invoice HAS been created for the customer. |
| <font color="#000000" class="hcp4">Normal without prior Purchase</font> | ![]({{site.sp_baseurl}}/img/sales_normal_no_prior_purchases_status_bar_icon.gif) | The balance due from the customer does not exceed the credit limit specified  in the **Credit <br/> Limit** field in the **Payment <br/> Information** tab of the **** [**Customer** profile]({{site.mc_chm}}/creating-a-customer/the-customer-profile-payment-information/the_customer_profile_payment_information.html).<br/><br/><br/>A sales invoice has NOT been created for the customer. |
| Past Due | ![]({{site.sp_baseurl}}/img/sales_customer_status_past_due_icon.gif) | The customer has not paid the balance by the due date  specified in the sales document. There are amounts pending on sales invoices  that are due on a date before the database server date. |
| Document is paid in Full | ![]({{site.sp_baseurl}}/img/sales_customer_status_normal_with_prior_purchases_icon_status_bar.gif) | The customer has paid the balance by the due date specified  in the sales document (Or) The customer has not exceeded the credit limit  i.e. not on credit hold. |



{:.see_also}
See also
: [Status  Bar - Sales Document Profile]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/status-bar-info/status_bar_sales_document_profile.html)
