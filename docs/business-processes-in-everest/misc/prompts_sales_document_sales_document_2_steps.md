---
title: Prompts - Sales Document - Sales Document 2
---

# Prompts - Sales Document - Sales Document 2


Use this tab to set up prompt options for automating some  functions related to items and item selections and for applying deposits  while creating sales documents.


**Prompt user to select related items for items  not available in stock**
: Select whether or not related items must be displayed  if there is no stock of an item that is retrieved into the document.
: ![]({{site.bp_baseurl}}/img/lens.gif) [Prompt  user to select related item for items not available in stock]({{site.bp_baseurl}}/misc/prompt_user_to_select_related_item_for_items_not_available_in_stock_doc_flow_control_sales2.html)


**Display list of add-ons when adding items to  sales documents**
: Select whether or not add-ons should be automatically  displayed when an item (for which an add-on has been defined) is retrieved  into a sales document.
: ![]({{site.bp_baseurl}}/img/lens.gif) [Display  list of add-ons when adding items to sales documents]({{site.bp_baseurl}}/misc/display_list_of_add_ons_when_adding_items_to_sales_documents_doc_flow_control_sales2.html)


**Prompt method for adding shipping charges calculated  by an external program**
: Specify whether or not the freight charges computed  by an external utility have to be automatically updated on sales orders/invoices.
: ![]({{site.bp_baseurl}}/img/lens.gif) [Prompt  method for adding shipping charges calculated by an external program]({{site.bp_baseurl}}/misc/prompt_method_for_adding_shipping_charges_calculated_by_an_external_program_doc_fc_prompts_sales_doc_2_cont.html)


**Prompt for duplicate PO number from the same  customer**
: Check this box to be prompted every time a duplicate  PO number is created for the same customer.


![]({{site.bp_baseurl}}/img/lens.gif) [Prompt  for duplicate PO number from the same customer]({{site.bp_baseurl}}/misc/prompt_for_duplicate_po_number_from_the_same_customer_pucahse_tab_prompts_business_process_content.html)


**Prompt for customer credit status when sales  order is converted into sales invoice in the pull sheet browser**
: Select this option to check if customers have exceeded  their credit limit and/or are on credit hold, when a sales order is converted  to an invoice in the **Pull Sheet**  browser.
: ![]({{site.bp_baseurl}}/img/lens.gif)[Prompt  for customer credit status when sales order is converted into sales invoice  in the pull sheet browser]({{site.bp_baseurl}}/misc/prompt_for_cust_credit_status_when_so_is_converted_into_si.html)


**Automatically  transfer pending authorizations from Sales Order to Sales Invoice**
: Select whether or not pending credit card authorizations  available in the sales order should be automatically transferred when  a sales order is converted to a sales invoice. Enabling this option allows  you to more easily process payments from the batch payment browsers after  an order has been shipped.


{:.note}
When an order is partially invoiced and this  option is enabled, the system will transfer the pending authorization  to the partial invoice and retain a copy for the remainder of the order.  This copied batch payment will use the same credit card information but  will change to a “Sale” type transaction during future processing. The  type change happens because the authorization will be consumed by the  partial invoice.


**Method for applying deposit collected on a sales  order when converting it to a sales invoice**
: **Everest**  calculates finance charges on overdue sales documents based on the amounts  outstanding in the document. Select a method to apply deposits.
: ![]({{site.bp_baseurl}}/img/lens.gif) [Method  for applying deposit collected on a sales order at the time of converting  it to a sales invoice]({{site.bp_baseurl}}/misc/method_of_applying_deposit_collected_on_a_sales_order_at_the_time_of_converting_it_to_a_sales_invoice.html)


{:.see_also}
See also
: [Documents  Dialog Box - Prompts - Sales Document Tab]({{site.bp_baseurl}}/flow-ctrl/ctrl/opt/prompts-tab/prompts_sales_document_tab_step_by_step_business_process_in_everest.html)
